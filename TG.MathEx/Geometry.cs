using System;
using System.Collections.Generic;
using System.Text;

namespace TG.MathEx
{
	public static class Geometry
	{
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

		public static bool WillIntersect(PointD L1P1, PointD L1P2, PointD L2P1, PointD L2P2)
		{
			double A1 = L1P2.Y - L1P1.Y;
			double B1 = L1P1.X - L1P2.X;
			double A2 = L2P2.Y - L2P1.Y;
			double B2 = L2P1.X - L2P2.X;
			double Delta = A1 * B2 - A2 * B1;
			return Delta == 0 ? false : true;
		}

		public static bool DoesIntersect(PointD L1P1, PointD L1P2, PointD L2P1, PointD L2P2)
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
				return false;
			}
			else
			{
				double X = (B2 * C1 - B1 * C2) / Delta;
				double Y = (A1 * C2 - A2 * C1) / Delta;
				PointD result = new PointD(X, Y);
				double OriginalAngle = GetAngle(L1P1, L1P2);
				double NewAngle = GetAngle(L1P1, result);
				OriginalAngle = OriginalAngle == 360 ? 0 : OriginalAngle;
				NewAngle = NewAngle == 360 ? 0 : NewAngle;
				if (Math.Abs(NewAngle - OriginalAngle) <= .0001)
				{
					double line1 = Distance(L1P1, L1P2);
					double sample1 = Distance(L1P1, result);


					double line2 = Distance(L2P1, L2P2);
					double sample2 = Distance(L2P1, result);
					double sample3 = Distance(L2P2, result);

					return sample1 <= line1 && sample2 <= line2 && sample3 <= line2;
				}
				else
					return false;
			}
		}

		public static double Distance(PointD p1, PointD p2)
		{
			double n = (Math.Pow((p2.X - p1.X), 2)) + (Math.Pow((p2.Y - p1.Y), 2));
			return Math.Sqrt(n);
		}

		/// <summary>
		/// Returns angle of two point in degrees.
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static double GetAngle(PointD p1, PointD p2)
		{
			double radians = Math.Atan2(p2.Y - p1.Y, p2.X - p1.X);
			return ValidateDegreeAngle(GetDegrees(radians));
		}

		public static double GetRadians(PointD p1, PointD p2)
		{
			return Math.Atan2(p2.Y - p1.Y, p2.X - p1.X);
		}

		public static double GetRadians(double Angle)
		{
			return Angle * (Math.PI / 180);
		}

		public static double ValidateRadianAngle(double angle)
		{
			double pi2 = Math.PI * 2;

			if (angle < 0)
				angle += pi2;
			else if (angle > pi2)
				angle -= pi2;

			return angle;
		}

		public static double GetDegrees(double radians)
		{
			return radians * (180 / Math.PI);
		}

		public static double ValidateDegreeAngle(double angle)
		{
			double fullcircle = 360;
			if (angle < 0)
				angle += fullcircle;
			else if (angle > fullcircle)
				angle -= fullcircle;
			return angle;
		}

		public static PointD PlotPoint(double Angle, PointD StartPoint, double Length)
		{
			double radians = GetRadians(Angle);
			double x = StartPoint.X + (Length * Math.Cos(radians));
			double y = StartPoint.Y + (Length * Math.Sin(radians));
			return new PointD(x, y);
		}

		public static PointD PlotPointFromRadians(double Radians, PointD StartPoint, double Length)
		{
			double x = StartPoint.X + (Length * Math.Cos(Radians));
			double y = StartPoint.Y + (Length * Math.Sin(Radians));
			return new PointD(x, y);
		}

		public static PointD OrthoPoint(PointD point, PointD center)
		{
			double angle = GetAngle(center, point);
			if (angle <= 45 || angle >= 315)
				return new PointD(point.X, center.Y);
			else if (angle > 45 && angle < 135)
				return new PointD(center.X, point.Y);
			else if (angle >= 135 && angle <= 225)
				return new PointD(point.X, center.Y);
			else
				return new PointD(center.X, point.Y);
		}

		public static PointD RotatePointRadians(PointD source, PointD center, double rotation)
		{
			double currentAngle = GetRadians(center, source);
			double distance = Distance(center, source);

			currentAngle += rotation;
			currentAngle = ValidateRadianAngle(currentAngle);
			return PlotPoint(currentAngle, center, distance);
		}

		public static PointD RotatePointDegrees(PointD source, PointD center, double rotation)
		{
			double currentAngle = GetAngle(center, source);
			double distance = Distance(center, source);


			currentAngle += rotation;
			currentAngle = ValidateDegreeAngle(currentAngle);
			return PlotPoint(currentAngle, center, distance);
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

		public static bool IsClockwise(PointD[] points)
		{
			double sum = 0;

			for (int i = 0; i < points.Length - 1; i++)
			{
				sum += (points[i + 1].X - points[i].X) * (points[i + 1].Y + points[i].Y);
			}
			return sum > 0 ? true : false;
		}

		public static PointD MirrorPoint(PointD point, PointD refPoint, PointD endPoint)
		{
			return MirrorPoints(new PointD[] { point }, refPoint, endPoint)[0];
		}

		public static PointD[] MirrorPoints(PointD[] points, PointD refPoint, PointD endPoint)
		{
			PointD[] mpoints = new PointD[points.Length];
			int pindex = 0;
			double refAngle = GetRadians(refPoint, endPoint);
			foreach (PointD pnt in points)
			{
				double pWorldRad = GetRadians(refPoint, pnt);
				double theta = ValidateRadianAngle(pWorldRad - refAngle);
				double pLen = Distance(refPoint, pnt);
				double rightLen = Math.Sin(theta) * pLen;
				double rightWorldA = ValidateRadianAngle(pWorldRad + (Math.PI - theta - (Math.PI / 2)) - Math.PI);
				mpoints[pindex] = PlotPointFromRadians(rightWorldA, pnt, rightLen * 2);
				pindex++;
			}
			return mpoints;
		}

	}
}
