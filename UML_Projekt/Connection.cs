using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Projekt
{
    public class Connection
    {
        public UmlElement From { get; set; }
        public UmlElement To { get; set; }
        public RelationType Type { get; set; }

        public string MultiplicityFrom { get; set; }
        public string MultiplicityTo { get; set; }

        public void Reverse()
        {
            var tempElement = From;
            From = To;
            To = tempElement;

            var tempMultiplicity = MultiplicityFrom;
            MultiplicityFrom = MultiplicityTo;
            MultiplicityTo = tempMultiplicity;
        }

        public void Draw(Graphics g)
        {
            PointF start = GetClosestSideCenter(From, To);
            PointF end = GetClosestSideCenter(To, From);

            PointF mid = new PointF(start.X, end.Y);

            if (Math.Abs(start.X - end.X) < 5 || Math.Abs(start.Y - end.Y) < 5)
            {
                mid = end;
            }

            Pen pen = Type == RelationType.Dependency || Type == RelationType.Realization
                ? new Pen(Color.Black) { DashStyle = DashStyle.Dash }
                : Pens.Black;

            PointF adjustedStart = start;
            PointF adjustedEnd = end;
            PointF adjustedMid = mid;

            if (Type == RelationType.Aggregation || Type == RelationType.Composition)
            {
                adjustedStart = GetOffsetPoint(start, mid, 20f);
                if (mid != end)
                {
                    adjustedMid = new PointF(adjustedStart.X, end.Y);
                }
                else
                {
                    adjustedMid = adjustedStart;
                }
            }

            if (Type == RelationType.Association || Type == RelationType.Generalization ||
                Type == RelationType.Realization || Type == RelationType.Dependency)
            {
                if (mid != end)
                {
                    adjustedEnd = GetOffsetPoint(end, adjustedMid, 15f);
                }
                else
                {
                    adjustedEnd = GetOffsetPoint(end, adjustedStart, 15f);
                }
            }

            g.DrawLine(pen, adjustedStart, adjustedMid);
            if (adjustedMid != adjustedEnd)
                g.DrawLine(pen, adjustedMid, adjustedEnd);

            DrawMultiplicity(g, start, MultiplicityFrom, start, mid);
            DrawMultiplicity(g, end, MultiplicityTo, end, mid);

            switch (Type)
            {
                case RelationType.Association:
                    DrawArrowHead(g, end, adjustedMid, false);
                    break;
                case RelationType.Aggregation:
                    DrawDiamond(g, start, mid, false);
                    break;
                case RelationType.Composition:
                    DrawDiamond(g, start, mid, true);
                    break;
                case RelationType.Generalization:
                    DrawTriangle(g, end, adjustedMid, false);
                    break;
                case RelationType.Realization:
                    DrawTriangle(g, end, adjustedMid, true);
                    break;
                case RelationType.Dependency:
                    DrawArrowHead(g, end, adjustedMid, true);
                    break;
            }
        }

        private PointF GetOffsetPoint(PointF from, PointF to, float offset)
        {
            float dx = to.X - from.X;
            float dy = to.Y - from.Y;
            float length = (float)Math.Sqrt(dx * dx + dy * dy);

            if (length < 0.001f) return from;

            float ratio = offset / length;
            return new PointF(
                from.X + dx * ratio,
                from.Y + dy * ratio
            );
        }

        private void DrawMultiplicity(Graphics g, PointF position, string multiplicity, PointF lineStart, PointF lineEnd)
        {
            if (!string.IsNullOrEmpty(multiplicity))
            {
                using (Font font = new Font("Arial", 9))
                {
                    // Zjisti směr čáry pro lepší umístění textu
                    float dx = lineEnd.X - lineStart.X;
                    float dy = lineEnd.Y - lineStart.Y;

                    float offsetX = 10;
                    float offsetY = -15;

                    // Pokud je čára horizontální, posuň text dolů
                    if (Math.Abs(dy) < Math.Abs(dx))
                    {
                        offsetY = 5;
                    }

                    g.DrawString(multiplicity, font, Brushes.Black, position.X + offsetX, position.Y + offsetY);
                }
            }
        }

        // výpočet středu nejbližší strany
        public PointF GetClosestSideCenter(UmlElement from, UmlElement to)
        {
            RectangleF rect = new RectangleF(from.Position, from.Size);
            PointF toCenter = new PointF(to.Position.X + to.Size.Width / 2f, to.Position.Y + to.Size.Height / 2f);

            float left = rect.Left;
            float right = rect.Right;
            float top = rect.Top;
            float bottom = rect.Bottom;
            float centerX = rect.Left + rect.Width / 2f;
            float centerY = rect.Top + rect.Height / 2f;

            // Vzdálenosti ke středu stran
            var sides = new[]
            {
                new { Point = new PointF(centerX, top),     Dist = Distance(toCenter, new PointF(centerX, top)) },    // Horní
                new { Point = new PointF(centerX, bottom),  Dist = Distance(toCenter, new PointF(centerX, bottom)) }, // Dolní
                new { Point = new PointF(left, centerY),    Dist = Distance(toCenter, new PointF(left, centerY)) },   // Levá
                new { Point = new PointF(right, centerY),   Dist = Distance(toCenter, new PointF(right, centerY)) }   // Pravá
            };

            return sides.OrderBy(s => s.Dist).First().Point;
        }

        private float Distance(PointF a, PointF b)
        {
            float dx = a.X - b.X;
            float dy = a.Y - b.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private void DrawArrowHead(Graphics g, PointF tip, PointF tail, bool open)
        {
            const float size = 12f;
            float angle = (float)Math.Atan2(tip.Y - tail.Y, tip.X - tail.X);

            PointF p1 = new PointF(
                tip.X - size * (float)Math.Cos(angle - Math.PI / 6),
                tip.Y - size * (float)Math.Sin(angle - Math.PI / 6));
            PointF p2 = new PointF(
                tip.X - size * (float)Math.Cos(angle + Math.PI / 6),
                tip.Y - size * (float)Math.Sin(angle + Math.PI / 6));

            if (open)
            {
                g.DrawLine(Pens.Black, tip, p1);
                g.DrawLine(Pens.Black, tip, p2);
            }
            else
            {
                g.FillPolygon(Brushes.Black, new[] { tip, p1, p2 });
            }
        }

        private void DrawDiamond(Graphics g, PointF start, PointF end, bool filled)
        {
            const float size = 16f;
            float angle = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);

            PointF tip = start;
            PointF back = new PointF(
                start.X + size * (float)Math.Cos(angle),
                start.Y + size * (float)Math.Sin(angle));

            PointF mid = new PointF(
                start.X + size * 0.5f * (float)Math.Cos(angle),
                start.Y + size * 0.5f * (float)Math.Sin(angle));

            PointF left = new PointF(
                mid.X + size * 0.5f * (float)Math.Cos(angle + Math.PI / 2),
                mid.Y + size * 0.5f * (float)Math.Sin(angle + Math.PI / 2));

            PointF right = new PointF(
                mid.X + size * 0.5f * (float)Math.Cos(angle - Math.PI / 2),
                mid.Y + size * 0.5f * (float)Math.Sin(angle - Math.PI / 2));

            PointF[] points = new[] { tip, left, back, right };

            if (filled)
            {
                g.FillPolygon(Brushes.Black, points);
            }
            else
            {
                g.DrawPolygon(Pens.Black, points);
                g.FillPolygon(Brushes.White, points);
            }
        }

        private void DrawTriangle(Graphics g, PointF tip, PointF tail, bool open)
        {
            const float size = 14f;
            float angle = (float)Math.Atan2(tip.Y - tail.Y, tip.X - tail.X);

            PointF p1 = new PointF(
                tip.X - size * (float)Math.Cos(angle - Math.PI / 6),
                tip.Y - size * (float)Math.Sin(angle - Math.PI / 6));
            PointF p2 = new PointF(
                tip.X - size * (float)Math.Cos(angle + Math.PI / 6),
                tip.Y - size * (float)Math.Sin(angle + Math.PI / 6));

            if (open)
            {
                g.DrawPolygon(Pens.Black, new[] { tip, p1, p2 });
                g.FillPolygon(Brushes.White, new[] { tip, p1, p2 });
            }
            else
            {
                g.FillPolygon(Brushes.Black, new[] { tip, p1, p2 });
            }
        }
    }
}