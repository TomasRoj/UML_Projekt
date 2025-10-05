using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Projekt
{
    public class UmlEnum : UmlElement
    {
        public List<string> Values { get; set; }
        public UmlEnum(string name, List<string> values)
        {
            Name = name;
            Values = values;
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.LightYellow, Bounds);
            int y = Bounds.Top;
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            string headerText = "<<enum>>";
            SizeF headerSize = g.MeasureString(headerText, headerFont);
            SizeF nameSize = g.MeasureString(Name, headerFont);
            g.DrawString(headerText, headerFont, Brushes.Black,
                Bounds.Left + (Bounds.Width - headerSize.Width) / 2, y);
            y += (int)headerSize.Height;
            g.DrawString(Name, headerFont, Brushes.Black,
                Bounds.Left + (Bounds.Width - nameSize.Width) / 2, y);
            y += (int)nameSize.Height + 4;
            g.DrawLine(Pens.Black, Bounds.Left, y, Bounds.Right, y);
            Font valueFont = SystemFonts.DefaultFont;
            int valuePadding = 8;
            foreach (var value in Values)
            {
                string valueText = value;
                g.DrawString(valueText, valueFont, Brushes.Black, Bounds.Left + valuePadding, y);
                y += (int)g.MeasureString(valueText, valueFont).Height;
            }
        }
    }
}
