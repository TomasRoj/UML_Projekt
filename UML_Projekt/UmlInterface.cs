using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Projekt
{
    public class UmlInterface : UmlElement
    {

        public List<UmlMethod> Methods { get; set; }

        public UmlInterface(string name, List<UmlMethod> methods)
        {
            Name = name;
            Methods = methods;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.LightCyan, Bounds);

            int y = Bounds.Top;

            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            string headerText = "<<interface>>";
            SizeF headerSize = g.MeasureString(headerText, headerFont);
            SizeF nameSize = g.MeasureString(Name, headerFont);

            g.DrawString(headerText, headerFont, Brushes.Black,
                Bounds.Left + (Bounds.Width - headerSize.Width) / 2, y);
            y += (int)headerSize.Height;

            g.DrawString(Name, headerFont, Brushes.Black,
                Bounds.Left + (Bounds.Width - nameSize.Width) / 2, y);
            y += (int)nameSize.Height + 4;

            g.DrawLine(Pens.Black, Bounds.Left, y, Bounds.Right, y);

            Font methodFont = SystemFonts.DefaultFont;
            int methodPadding = 8;
            foreach (var method in Methods)
            {
                string methodText = method.ToString();
                g.DrawString(methodText, methodFont, Brushes.Black, Bounds.Left + methodPadding, y);
                y += (int)g.MeasureString(methodText, methodFont).Height;
            }
        }
    }
}
