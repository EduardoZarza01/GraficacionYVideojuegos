using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centroide
{
    internal class Figure
    {
        public PointF centroid;
        public List<PointF> points, pointsR;
        public float xMove, yMove;
        public float width, height, Sx, Sy;
        public float scale;
        public double angle, angleC; // in radians
        private double totalRotation;
        public Figure(List<PointF> pts, int width, int height)
        {
            points = pts;
            pointsR = pts;
            centroid = CalculateCentroid(pts);

            xMove = 0; yMove = 0; scale = 1; angle = 0; angleC = 0;
            this.width = width; this.height = height;
            Sx = width / 2; Sy = height / 2;
            xMove = 0; yMove = 0; scale = 1; angle = 0; angleC = 0;
            totalRotation = 0; // Initialize totalRotation
            this.width = width; this.height = height;
            Sx = width / 2; Sy = height / 2;
        }

        private PointF CalculateCentroid(List<PointF> pts)
        {
            PointF center = new PointF();
            foreach (var point in pts)
            {
                center.X += point.X;
                center.Y += point.Y;
            }
            center.X /= pts.Count;
            center.Y /= pts.Count;
            return center;
        }

        public void DrawFigure(Graphics g, int caso)
        {
            for (int i = 0; i < (points.Count - 1); i++)
            {
                g.DrawLine(caso == 1 ? Pens.Yellow : Pens.Red, pointsR[i], pointsR[i + 1]);
            }
            g.DrawLine(caso == 1 ? Pens.Yellow : Pens.Red, pointsR[points.Count - 1], pointsR[0]);
        }

        public void CenterFigure()
        {
            float xDistance = Sx - centroid.X;
            float yDistance = Sy - centroid.Y;
            MoveFigure(xDistance, yDistance);
        }

        public void MoveFigure(float x, float y)
        {
            centroid.X += x;
            centroid.Y += y;
            xMove += x;
            yMove += y;

            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new PointF(points[i].X + x, points[i].Y + y);
                pointsR[i] = points[i];
            }
        }

        public void ScaleFigure(float c)
        {
            scale *= c;

            PointF centroidOriginal = centroid;

            MoveFigure(-centroid.X, -centroid.Y);

            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new PointF(points[i].X * c, points[i].Y * c);
                pointsR[i] = points[i];
            }

            MoveFigure(centroidOriginal.X, centroidOriginal.Y);
        }

        public void RotateRight(float angleN)
        {
            angle = angleN * Math.PI / 180; // Transform the angle to radians
            totalRotation += angleN;
            float xOg = xMove;
            float yOg = yMove;
            PointF OgCentroid = centroid;
            MoveFigure(-xMove, -yMove);
            for (int i = 0; i < points.Count; i++)
            {
                pointsR[i] = RotatePoint(new PointF(points[i].X - centroid.X, points[i].Y - centroid.Y));
            }
            MoveFigure(xOg, yOg);
        }

        public void RotateLeft(float angleN)
        {
            angleC += angleN * Math.PI / 180; //Transforma el angulo a radianes
            float x, y;
            for (int i = 0; i < points.Count; i++)
            {
                x = points[i].X - Sx; y = points[i].Y - Sy;
                pointsR[i] = RotatePointOG(new PointF(x, y));
            }

            PointF pivot = new PointF(centroid.X - Sx, centroid.Y - Sy);
            centroid = RotatePointOG(pivot);
        }
        public double GetTotalRotation()
        {

            while (totalRotation < 0)
            {
                totalRotation += 360;
            }

            while (totalRotation >= 360)
            {
                totalRotation -= 360;
            }

            return totalRotation;

        }
        private PointF RotatePointOG(PointF a)
        {
            PointF rotated_Point = new PointF();

            rotated_Point.X = Sx + (float)((a.X * Math.Cos(angleC)) - (a.Y * Math.Sin(angleC)));
            rotated_Point.Y = Sy - (float)((a.X * Math.Sin(angleC)) + (a.Y * Math.Cos(angleC)));

            return rotated_Point;
        }

        private PointF RotatePoint(PointF a)
        {
            PointF rotated_Point = new PointF();

            rotated_Point.X = centroid.X + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            rotated_Point.Y = centroid.Y + (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return rotated_Point;
        }
    }
}
