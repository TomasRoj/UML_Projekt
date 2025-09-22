using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML_Projekt
{
    public class UmlClass
    {
        public string Name { get; set; }
        public List<UmlAtribute> Atributes { get; set; }
        public List<UmlMethod> Methods { get; set; }

        public bool IsAbstract { get; set; }
        public bool IsStatic { get; set; }

        public Rectangle Bounds { get; set; }

        public Point Position { get; set; }
        public Size Size { get; set; } = new Size(120, 60);

        public UmlClass(string name, List<UmlAtribute> atributes, List<UmlMethod> methods, bool isAbstract, bool isStatic)
        {
            Name = name;
            Atributes = atributes;
            Methods = methods;
            IsAbstract = isAbstract;
            IsStatic = isStatic;
        }
        public void AddAtribute(UmlAtribute atribute)
        {
            Atributes.Add(atribute);
        }
        public void AddMethod(UmlMethod method)
        {
            Methods.Add(method);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class: {Name}");
            sb.AppendLine("Attributes:");
            foreach (var attr in Atributes)
            {
                sb.AppendLine($"  - {attr}");
            }
            sb.AppendLine("Methods:");
            foreach (var method in Methods)
            {
                sb.AppendLine($"  - {method}");
            }
            return sb.ToString();
        }

        public void Draw(Graphics g)
        {
            // Rámeček
           // g.DrawRectangle(Pens.Black, Bounds);
            g.FillRectangle(Brushes.Beige, Bounds);

            // rozdělení na 3 části: název, atributy, metody
            int y = Bounds.Top;

            // Hlavička (název)
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            SizeF nameSize = g.MeasureString(Name, headerFont);
            g.DrawString(Name, headerFont, Brushes.Black,
                Bounds.Left + (Bounds.Width - nameSize.Width) / 2, y);
            y += (int)nameSize.Height + 4;
            g.DrawLine(Pens.Black, Bounds.Left, y, Bounds.Right, y);

            // Atributy
            foreach (var attr in Atributes)
            {
                g.DrawString(attr.ToString(), SystemFonts.DefaultFont, Brushes.Black, Bounds.Left + 2, y);
                y += 16;
            }
            g.DrawLine(Pens.Black, Bounds.Left, y, Bounds.Right, y);

            // Metody
            foreach (var method in Methods)
            {
                g.DrawString(method.ToString(), SystemFonts.DefaultFont, Brushes.Black, Bounds.Left + 2, y);
                y += 16;
            }
        }
    }
}
