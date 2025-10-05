using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UML_Projekt
{
    public partial class Form1 : Form
    {
        public List<UmlElement> diagramElements = new List<UmlElement>();

        public List<Connection> connections = new List<Connection>();

        private UmlElement selectedElement = null;

        private Point mouseOffset;
        private bool isDragging = false;

        private RelationType connectionType;
        UmlElement firstSelected = null;
        UmlElement secondSelected = null;
        private bool isConnecting = false;
        private bool isChecked = false;

        // zoom a pan
        float zoom = 1.0f;
        PointF offset = new PointF(0, 0);

        private bool isPanning = false;
        private Point panStart;

        public Form1()
        {
            InitializeComponent();
            DiagramBox.BackColor = Color.Gray;
            this.MouseWheel += Form1_MouseWheel;
            DiagramBox.MouseEnter += (s, e) => DiagramBox.Focus();
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            float oldZoom = zoom;
            zoom *= e.Delta > 0 ? 1.1f : 0.9f;
            zoom = Math.Clamp(zoom, 0.2f, 4f);

            offset.X = e.X - (e.X - offset.X) * (zoom / oldZoom);
            offset.Y = e.Y - (e.Y - offset.Y) * (zoom / oldZoom);
            DiagramBox.Invalidate();
        }

        private void addClassBTN_Click(object sender, EventArgs e)
        {
            NewClassForm newClassForm = new NewClassForm();
            newClassForm.FormBorderStyle = FormBorderStyle.FixedDialog;

            newClassForm.MaximizeBox = false;
            newClassForm.MinimizeBox = false;
            newClassForm.StartPosition = FormStartPosition.CenterScreen;

            using (newClassForm)
            {
                if (newClassForm.ShowDialog() == DialogResult.OK)
                {
                    UmlClass newClass = newClassForm.CreatedClass;

                    if (newClass != null)
                    {
                        newClass.Bounds = new Rectangle(50, 50, 150, 100);
                        newClass.Position = new Point(50, 50);
                        newClass.Size = new Size(150, 100);

                        diagramElements.Add(newClass);

                        firstSelected = null;
                        secondSelected = null;
                        isConnecting = false;

                        DiagramBox.Invalidate();
                    }
                }
            }
        }

        private void DiagramBox_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(offset.X, offset.Y);
            g.ScaleTransform(zoom, zoom);

            foreach (var umlElement in diagramElements)
            {
                umlElement.Draw(g);
            }

            foreach (var conn in connections)
            {
                conn.Draw(g);
            }
        }

        // Pomocná metoda pro převod souřadnic myši na diagramové souřadnice
        private PointF ScreenToDiagram(Point screenPoint)
        {
            return new PointF(
                (screenPoint.X - offset.X) / zoom,
                (screenPoint.Y - offset.Y) / zoom
            );
        }

        private void DiagramBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isPanning = true;
                panStart = e.Location;
                Cursor = Cursors.Hand;
                return;
            }

            PointF diagramPoint = ScreenToDiagram(e.Location);

            System.Diagnostics.Debug.WriteLine($"Checking {diagramElements.Count} elements");
            foreach (var cls in diagramElements)
            {
                RectangleF rect = new RectangleF(cls.Position, cls.Size);
                if (rect.Contains(diagramPoint))
                {
                    selectedElement = cls;
                    mouseOffset = new Point((int)(diagramPoint.X - cls.Position.X), (int)(diagramPoint.Y - cls.Position.Y));
                    isDragging = true;
                    break;
                }
            }
        }

        private UmlElement FindDiagramAt(Point location)
        {
            PointF diagramPoint = ScreenToDiagram(location);
            foreach (var cls in diagramElements)
            {
                RectangleF rect = new RectangleF(cls.Position, cls.Size);
                if (rect.Contains(diagramPoint))
                {
                    selectedElement = cls;
                    return cls;
                }
            }
            return null;
        }

        private void DiagramBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPanning)
            {
                offset.X += e.X - panStart.X;
                offset.Y += e.Y - panStart.Y;
                panStart = e.Location;
                DiagramBox.Invalidate();
                return;
            }

            if (isDragging && selectedElement != null)
            {
                PointF diagramPoint = ScreenToDiagram(e.Location);
                int newX = Math.Max(0, Math.Min((int)diagramPoint.X - mouseOffset.X, (int)(DiagramBox.Width / zoom - selectedElement.Size.Width)));
                int newY = Math.Max(0, Math.Min((int)diagramPoint.Y - mouseOffset.Y, (int)(DiagramBox.Height / zoom - selectedElement.Size.Height)));
                selectedElement.Position = new Point(newX, newY);
                selectedElement.Bounds = new Rectangle(selectedElement.Position, selectedElement.Size);
                DiagramBox.Invalidate();
            }
        }

        private void DiagramBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPanning)
            {
                isPanning = false;
                Cursor = Cursors.Default;
                return;
            }
            isDragging = false;
            selectedElement = null;
        }

        private void connectionSimpleBTN_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                connectionSimpleBTN.Text = connectionSimpleBTN.Text + " ✓";
            }
            else
            {
                connectionSimpleBTN.Text = connectionSimpleBTN.Text.Replace(" ✓", "");
            }
            connectionType = RelationType.Association;
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }

        private void connectionDashedBTN_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                connectionDashedBTN.Text = connectionDashedBTN.Text + " ✓";
            }
            else
            {
                connectionDashedBTN.Text = connectionDashedBTN.Text.Replace(" ✓", "");
            }

            this.connectionType = RelationType.Aggregation;
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }

        private void connectionArrowBTN_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                connectionArrowBTN.Text = connectionArrowBTN.Text + " ✓";
            }
            else
            {
                connectionArrowBTN.Text = connectionArrowBTN.Text.Replace(" ✓", "");
            }

            this.connectionType = RelationType.Composition;
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }

        private void DiagramBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isConnecting)
            {
                firstSelected = null;
                secondSelected = null;
                return;
            }

            UmlElement clicked = FindDiagramAt(e.Location);
            System.Diagnostics.Debug.WriteLine($"Clicked at: {e.Location}, Found: {clicked?.Name}");
            if (clicked != null)
            {
                if (firstSelected == null)
                {
                    firstSelected = clicked;
                    System.Diagnostics.Debug.WriteLine($"First selected: {firstSelected?.Name}");
                }
                else
                {
                    secondSelected = clicked;
                    System.Diagnostics.Debug.WriteLine($"Second selected: {secondSelected?.Name}");
                    connections.Add(new Connection()
                    {
                        From = firstSelected,
                        To = secondSelected,
                        Type = connectionType
                    });
                    firstSelected = null;
                    secondSelected = null;
                    isConnecting = false;
                    DiagramBox.Invalidate();
                }
            }
            else
            {
                firstSelected = null;
                secondSelected = null;
            }
        }

        
        private void DiagramBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UmlElement selectedElement = FindDiagramAt(e.Location);
            if (selectedElement == null)
                return;

            if (selectedElement is UmlClass selectedClass)
            {
                EditForm editForm = new EditForm(selectedClass);
                editForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                editForm.MaximizeBox = false;
                editForm.MinimizeBox = false;
                editForm.StartPosition = FormStartPosition.CenterScreen;

                using (editForm)
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedClass.Name = editForm.EditedClass.Name;
                        selectedClass.Atributes = editForm.EditedClass.Atributes;
                        selectedClass.Methods = editForm.EditedClass.Methods;
                        selectedClass.IsAbstract = editForm.EditedClass.IsAbstract;
                        selectedClass.IsStatic = editForm.EditedClass.IsStatic;
                        DiagramBox.Invalidate();
                    }
                }
            }
            else if (selectedElement is UmlInterface selectedInterface)
            {
                EditInterfaceForm editInterfaceForm = new EditInterfaceForm(selectedInterface);
                editInterfaceForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                editInterfaceForm.MaximizeBox = false;
                editInterfaceForm.MinimizeBox = false;
                editInterfaceForm.StartPosition = FormStartPosition.CenterScreen;

                using (editInterfaceForm)
                {
                    if (editInterfaceForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedInterface.Name = editInterfaceForm.EditedInterface.Name;
                        selectedInterface.Methods = editInterfaceForm.EditedInterface.Methods;
                        DiagramBox.Invalidate();
                    }
                }
            }
            else if (selectedElement is UmlEnum selectedEnum)
            {
                EditEnumForm editEnumForm = new EditEnumForm(selectedEnum);
                editEnumForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                editEnumForm.MaximizeBox = false;
                editEnumForm.MinimizeBox = false;
                editEnumForm.StartPosition = FormStartPosition.CenterScreen;

                using (editEnumForm)
                {
                    if (editEnumForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedEnum.Name = editEnumForm.EditedEnum.Name;
                        DiagramBox.Invalidate();
                    }
                }
            }
        } 

        private void addInterfaceBTN_Click(object sender, EventArgs e)
        {
            NewInterfaceForm newInterfaceForm = new NewInterfaceForm();
            newInterfaceForm.FormBorderStyle = FormBorderStyle.FixedDialog;

            newInterfaceForm.MaximizeBox = false;
            newInterfaceForm.MinimizeBox = false;
            newInterfaceForm.StartPosition = FormStartPosition.CenterScreen;

            using (newInterfaceForm)
            {
                if (newInterfaceForm.ShowDialog() == DialogResult.OK)
                {
                    UmlInterface newInterface = newInterfaceForm.createdInterFace;

                    if (newInterface != null)
                    {
                        newInterface.Bounds = new Rectangle(50, 50, 150, 100);
                        newInterface.Position = new Point(50, 50);
                        newInterface.Size = new Size(150, 100);

                        diagramElements.Add(newInterface);

                        firstSelected = null;
                        secondSelected = null;
                        isConnecting = false;

                        DiagramBox.Invalidate();
                    }
                }
            }
        }

        private void addEnumBTN_Click(object sender, EventArgs e)
        {
            NewEnumForm newEnumForm = new NewEnumForm();
            newEnumForm.FormBorderStyle = FormBorderStyle.FixedDialog;

            newEnumForm.MaximizeBox = false;
            newEnumForm.MinimizeBox = false;
            newEnumForm.StartPosition = FormStartPosition.CenterScreen;

            using (newEnumForm)
            {
                if (newEnumForm.ShowDialog() == DialogResult.OK)
                {
                    UmlEnum newEnum = newEnumForm.createdEnum;

                    if (newEnum != null)
                    {
                        newEnum.Bounds = new Rectangle(50, 50, 150, 100);
                        newEnum.Position = new Point(50, 50);
                        newEnum.Size = new Size(150, 100);

                        diagramElements.Add(newEnum);

                        firstSelected = null;
                        secondSelected = null;
                        isConnecting = false;

                        DiagramBox.Invalidate();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                button4.Text = button4.Text + " ✓";
            }
            else
            {
                button4.Text = button4.Text.Replace(" ✓", "");
            }

            this.connectionType = RelationType.Generalization;
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                button5.Text = button5.Text + " ✓";
            }
            else
            {
                button5.Text = button5.Text.Replace(" ✓", "");
            }

            this.connectionType = RelationType.Realization;
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (isChecked)
            {
                button1.Text = button1.Text + " ✓";
            }
            else
            {
                button1.Text = button1.Text.Replace(" ✓", "");
            }

            this.connectionType = RelationType.Dependency;
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }
    }
}
