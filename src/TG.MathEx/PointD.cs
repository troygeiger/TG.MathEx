using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TG.MathEx
{
	/// <summary>
	/// Represents an ordered pair of double x- and y-coordinates that defines a point in a two-dimensional plane.
	/// </summary>
	public struct PointD
	{
		/// <summary>
		/// An empty (0,0) PointD
		/// </summary>
		/// <returns></returns>
		public static PointD Empty = default(PointD);

		/// <summary>
		/// Initializes a new instance of the PointD class with the specified coordinates.
		/// </summary>
		/// <param name="x">The horizontal position of the point.</param>
		/// <param name="y">The vertical position of the point.</param>
		public PointD(double x, double y)
		{
			_x = x;
			_y = y;
		}

		/// <summary>
		/// Initializes a new instance of the PointD class with the specified coordinates.
		/// </summary>
		/// <param name="x">The horizontal position of the point.</param>
		/// <param name="y">The vertical position of the point.</param>
		public PointD(float x, float y)
		{
			_x = (double)x;
			_y = (double)y;
		}

		/// <summary>
		/// Initializes a new instance of the PointD class with the specified coordinates.
		/// </summary>
		/// <param name="point">The PointF coordinates this point should be based on.</param>
		public PointD(System.Drawing.PointF point)
		{
			_x = (float)point.X;
			_y = (float)point.Y;
		}

		/// <summary>
		/// Initializes a new instance of the PointD class with the specified coordinates.
		/// </summary>
		/// <param name="point">The Point coordinates this point should be based on.</param>
		public PointD(System.Drawing.Point point)
		{
			_x = point.X;
			_y = point.Y;
		}

		private double _x;

		/// <summary>
		/// Gets or sets the x-coordinate of this PointD.
		/// </summary>
		/// <value><see cref="double"/></value>
		public double X
		{
			get { return _x; }
			set { _x = value; }
		}

		private double _y;

		/// <summary>
		/// Gets or sets the y-coordinate of this PointD.
		/// </summary>
		/// <value><see cref="double"/></value>
		public double Y
		{
			get { return _y; }
			set { _y = value; }
		}

		/// <summary>
		/// Explicitly converts from <see cref="PointD"/> to <see cref="PointF"/>.
		/// </summary>
		/// <param name="point"><see cref="PointD"/></param>
        public static explicit operator System.Drawing.PointF(PointD point)
        {
            return new System.Drawing.PointF((float)point._x, (float)point._y);
        }

		/// <summary>
		/// Explicitly converts from <see cref="PointD"/> to <see cref="Point"/>.
		/// </summary>
		/// <param name="point"><see cref="PointD"/></param>
        public static explicit operator System.Drawing.Point(PointD point)
        {
            return new System.Drawing.Point(Convert.ToInt32(point.X), Convert.ToInt32(point.Y));
        }

		/// <summary>
		/// Explicitly converts from <see cref="PointF"/> to <see cref="PointD"/>.
		/// </summary>
		/// <param name="point"><see cref="PointF"/></param>
        public static explicit operator PointD(System.Drawing.PointF point)
        {
            return new PointD(point);
        }

		/// <summary>
		/// Explicitly converts from <see cref="Point"/> to <see cref="PointD"/>.
		/// </summary>
		/// <param name="point"><see cref="Point"/></param>
        public static explicit operator PointD(System.Drawing.Point point)
        {
            return new PointD(point);
        }

		/// <summary>
		/// Converts an array of <see cref="PointF"/> to a new array of <see cref="PointD"/>.
		/// </summary>
		/// <param name="points">Array of <see cref="PointF"/></param>
        public static PointD[] Cast(System.Drawing.PointF[] points)
		{
			PointD[] result = new PointD[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				result[i] = new PointD(points[i]);
			}
			return result;
		}

		/// <summary>
		/// Converts an array of <see cref="Point"/> to a new array of <see cref="PointD"/>.
		/// </summary>
		/// <param name="points">Array of <see cref="Point"/></param>
		public static PointD[] Cast(System.Drawing.Point[] points)
		{
			PointD[] result = new PointD[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				result[i] = new PointD(points[i]);
			}
			return result;
		}

		/// <summary>
		/// Converts an array of <see cref="PointD"/> to a new array of <see cref="PointF"/>.
		/// </summary>
		/// <param name="points">Array of <see cref="PointD"/></param>
		public static System.Drawing.PointF[] Cast(PointD[] points)
		{
			System.Drawing.PointF[] result = new System.Drawing.PointF[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				result[i] = new System.Drawing.Point(Convert.ToInt32(points[i].X), Convert.ToInt32(points[i].Y));
			}
			return result;
		}

		/// <summary>
		/// Compares two <see cref="PointD"/> structures. The result specifies
		/// whether the values of the X and Y properties of the two <see
		/// cref="PointD"/> structures are equal.
		/// </summary>
		/// <param name="left">A <see cref="PointD"/> to compare.</param>
		/// <param name="right">A <see cref="PointD"/> to compare.</param>
		/// <returns><see cref="bool"/></returns>
		public static bool operator ==(PointD left, PointD right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		/// <summary>
		/// Compares two <see cref="PointD"/> structures. The result specifies
		/// whether the values of the X and Y properties of the two <see
		/// cref="PointD"/> structures are not equal.
		/// </summary>
		/// <param name="left">A <see cref="PointD"/> to compare.</param>
		/// <param name="right">A <see cref="PointD"/> to compare.</param>
		/// <returns><see cref="bool"/></returns>
		public static bool operator !=(PointD left, PointD right)
		{
			return left.X != right.X || left.Y != right.Y;
		}

		/// <summary>
		/// Subtracts two <see cref="PointD"/> structures.
		/// </summary>
		/// <param name="left">The left <see cref="PointD"/> to be subtracted from.</param>
		/// <param name="right">The right <see cref="PointD"/> to subtract.</param>
		/// <returns></returns>
		public static PointD operator -(PointD left, PointD right)
		{
			return new PointD(left.X - right.X, left.Y - right.Y);
		}

		/// <summary>
		/// Adds two <see cref="PointD"/> structure's x and y coordinates into a
		/// new <see cref="PointD"/>.
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static PointD operator +(PointD left, PointD right)
		{
			return new PointD(left.X + right.X, left.Y + right.Y);
		}

		/// <summary>
		/// Offset the current point by a given amount.
		/// </summary>
		/// <param name="offsetX">The amount of offset to apply in the x direction.</param>
		/// <param name="offsetY">The amount of offset to apply in the y direction.</param>
		public void Offset(double offsetX, double offsetY)
		{
			_x += offsetX;
			_y += offsetY;
		}

		/// <summary>
		/// Specifies whether this <see cref="PointD"/> contains the same coordinates as the specified Object.
		/// </summary>
		/// <param name="obj">The object to compare.</param>
		/// <returns><see cref="bool"/></returns>
		public override bool Equals(object obj)
		{
			if (!(obj is PointD))
				return false;
			return this == (PointD)obj;
		}

		/// <summary>
		/// Specifies whether this <see cref="PointD"/> contains the same coordinates as the specified <see cref="PointD"/>.
		/// </summary>
		/// <param name="vertex">The <see cref="PointD"/> to compare.</param>
		/// <returns><see cref="bool"/></returns>
		public bool Equals(PointD vertex)
		{
			return this == vertex;
		}
		
		/// <summary>
		/// Returns the current instance hash code.
		/// </summary>
		/// <returns><see cref="int"/></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>
		/// Converts this <see cref="PointD" /> to a human readable string.
		/// </summary>
		/// <returns><see cref="string"/></returns>
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

		/// <summary>
		/// Clones the current <see cref="PointD"/> into a new <see cref="PointD"/>.
		/// </summary>
		/// <returns><see cref="PointD"/></returns>
		public PointD Clone()
		{
			return new PointD(_x, _y);
		}
	}
}
