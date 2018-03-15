using System;
using System.Collections.Generic;
using System.Text;

namespace TG
{
	public struct PointD
	{
		public static PointD Empty = default(PointD);

		public PointD(double x, double y)
		{
			_x = x;
			_y = y;
		}

		public PointD(float x, float y)
		{
			_x = (double)x;
			_y = (double)y;
		}

		public PointD(System.Drawing.PointF point)
		{
			_x = (float)point.X;
			_y = (float)point.Y;
		}

		public PointD(System.Drawing.Point point)
		{
			_x = point.X;
			_y = point.Y;
		}

		private double _x;

		public double X
		{
			get { return _x; }
			set { _x = value; }
		}

		private double _y;

		public double Y
		{
			get { return _y; }
			set { _y = value; }
		}

		public static implicit operator System.Drawing.PointF(PointD point)
		{
			return new System.Drawing.PointF((float)point._x, (float)point._y);
		}

		public static implicit operator System.Drawing.Point(PointD point)
		{
			return new System.Drawing.Point(Convert.ToInt32(point.X), Convert.ToInt32(point.Y));
		}

		public static implicit operator PointD(System.Drawing.PointF point)
		{
			return new PointD(point);
		}

		public static implicit operator PointD(System.Drawing.Point point)
		{
			return new PointD(point);
		}

		public static PointD[] Cast(System.Drawing.PointF[] points)
		{
			PointD[] result = new PointD[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				result[i] = new PointD(points[i]);
			}
			return result;
		}

		public static PointD[] Cast(System.Drawing.Point[] points)
		{
			PointD[] result = new PointD[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				result[i] = new PointD(points[i]);
			}
			return result;
		}

		public static System.Drawing.PointF[] Cast(PointD[] points)
		{
			System.Drawing.PointF[] result = new System.Drawing.PointF[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				result[i] = new System.Drawing.Point(Convert.ToInt32(points[i].X), Convert.ToInt32(points[i].Y));
			}
			return result;
		}

		public static bool operator ==(PointD left, PointD right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		public static bool operator !=(PointD left, PointD right)
		{
			return left.X != right.X || left.Y != right.Y;
		}

		public static PointD operator -(PointD left, PointD right)
		{
			return new PointD(left.X - right.X, left.Y - right.Y);
		}

		public static PointD operator +(PointD left, PointD right)
		{
			return new PointD(left.X + right.X, left.Y + right.Y);
		}

		public void Offset(double offsetX, double offsetY)
		{
			_x += offsetX;
			_y += offsetY;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is PointD))
				return false;
			return this == (PointD)obj;
		}

		public bool Equals(PointD vertex)
		{
			return this == vertex;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("{0}, {1}", X, Y);
		}

		/// <summary>
		/// Convert PointD to string.
		/// </summary>
		/// <param name="format">Applies the format individually to the X and Y coordinate.</param>
		/// <returns></returns>
		public string ToString(string format)
		{
			return string.Format("{0}, {1}", X.ToString(format), Y.ToString(format));
		}

		public PointD Clone()
		{
			return new PointD(_x, _y);
		}
	}
}
