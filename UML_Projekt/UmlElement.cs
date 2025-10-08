using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Projekt
{
    public abstract class UmlElement
    {
        public Point Position { get; set; }
        public Size Size { get; set; }
        public string Name { get; set; }

        public UmlElement() { }

        public PointF Center => new PointF(
            Position.X + Size.Width / 2f,
            Position.Y + Size.Height / 2f
        );

        public Rectangle Bounds { get; set; }

        public virtual bool Contains(PointF p)
        {
            return Bounds.Contains(Point.Round(p));
        }

        public abstract void Draw(Graphics g);
    }
}
