using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TG.MathEx
{
    /// <summary>
    /// Provides various functions for working with points.
    /// </summary>
    public static class Geometry
    {

        /// <summary>
        /// Determines whether two lines would intersect if they continued.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines will, at some point, intersect; otherwise false.</returns>
        public static Point GetIntersection(Point line1P1, Point line1P2, Point line2P1, Point line2P2)
        {
            int A1 = line1P2.Y - line1P1.Y;
            int B1 = line1P1.X - line1P2.X;
            int A2 = line2P2.Y - line2P1.Y;
            int B2 = line2P1.X - line2P2.X;

            int C1 = (A1 * line1P1.X) + (B1 * line1P1.Y);
            int C2 = (A2 * line2P1.X) + (B2 * line2P1.Y);
            int Delta = A1 * B2 - A2 * B1;

            if (Delta == 0)
            {
            }
            else
            {
                int X = (B2 * C1 - B1 * C2) / Delta;
                int Y = (A1 * C2 - A2 * C1) / Delta;
                return new Point(X, Y);
            }
            return Point.Empty;
        }

        /// <summary>
        /// Determines whether two lines would intersect if they continued.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines will, at some point, intersect; otherwise false.</returns>
        public static PointF GetIntersection(PointF line1P1, PointF line1P2, PointF line2P1, PointF line2P2)
        {
            float A1 = line1P2.Y - line1P1.Y;
            float B1 = line1P1.X - line1P2.X;
            float A2 = line2P2.Y - line2P1.Y;
            float B2 = line2P1.X - line2P2.X;

            float C1 = (A1 * line1P1.X) + (B1 * line1P1.Y);
            float C2 = (A2 * line2P1.X) + (B2 * line2P1.Y);
            float Delta = A1 * B2 - A2 * B1;

            if (Delta == 0)
            {
            }
            else
            {
                float X = (B2 * C1 - B1 * C2) / Delta;
                float Y = (A1 * C2 - A2 * C1) / Delta;
                return new PointF(X, Y);
            }
            return PointF.Empty;
        }

        /// <summary>
        /// Determines whether two lines would intersect if they continued.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines will, at some point, intersect; otherwise false.</returns>
		public static PointD GetIntersection(PointD L1P1, PointD L1P2, PointD L2P1, PointD L2P2)
        {
            double A1 = L1P2.Y - L1P1.Y;
            double B1 = L1P1.X - L1P2.X;
            double A2 = L2P2.Y - L2P1.Y;
            double B2 = L2P1.X - L2P2.X;

            double C1 = (A1 * L1P1.X) + (B1 * L1P1.Y);
            double C2 = (A2 * L2P1.X) + (B2 * L2P1.Y);
            double Delta = A1 * B2 - A2 * B1;

            if (Delta == 0)
            {
            }
            else
            {
                double X = (B2 * C1 - B1 * C2) / Delta;
                double Y = (A1 * C2 - A2 * C1) / Delta;
                return new PointD(X, Y);
            }
            return PointD.Empty;
        }

        /// <summary>
        /// Determines whether two lines would intersect if they continued.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines will, at some point, intersect; otherwise false.</returns>
		public static bool WillIntersect(Point line1P1, Point line1P2, Point line2P1, Point line2P2)
        {
            int A1 = line1P2.Y - line1P1.Y;
            int B1 = line1P1.X - line1P2.X;
            int A2 = line2P2.Y - line2P1.Y;
            int B2 = line2P1.X - line2P2.X;
            int Delta = A1 * B2 - A2 * B1;
            return Delta == 0 ? false : true;
        }

        /// <summary>
        /// Determines whether two lines would intersect if they continued.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines will, at some point, intersect; otherwise false.</returns>
		public static bool WillIntersect(PointF line1P1, PointF line1P2, PointF line2P1, PointF line2P2)
        {
            float A1 = line1P2.Y - line1P1.Y;
            float B1 = line1P1.X - line1P2.X;
            float A2 = line2P2.Y - line2P1.Y;
            float B2 = line2P1.X - line2P2.X;
            float Delta = A1 * B2 - A2 * B1;
            return Delta == 0 ? false : true;
        }

        /// <summary>
        /// Determines whether two lines would intersect if they continued.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines will, at some point, intersect; otherwise false.</returns>
		public static bool WillIntersect(PointD line1P1, PointD line1P2, PointD line2P1, PointD line2P2)
        {
            double A1 = line1P2.Y - line1P1.Y;
            double B1 = line1P1.X - line1P2.X;
            double A2 = line2P2.Y - line2P1.Y;
            double B2 = line2P1.X - line2P2.X;
            double Delta = A1 * B2 - A2 * B1;
            return Delta == 0 ? false : true;
        }

        /// <summary>
        /// Determines if two lines intersect.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines do intersect; otherwise false.</returns>
        public static bool DoesIntersect(Point line1P1, Point line1P2, Point line2P1, Point line2P2)
        {
            int A1 = line1P2.Y - line1P1.Y;
            int B1 = line1P1.X - line1P2.X;
            int A2 = line2P2.Y - line2P1.Y;
            int B2 = line2P1.X - line2P2.X;

            int C1 = (A1 * line1P1.X) + (B1 * line1P1.Y);
            int C2 = (A2 * line2P1.X) + (B2 * line2P1.Y);
            int Delta = A1 * B2 - A2 * B1;


            if (Delta == 0)
            {
                return false;
            }
            else
            {
                int X = (B2 * C1 - B1 * C2) / Delta;
                int Y = (A1 * C2 - A2 * C1) / Delta;
                Point result = new Point(X, Y);
                double OriginalAngle = GetAngle(line1P1, line1P2);
                double NewAngle = GetAngle(line1P1, result);
                OriginalAngle = OriginalAngle == 360 ? 0 : OriginalAngle;
                NewAngle = NewAngle == 360 ? 0 : NewAngle;
                if (Math.Abs(NewAngle - OriginalAngle) <= .0001)
                {
                    double line1 = Distance(line1P1, line1P2);
                    double sample1 = Distance(line1P1, result);


                    double line2 = Distance(line2P1, line2P2);
                    double sample2 = Distance(line2P1, result);
                    double sample3 = Distance(line2P2, result);

                    return sample1 <= line1 && sample2 <= line2 && sample3 <= line2;
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// Determines if two lines intersect.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines do intersect; otherwise false.</returns>
        public static bool DoesIntersect(PointF line1P1, PointF line1P2, PointF line2P1, PointF line2P2)
        {
            float A1 = line1P2.Y - line1P1.Y;
            float B1 = line1P1.X - line1P2.X;
            float A2 = line2P2.Y - line2P1.Y;
            float B2 = line2P1.X - line2P2.X;

            float C1 = (A1 * line1P1.X) + (B1 * line1P1.Y);
            float C2 = (A2 * line2P1.X) + (B2 * line2P1.Y);
            float Delta = A1 * B2 - A2 * B1;


            if (Delta == 0)
            {
                return false;
            }
            else
            {
                float X = (B2 * C1 - B1 * C2) / Delta;
                float Y = (A1 * C2 - A2 * C1) / Delta;
                PointF result = new PointF(X, Y);
                double OriginalAngle = GetAngle(line1P1, line1P2);
                double NewAngle = GetAngle(line1P1, result);
                OriginalAngle = OriginalAngle == 360 ? 0 : OriginalAngle;
                NewAngle = NewAngle == 360 ? 0 : NewAngle;
                if (Math.Abs(NewAngle - OriginalAngle) <= .0001)
                {
                    double line1 = Distance(line1P1, line1P2);
                    double sample1 = Distance(line1P1, result);


                    double line2 = Distance(line2P1, line2P2);
                    double sample2 = Distance(line2P1, result);
                    double sample3 = Distance(line2P2, result);

                    return sample1 <= line1 && sample2 <= line2 && sample3 <= line2;
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// Determines if two lines intersect.
        /// </summary>
        /// <param name="line1P1">The first point of the first line.</param>
        /// <param name="line1P2">The second point of the first line.</param>
        /// <param name="line2P1">The first point of the second line.</param>
        /// <param name="line2P2">The second point of the first line.</param>
        /// <returns>Returns true if the lines do intersect; otherwise false.</returns>
        public static bool DoesIntersect(PointD line1P1, PointD line1P2, PointD line2P1, PointD line2P2)
        {
            double A1 = line1P2.Y - line1P1.Y;
            double B1 = line1P1.X - line1P2.X;
            double A2 = line2P2.Y - line2P1.Y;
            double B2 = line2P1.X - line2P2.X;

            double C1 = (A1 * line1P1.X) + (B1 * line1P1.Y);
            double C2 = (A2 * line2P1.X) + (B2 * line2P1.Y);
            double Delta = A1 * B2 - A2 * B1;


            if (Delta == 0)
            {
                return false;
            }
            else
            {
                double X = (B2 * C1 - B1 * C2) / Delta;
                double Y = (A1 * C2 - A2 * C1) / Delta;
                PointD result = new PointD(X, Y);
                double OriginalAngle = GetAngle(line1P1, line1P2);
                double NewAngle = GetAngle(line1P1, result);
                OriginalAngle = OriginalAngle == 360 ? 0 : OriginalAngle;
                NewAngle = NewAngle == 360 ? 0 : NewAngle;
                if (Math.Abs(NewAngle - OriginalAngle) <= .0001)
                {
                    double line1 = Distance(line1P1, line1P2);
                    double sample1 = Distance(line1P1, result);


                    double line2 = Distance(line2P1, line2P2);
                    double sample2 = Distance(line2P1, result);
                    double sample3 = Distance(line2P2, result);

                    return sample1 <= line1 && sample2 <= line2 && sample3 <= line2;
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns the distance between two points.
        /// </summary>
        /// <param name="point1">The first point of the line.</param>
        /// <param name="point2">The second point of the line.</param>
        /// <returns>The distance between two points.</returns>
        public static double Distance(Point point1, Point point2)
        {
            double n = (Math.Pow((point2.X - point1.X), 2)) + (Math.Pow((point2.Y - point1.Y), 2));
            return Math.Sqrt(n);
        }

        /// <summary>
        /// Returns the distance between two points.
        /// </summary>
        /// <param name="point1">The first point of the line.</param>
        /// <param name="point2">The second point of the line.</param>
        /// <returns>The distance between two points.</returns>
        public static double Distance(PointF point1, PointF point2)
        {
            double n = (Math.Pow((point2.X - point1.X), 2)) + (Math.Pow((point2.Y - point1.Y), 2));
            return Math.Sqrt(n);
        }

        /// <summary>
        /// Returns the distance between two points.
        /// </summary>
        /// <param name="point1">The first point of the line.</param>
        /// <param name="point2">The second point of the line.</param>
        /// <returns>The distance between two points.</returns>
        public static double Distance(PointD point1, PointD point2)
        {
            double n = (Math.Pow((point2.X - point1.X), 2)) + (Math.Pow((point2.Y - point1.Y), 2));
            return Math.Sqrt(n);
        }

        /// <summary>
		/// Returns the angle of two point in degrees.
		/// </summary>
		/// <param name="pointStart">The starting point of the line.</param>
		/// <param name="pointEnd">The end point of the line.</param>
		/// <returns></returns>
		public static double GetAngle(Point pointStart, Point pointEnd)
        {
            double radians = Math.Atan2(pointEnd.Y - pointStart.Y, pointEnd.X - pointStart.X);
            return ValidateDegreeAngle(GetDegrees(radians));
        }

        /// <summary>
		/// Returns the angle of two point in degrees.
		/// </summary>
		/// <param name="pointStart">The starting point of the line.</param>
		/// <param name="pointEnd">The end point of the line.</param>
		/// <returns></returns>
		public static double GetAngle(PointF pointStart, PointF pointEnd)
        {
            double radians = Math.Atan2(pointEnd.Y - pointStart.Y, pointEnd.X - pointStart.X);
            return ValidateDegreeAngle(GetDegrees(radians));
        }

        /// <summary>
        /// Returns the angle of two points in degrees.
        /// </summary>
        /// <param name="pointStart">The starting point of the line.</param>
        /// <param name="pointEnd">The end point of the line.</param>
        /// <returns></returns>
        public static double GetAngle(PointD pointStart, PointD pointEnd)
        {
            double radians = Math.Atan2(pointEnd.Y - pointStart.Y, pointEnd.X - pointStart.X);
            return ValidateDegreeAngle(GetDegrees(radians));
        }

        /// <summary>
        /// Returns the angle of two points in radians.
        /// </summary>
        /// <param name="pointStart">The starting point of the line.</param>
        /// <param name="pointEnd">The end point of the line.</param>
        /// <returns></returns>
		public static double GetRadians(Point pointStart, Point pointEnd)
        {
            return Math.Atan2(pointEnd.Y - pointStart.Y, pointEnd.X - pointStart.X);
        }

        /// <summary>
        /// Returns the angle of two points in radians.
        /// </summary>
        /// <param name="pointStart">The starting point of the line.</param>
        /// <param name="pointEnd">The end point of the line.</param>
        /// <returns></returns>
		public static double GetRadians(PointF pointStart, PointF pointEnd)
        {
            return Math.Atan2(pointEnd.Y - pointStart.Y, pointEnd.X - pointStart.X);
        }

        /// <summary>
        /// Returns the angle of two points in radians.
        /// </summary>
        /// <param name="pointStart">The starting point of the line.</param>
        /// <param name="pointEnd">The end point of the line.</param>
        /// <returns></returns>
        public static double GetRadians(PointD pointStart, PointD pointEnd)
        {
            return Math.Atan2(pointEnd.Y - pointStart.Y, pointEnd.X - pointStart.X);
        }

        /// <summary>
        /// Converts an angle in degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns>The angle in radians.</returns>
		public static double GetRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }

        /// <summary>
        /// Converts radians to degrees.
        /// </summary>
        /// <param name="radians">Value in radians.</param>
        /// <returns>Value in degrees.</returns>
        public static double GetDegrees(double radians)
        {
            return radians * (180 / Math.PI);
        }

        /// <summary>
        /// Ensures that the provided angle is within range and corrects it if it is not.
        /// </summary>
        /// <remarks>
        /// If the value is greater or less than a valid angle, the value is "rotated" PI*2 radians (full circle in radians) until it is within range.
        /// </remarks>
        /// <example>
        /// ValidateRadianAngle(-0.17453292519943295);
        /// //Output = 6.1086523819801535
        /// </example>
        /// <param name="angle">The angle, in radian, to validate.</param>
        /// <returns>The correct radian value.</returns>
		public static double ValidateRadianAngle(double angle)
        {
            double pi2 = Math.PI * 2;
            do
            {
                if (angle < 0)
                    angle += pi2;
                else if (angle > pi2)
                    angle -= pi2;
                else
                    break;
            } while (true);

            return angle;
        }

        /// <summary>
        /// Ensures that the provided angle is within range and corrects it if it is not.
        /// </summary>
        /// <remarks>
        /// If the value is greater or less than a valid angle, the value is "rotated" 360 degrees until it is within range.
        /// </remarks>
        /// <example>
        /// ValidateDegreeAngle(-10)
        /// //Output = 350
        /// ValidateDegreeAngle(360*2)
        /// //Output = 360
        /// </example>
        /// <param name="angle">The angle, in degrees, to validate.</param>
        /// <returns></returns>
        public static double ValidateDegreeAngle(double angle)
        {
            double fullcircle = 360;
            do
            {
                if (angle < 0)
                    angle += fullcircle;
                else if (angle > fullcircle)
                    angle -= fullcircle;
                else
                    break;
            } while (true);

            return angle;
        }

        /// <summary>
        /// Calculate a point based on the length and direction from a given location.
        /// </summary>
        /// <param name="angle">The angle to travel, in degrees.</param>
        /// <param name="startPoint">The location of origin.</param>
        /// <param name="distance">Distance from startPoint.</param>
        /// <returns>The new calculated location.</returns>
        public static Point PlotPoint(double angle, Point startPoint, double distance)
        {
            double radians = GetRadians(angle);
            double x = startPoint.X + (distance * Math.Cos(radians));
            double y = startPoint.Y + (distance * Math.Sin(radians));
            return new Point((int)x, (int)y);
        }

        /// <summary>
        /// Calculate a point based on the length and direction from a given location.
        /// </summary>
        /// <param name="angle">The angle to travel, in degrees.</param>
        /// <param name="startPoint">The location of origin.</param>
        /// <param name="distance">Distance from startPoint.</param>
        /// <returns>The new calculated location.</returns>
        public static PointF PlotPoint(double angle, PointF startPoint, double distance)
        {
            double radians = GetRadians(angle);
            double x = startPoint.X + (distance * Math.Cos(radians));
            double y = startPoint.Y + (distance * Math.Sin(radians));
            return new PointF((float)x, (float)y);
        }

        /// <summary>
        /// Calculate a point based on the length and direction from a given location.
        /// </summary>
        /// <param name="angle">The angle to travel, in degrees.</param>
        /// <param name="startPoint">The location of origin.</param>
        /// <param name="distance">Distance from startPoint.</param>
        /// <returns>The new calculated location.</returns>
        public static PointD PlotPoint(double angle, PointD startPoint, double distance)
        {
            double radians = GetRadians(angle);
            double x = startPoint.X + (distance * Math.Cos(radians));
            double y = startPoint.Y + (distance * Math.Sin(radians));
            return new PointD(x, y);
        }

        /// <summary>
        /// Calculate a point based on the length and direction from a given location.
        /// </summary>
        /// <param name="radians">The angle to travel, in radians.</param>
        /// <param name="startPoint">The location of origin.</param>
        /// <param name="distance">Distance from startPoint.</param>
        /// <returns>The new calculated location.</returns>
        public static Point PlotPointFromRadians(double radians, Point startPoint, double distance)
        {
            double x = startPoint.X + (distance * Math.Cos(radians));
            double y = startPoint.Y + (distance * Math.Sin(radians));
            return new Point((int)x, (int)y);
        }

        /// <summary>
        /// Calculate a point based on the length and direction from a given location.
        /// </summary>
        /// <param name="radians">The angle to travel, in radians.</param>
        /// <param name="startPoint">The location of origin.</param>
        /// <param name="distance">Distance from startPoint.</param>
        /// <returns>The new calculated location.</returns>
        public static PointF PlotPointFromRadians(double radians, PointF startPoint, double distance)
        {
            double x = startPoint.X + (distance * Math.Cos(radians));
            double y = startPoint.Y + (distance * Math.Sin(radians));
            return new PointF((float)x, (float)y);
        }

        /// <summary>
        /// Calculate a point based on the length and direction from a given location.
        /// </summary>
        /// <param name="radians">The angle to travel, in radians.</param>
        /// <param name="startPoint">The location of origin.</param>
        /// <param name="distance">Distance from startPoint.</param>
        /// <returns>The new calculated location.</returns>
        public static PointD PlotPointFromRadians(double radians, PointD startPoint, double distance)
        {
            double x = startPoint.X + (distance * Math.Cos(radians));
            double y = startPoint.Y + (distance * Math.Sin(radians));
            return new PointD(x, y);
        }

        /// <summary>
        /// Like Ortho Mode in cad software, it locks a line segment into 90 degree directions.
        /// </summary>
        /// <param name="startPoint">The start point of a line.</param>
        /// <param name="endPoint">The end point of a line.</param>
        /// <returns>A new end point.</returns>
        public static Point OrthoPoint(Point startPoint, Point endPoint)
        {
            double angle = GetAngle(startPoint, endPoint);

            if (angle <= 45 || angle >= 315)
                return new Point(endPoint.X, startPoint.Y);
            else if (angle > 45 && angle < 135)
                return new Point(startPoint.X, endPoint.Y);
            else if (angle >= 135 && angle <= 225)
                return new Point(endPoint.X, startPoint.Y);
            else
                return new Point(startPoint.X, endPoint.Y);
        }

        /// <summary>
        /// Like Ortho Mode in cad software, it locks a line segment into 90 degree directions.
        /// </summary>
        /// <param name="startPoint">The start point of a line.</param>
        /// <param name="endPoint">The end point of a line.</param>
        /// <returns>A new end point.</returns>
        public static PointF OrthoPoint(PointF startPoint, PointF endPoint)
        {
            double angle = GetAngle(startPoint, endPoint);

            if (angle <= 45 || angle >= 315)
                return new PointF(endPoint.X, startPoint.Y);
            else if (angle > 45 && angle < 135)
                return new PointF(startPoint.X, endPoint.Y);
            else if (angle >= 135 && angle <= 225)
                return new PointF(endPoint.X, startPoint.Y);
            else
                return new PointF(startPoint.X, endPoint.Y);
        }

        /// <summary>
        /// Like Ortho Mode in cad software, it locks a line segment into 90 degree directions.
        /// </summary>
        /// <param name="startPoint">The start point of a line.</param>
        /// <param name="endPoint">The end point of a line.</param>
        /// <returns>A new end point.</returns>
        public static PointD OrthoPoint(PointD startPoint, PointD endPoint)
        {
            double angle = GetAngle(startPoint, endPoint);
            
            if (angle <= 45 || angle >= 315)
                return new PointD(endPoint.X, startPoint.Y);
            else if (angle > 45 && angle < 135)
                return new PointD(startPoint.X, endPoint.Y);
            else if (angle >= 135 && angle <= 225)
                return new PointD(endPoint.X, startPoint.Y);
            else
                return new PointD(startPoint.X, endPoint.Y);
        }

        /// <summary>
        /// Rotates a point around a center point.
        /// </summary>
        /// <param name="original">The original location.</param>
        /// <param name="center">The center point to rotate around.</param>
        /// <param name="rotation">The amount of rotation to perform.</param>
        /// <returns>The new point location after rotation.</returns>
        public static Point RotatePointRadians(Point original, Point center, double rotation)
        {
            double currentAngle = GetRadians(center, original);
            double distance = Distance(center, original);

            currentAngle += rotation;
            currentAngle = ValidateRadianAngle(currentAngle);
            return PlotPoint(currentAngle, center, distance);
        }

        /// <summary>
        /// Rotates a point around a center point.
        /// </summary>
        /// <param name="original">The original location.</param>
        /// <param name="center">The center point to rotate around.</param>
        /// <param name="rotation">The amount of rotation to perform.</param>
        /// <returns>The new point location after rotation.</returns>
        public static PointF RotatePointRadians(PointF original, PointF center, double rotation)
        {
            double currentAngle = GetRadians(center, original);
            double distance = Distance(center, original);

            currentAngle += rotation;
            currentAngle = ValidateRadianAngle(currentAngle);
            return PlotPoint(currentAngle, center, distance);
        }

        /// <summary>
        /// Rotates a point around a center point.
        /// </summary>
        /// <param name="original">The original location.</param>
        /// <param name="center">The center point to rotate around.</param>
        /// <param name="rotation">The amount of rotation to perform.</param>
        /// <returns>The new point location after rotation.</returns>
        public static PointD RotatePointRadians(PointD original, PointD center, double rotation)
        {
            double currentAngle = GetRadians(center, original);
            double distance = Distance(center, original);

            currentAngle += rotation;
            currentAngle = ValidateRadianAngle(currentAngle);
            return PlotPoint(currentAngle, center, distance);
        }

        /// <summary>
        /// Rotates a point around a center point.
        /// </summary>
        /// <param name="original">The original location.</param>
        /// <param name="center">The center point to rotate around.</param>
        /// <param name="rotation">The amount of rotation to perform.</param>
        /// <returns>The new point location after rotation.</returns>
        public static Point RotatePointDegrees(Point original, Point center, double rotation)
        {
            double currentAngle = GetAngle(center, original);
            double distance = Distance(center, original);


            currentAngle += rotation;
            currentAngle = ValidateDegreeAngle(currentAngle);
            return PlotPoint(currentAngle, center, distance);
        }

        /// <summary>
        /// Rotates a point around a center point.
        /// </summary>
        /// <param name="original">The original location.</param>
        /// <param name="center">The center point to rotate around.</param>
        /// <param name="rotation">The amount of rotation to perform.</param>
        /// <returns>The new point location after rotation.</returns>
        public static PointF RotatePointDegrees(PointF original, PointF center, double rotation)
        {
            double currentAngle = GetAngle(center, original);
            double distance = Distance(center, original);


            currentAngle += rotation;
            currentAngle = ValidateDegreeAngle(currentAngle);
            return PlotPoint(currentAngle, center, distance);
        }

        /// <summary>
        /// Rotates a point around a center point.
        /// </summary>
        /// <param name="original">The original location.</param>
        /// <param name="center">The center point to rotate around.</param>
        /// <param name="rotation">The amount of rotation to perform.</param>
        /// <returns>The new point location after rotation.</returns>
        public static PointD RotatePointDegrees(PointD original, PointD center, double rotation)
        {
            double currentAngle = GetAngle(center, original);
            double distance = Distance(center, original);


            currentAngle += rotation;
            currentAngle = ValidateDegreeAngle(currentAngle);
            return PlotPoint(currentAngle, center, distance);
        }

        public static void ThreePointCircle(Point A, Point B, Point C, out Point center, out double radius)
        {
            Point abMid = PlotPoint(GetAngle(A, B), A, Distance(A, B) / 2);
            Point bcMid = PlotPoint(GetAngle(B, C), B, Distance(B, C) / 2);
            //PointD caMid = MathEx.PlotPoint(MathEx.GetAngle(C, A), C, MathEx.GetLength(C, A) / 2);

            double abPerp = ValidateDegreeAngle(GetAngle(A, B) + 90);
            double bcPerp = ValidateDegreeAngle(GetAngle(B, C) + 90);
            //double caPerp = MathEx.ValidateDegreeAngle(MathEx.GetAngle(C, A) + 90);

            Point abbcInt = GetIntersection(abMid, PlotPoint(abPerp, abMid, 1), bcMid, PlotPoint(bcPerp, bcMid, 1));
            //PointD bccaInt = MathEx.GetIntersection(bcMid, MathEx.PlotPoint(bcPerp, bcMid, 1), caMid, MathEx.PlotPoint(caPerp, caMid, 1));
            //PointD caabInt = MathEx.GetIntersection(caMid, MathEx.PlotPoint(caPerp, caMid, 1), abMid, MathEx.PlotPoint(abPerp, abMid, 1));

            center = abbcInt;
            radius = Distance(center, A);
        }

        public static void ThreePointCircle(PointF A, PointF B, PointF C, out PointF center, out double radius)
        {
            PointF abMid = PlotPoint(GetAngle(A, B), A, Distance(A, B) / 2);
            PointF bcMid = PlotPoint(GetAngle(B, C), B, Distance(B, C) / 2);
            //PointD caMid = MathEx.PlotPoint(MathEx.GetAngle(C, A), C, MathEx.GetLength(C, A) / 2);

            double abPerp = ValidateDegreeAngle(GetAngle(A, B) + 90);
            double bcPerp = ValidateDegreeAngle(GetAngle(B, C) + 90);
            //double caPerp = MathEx.ValidateDegreeAngle(MathEx.GetAngle(C, A) + 90);

            PointF abbcInt = GetIntersection(abMid, PlotPoint(abPerp, abMid, 1), bcMid, PlotPoint(bcPerp, bcMid, 1));
            //PointD bccaInt = MathEx.GetIntersection(bcMid, MathEx.PlotPoint(bcPerp, bcMid, 1), caMid, MathEx.PlotPoint(caPerp, caMid, 1));
            //PointD caabInt = MathEx.GetIntersection(caMid, MathEx.PlotPoint(caPerp, caMid, 1), abMid, MathEx.PlotPoint(abPerp, abMid, 1));

            center = abbcInt;
            radius = Distance(center, A);
        }

        public static void ThreePointCircle(PointD A, PointD B, PointD C, out PointD center, out double radius)
        {
            PointD abMid = PlotPoint(GetAngle(A, B), A, Distance(A, B) / 2);
            PointD bcMid = PlotPoint(GetAngle(B, C), B, Distance(B, C) / 2);
            //PointD caMid = MathEx.PlotPoint(MathEx.GetAngle(C, A), C, MathEx.GetLength(C, A) / 2);

            double abPerp = ValidateDegreeAngle(GetAngle(A, B) + 90);
            double bcPerp = ValidateDegreeAngle(GetAngle(B, C) + 90);
            //double caPerp = MathEx.ValidateDegreeAngle(MathEx.GetAngle(C, A) + 90);

            PointD abbcInt = GetIntersection(abMid, PlotPoint(abPerp, abMid, 1), bcMid, PlotPoint(bcPerp, bcMid, 1));
            //PointD bccaInt = MathEx.GetIntersection(bcMid, MathEx.PlotPoint(bcPerp, bcMid, 1), caMid, MathEx.PlotPoint(caPerp, caMid, 1));
            //PointD caabInt = MathEx.GetIntersection(caMid, MathEx.PlotPoint(caPerp, caMid, 1), abMid, MathEx.PlotPoint(abPerp, abMid, 1));

            center = abbcInt;
            radius = Distance(center, A);
        }

        /// <summary>
        /// Determines if an array of points is in a clockwise pattern.
        /// </summary>
        /// <param name="points">The points to test.</param>
        /// <returns>Returns true if the points are in a clockwise pattern.</returns>
        public static bool IsClockwise(Point[] points)
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += (points[i + 1].X - points[i].X) * (points[i + 1].Y + points[i].Y);
            }
            return sum > 0 ? true : false;
        }

        /// <summary>
        /// Determines if an array of points is in a clockwise pattern.
        /// </summary>
        /// <param name="points">The points to test.</param>
        /// <returns>Returns true if the points are in a clockwise pattern.</returns>
        public static bool IsClockwise(PointF[] points)
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += (points[i + 1].X - points[i].X) * (points[i + 1].Y + points[i].Y);
            }
            return sum > 0 ? true : false;
        }

        /// <summary>
        /// Determines if an array of points is in a clockwise pattern.
        /// </summary>
        /// <param name="points">The points to test.</param>
        /// <returns>Returns true if the points are in a clockwise pattern.</returns>
        public static bool IsClockwise(PointD[] points)
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += (points[i + 1].X - points[i].X) * (points[i + 1].Y + points[i].Y);
            }
            return sum > 0 ? true : false;
        }

        /// <summary>
        /// Mirrors a point using the ref points.
        /// </summary>
        /// <param name="point">The point to mirror.</param>
        /// <param name="refStartPoint">The starting point of the mirror line.</param>
        /// <param name="refEndPoint">The end point of the mirror line.</param>
        /// <returns>The new mirrored point.</returns>
        public static Point MirrorPoint(Point point, Point refStartPoint, Point refEndPoint)
        {
            return MirrorPoints(new Point[] { point }, refStartPoint, refEndPoint)[0];
        }

        /// <summary>
        /// Mirrors a point using the ref points.
        /// </summary>
        /// <param name="point">The point to mirror.</param>
        /// <param name="refStartPoint">The starting point of the mirror line.</param>
        /// <param name="refEndPoint">The end point of the mirror line.</param>
        /// <returns>The new mirrored point.</returns>
        public static PointF MirrorPoint(PointF point, PointF refStartPoint, PointF refEndPoint)
        {
            return MirrorPoints(new PointF[] { point }, refStartPoint, refEndPoint)[0];
        }

        /// <summary>
        /// Mirrors a point using the ref points.
        /// </summary>
        /// <param name="point">The point to mirror.</param>
        /// <param name="refStartPoint">The starting point of the mirror line.</param>
        /// <param name="refEndPoint">The end point of the mirror line.</param>
        /// <returns>The new mirrored point.</returns>
        public static PointD MirrorPoint(PointD point, PointD refStartPoint, PointD refEndPoint)
        {
            return MirrorPoints(new PointD[] { point }, refStartPoint, refEndPoint)[0];
        }

        /// <summary>
        /// Mirrors an array of points using the ref points.
        /// </summary>
        /// <param name="points">The points to mirror.</param>
        /// <param name="refStartPoint">The starting point of the mirror line.</param>
        /// <param name="refEndPoint">The end point of the mirror line.</param>
        /// <returns>The new mirrored points.</returns>
        public static Point[] MirrorPoints(Point[] points, Point refStartPoint, Point refEndPoint)
        {
            Point[] mpoints = new Point[points.Length];
            int pindex = 0;
            double refAngle = GetRadians(refStartPoint, refEndPoint);
            foreach (Point pnt in points)
            {
                double pWorldRad = GetRadians(refStartPoint, pnt);
                double theta = ValidateRadianAngle(pWorldRad - refAngle);
                double pLen = Distance(refStartPoint, pnt);
                double rightLen = Math.Sin(theta) * pLen;
                double rightWorldA = ValidateRadianAngle(pWorldRad + (Math.PI - theta - (Math.PI / 2)) - Math.PI);
                mpoints[pindex] = PlotPointFromRadians(rightWorldA, pnt, rightLen * 2);
                pindex++;
            }
            return mpoints;
        }

        /// <summary>
        /// Mirrors an array of points using the ref points.
        /// </summary>
        /// <param name="points">The points to mirror.</param>
        /// <param name="refStartPoint">The starting point of the mirror line.</param>
        /// <param name="refEndPoint">The end point of the mirror line.</param>
        /// <returns>The new mirrored points.</returns>
        public static PointF[] MirrorPoints(PointF[] points, PointF refStartPoint, PointF refEndPoint)
        {
            PointF[] mpoints = new PointF[points.Length];
            int pindex = 0;
            double refAngle = GetRadians(refStartPoint, refEndPoint);
            foreach (PointF pnt in points)
            {
                double pWorldRad = GetRadians(refStartPoint, pnt);
                double theta = ValidateRadianAngle(pWorldRad - refAngle);
                double pLen = Distance(refStartPoint, pnt);
                double rightLen = Math.Sin(theta) * pLen;
                double rightWorldA = ValidateRadianAngle(pWorldRad + (Math.PI - theta - (Math.PI / 2)) - Math.PI);
                mpoints[pindex] = PlotPointFromRadians(rightWorldA, pnt, rightLen * 2);
                pindex++;
            }
            return mpoints;
        }

        /// <summary>
        /// Mirrors an array of points using the ref points.
        /// </summary>
        /// <param name="points">The points to mirror.</param>
        /// <param name="refStartPoint">The starting point of the mirror line.</param>
        /// <param name="refEndPoint">The end point of the mirror line.</param>
        /// <returns>The new mirrored points.</returns>
        public static PointD[] MirrorPoints(PointD[] points, PointD refStartPoint, PointD refEndPoint)
        {
            PointD[] mpoints = new PointD[points.Length];
            int pindex = 0;
            double refAngle = GetRadians(refStartPoint, refEndPoint);
            foreach (PointD pnt in points)
            {
                double pWorldRad = GetRadians(refStartPoint, pnt);
                double theta = ValidateRadianAngle(pWorldRad - refAngle);
                double pLen = Distance(refStartPoint, pnt);
                double rightLen = Math.Sin(theta) * pLen;
                double rightWorldA = ValidateRadianAngle(pWorldRad + (Math.PI - theta - (Math.PI / 2)) - Math.PI);
                mpoints[pindex] = PlotPointFromRadians(rightWorldA, pnt, rightLen * 2);
                pindex++;
            }
            return mpoints;
        }

    }
}
