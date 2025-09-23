using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UML_Projekt
{
    public partial class Form1 : Form
    {
        public List<UmlClass> diagramClasses = new List<UmlClass>();
        public List<Connection> connections = new List<Connection>();

        private UmlClass selectedClass = null;
        private Point mouseOffset;
        private bool isDragging = false;

        private string connectionType { get; set; }
        UmlClass firstSelected = null;
        UmlClass secondSelected = null;
        private bool isConnecting = false;
        private bool isChecked = false;

        public Form1()
        {
            InitializeComponent();
            DiagramBox.BackColor = Color.Gray;
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

                        diagramClasses.Add(newClass);

                        DiagramBox.Invalidate();
                    }
                }
            }
        }

        private void DiagramBox_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var umlClass in diagramClasses)
            {
                umlClass.Draw(e.Graphics);
            }

            foreach (var conn in connections)
            {
                Point p1 = conn.From.Bounds.Location + new Size(conn.From.Bounds.Width / 2, conn.From.Bounds.Height / 2);
                Point p2 = conn.To.Bounds.Location + new Size(conn.To.Bounds.Width / 2, conn.To.Bounds.Height / 2);

                if (conn.ConType == "Arrow")
                    DrawArrow(g, p1, p2);
                else if (conn.ConType == "Dashed")
                {
                    using (Pen dashedPen = new Pen(Color.Black, 2))
                    {
                        dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        g.DrawLine(dashedPen, p1, p2);
                    }
                }
                else
                    g.DrawLine(Pens.Black, p1, p2);
            }
        }

        private void DiagramBox_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var cls in diagramClasses)
            {
                Rectangle rect = new Rectangle(cls.Position, cls.Size);
                if (rect.Contains(e.Location))
                {
                    selectedClass = cls;
                    mouseOffset = new Point(e.X - cls.Position.X, e.Y - cls.Position.Y);
                    isDragging = true;
                    break;
                }
            }
        }

        private UmlClass FindDiagramAt(Point location)
        {
            foreach (var cls in diagramClasses)
            {
                Rectangle rect = new Rectangle(cls.Position, cls.Size);
                if (rect.Contains(location))
                {
                    selectedClass = cls;
                    return cls;
                }
            }
            return null;
        }

        private void DiagramBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedClass != null)
            {
                // Výpočet nové pozice s ohledem na hranice PictureBoxu
                int newX = Math.Max(0, Math.Min(e.X - mouseOffset.X, DiagramBox.Width - selectedClass.Size.Width));
                int newY = Math.Max(0, Math.Min(e.Y - mouseOffset.Y, DiagramBox.Height - selectedClass.Size.Height));

                selectedClass.Position = new Point(newX, newY);
                selectedClass.Bounds = new Rectangle(selectedClass.Position, selectedClass.Size);

                DiagramBox.Invalidate();
            }
        }

        private void DiagramBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedClass = null;
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
            this.connectionType = "simple";
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

            this.connectionType = "Dashed";
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }

        private void connectionArrowBTN_Click(object sender, EventArgs e)
        {
            this.connectionType = "Arrow";
            isConnecting = true;
            firstSelected = null;
            secondSelected = null;
        }
        private void DrawArrow(Graphics g, Point from, Point to)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(pen, from, to);
            }
        }

        private void DiagramBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isConnecting)
                return; // Pokud není aktivní režim propojení, nic nedělej

            UmlClass clicked = FindDiagramAt(e.Location);
            System.Diagnostics.Debug.WriteLine($"Clicked at: {e.Location}, Found: {clicked?.Name}");
            if (clicked != null)
            {
                if (firstSelected == null)
                    firstSelected = clicked;
                else
                {
                    secondSelected = clicked;
                    connections.Add(new Connection()
                    {
                        From = firstSelected,
                        To = secondSelected,
                        ConType = connectionType
                    });
                    firstSelected = null;
                    secondSelected = null;
                    isConnecting = false; // propojení hotovo, režim vypnout
                    DiagramBox.Invalidate();
                }
            }
        }

        private void DiagramBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FindDiagramAt(e.Location);
            if (selectedClass != null)
            {
                EditForm newEditForm = new EditForm(selectedClass);
                newEditForm.FormBorderStyle = FormBorderStyle.FixedDialog;

                newEditForm.MaximizeBox = false;
                newEditForm.MinimizeBox = false;
                newEditForm.StartPosition = FormStartPosition.CenterScreen;

                using (newEditForm)
                {
                    
                    if (newEditForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedClass.Name = newEditForm.EditedClass.Name;
                        selectedClass.Atributes = newEditForm.EditedClass.Atributes;
                        selectedClass.Methods = newEditForm.EditedClass.Methods;
                        selectedClass.IsAbstract = newEditForm.EditedClass.IsAbstract;
                        selectedClass.IsStatic = newEditForm.EditedClass.IsStatic;

                        this.DiagramBox.Invalidate();
                    }
                }
            }
        }
    }
}
