using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace TG
{
	public struct RectangleD
	{
		public static RectangleD Empty = default(RectangleD);

		PointD _location;
		SizeD _size;

		public RectangleD(PointD location, SizeD size)
		{
			_location = location;
			_size = size;
		}

		public RectangleD(double x, double y, double width, double height)
		{
			_location = new PointD(x, y);
			_size = new SizeD(width, height);
		}

		public PointD Location
		{
			get { return _location; }
			set { _location = value; }
		}

		public SizeD Size
		{
			get { return _size; }
			set { _size = value; }
		}

		public double X
		{
			get { return _location.X; }
			set { _location.X = value; }
		}

		public double Y
		{
			get { return _location.Y; }
			set { _location.Y = value; }
		}

		public double Width
		{
			get { return _size.Width; }
			set { _size.Width = value; }
		}

		public double Height
		{
			get { return _size.Height; }
			set { _size.Height = value; }
		}

		/// <summary>
		/// Gets the y-coordinate of the top edge of this RectangleD structure.
		/// </summary>
		[Browsable(false)]
		public double Top
		{
			get { return this.Y; }
		}

		/// <summary>
		/// Gets the x-coordinate of the top edge of this RectangleD structure.
		/// </summary>
		[Browsable(false)]
		public double Left
		{
			get { return this.X; }
		}

		/// <summary>
		/// Gets the right edge of this RectangleD structure.
		/// </summary>
		[Browsable(false)]
		public double Right
		{
			get { return this.X + this.Width; }
		}

		/// <summary>
		/// Gets the bottom edge of this RectangleD structure.
		/// </summary>
		[Browsable(false)]
		public double Bottom
		{
			get { return this.Y + this.Height; }
		}

		/// <summary>
		/// Tests whether the width or height properties has a value of zero.
		/// </summary>
		[Browsable(false)]
		public bool IsEmpty
		{
			get { return this.Width <= 0D || this.Height <= 0D; }
		}

		/// <summary>Determines if the specified point is contained within this RectangleD structure.</summary>
		/// <returns>This method returns true if the point defined by <paramref name="x" /> and <paramref name="y" /> is contained within this RectangleD structure; otherwise false.</returns>
		/// <param name="x">The x-coordinate of the point to test. </param>
		/// <param name="y">The y-coordinate of the point to test. </param>
		/// <filterpriority>1</filterpriority>
		public bool Contains(double x, double y)
		{
			return this.X <= x && x < this.X + this.Width && this.Y <= y && y < this.Y + this.Height;
		}

		/// <summary>Determines if the specified point is contained within this RectangleD structure.</summary>
		/// <returns>This method returns true if the point defined by <paramref name="pt" /> is contained within this RectangleD structure; otherwise false.</returns>
		/// <param name="pt">The point to test. </param>
		/// <filterpriority>1</filterpriority>
		public bool Contains(PointD pt)
		{
			return this.Contains(pt.X, pt.Y);
		}

		/// <summary>
		/// Determines if the rectangular region represented by <paramref name="rect" /> is entirely contained within this RectangleD structure.
		/// </summary>
		/// <param name="rect">The RectangleD to test.</param>
		/// <returns>This method returns true if the rectangular region represented by <paramref name="rect" /> is entirely contained within the rectangular region represented by this RectangleD otherwise false.</returns>
		public bool Contains(RectangleD rect)
		{
			return this.X <= rect.X && rect.X + rect.Width <= this.X + this.Width && this.Y <= rect.Y && rect.Y + rect.Height <= this.Y + this.Height;
		}

		/// <summary>
		/// Test whether <paramref name="obj"/> is a RectangleD with the same location and size of this RectangleD structure.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object"/> to test.</param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			if (!(obj is RectangleD))
				return false;
			RectangleD rect = (RectangleD)obj;
			return rect.X == this.X && rect.Y == this.Y && rect.Width == this.Width && rect.Height == this.Height;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>
		/// Inflates this RectangleD structure by the specified amount.
		/// </summary>
		/// <param name="x">The amount to inflate this RectangleD structure horizontally.</param>
		/// <param name="y">The amount to inflate this RectangleD structure vertically.</param>
		public void Inflate(double x, double y)
		{
			this.X -= x;
			this.Y -= y;
			this.Width += 2d * x;
			this.Height += 2d * y;
		}

		/// <summary>
		/// Inflates this RectangleD structure by the specified amount.
		/// </summary>
		/// <param name="size">The amount to inflate this RectangleD.</param>
		public void Inflate(SizeD size)
		{
			this.Inflate(size.Width, size.Height);
		}

		/// <summary>
		/// Creates and returns an inflated copy of the specified RectangleD structure.
		/// </summary>
		/// <param name="rect">The RectangleD to inflate.</param>
		/// <param name="x">The amount to inflate the rectangle copy horizontally.</param>
		/// <param name="y">The amount to inflate the rectangle copy vertically.</param>
		/// <returns></returns>
		public static RectangleD Inflate(RectangleD rect, double x, double y)
		{
			RectangleD result = rect;
			result.Inflate(x, y);
			return result;
		}

		/// <summary>Returns a RectangleD structure that represents the intersection of two rectangles. If there is no intersection, and empty RectangleD is returned.</summary>
		/// <returns>A third RectangleD structure the size of which represents the overlapped area of the two specified rectangles.</returns>
		/// <param name="a">A rectangle to intersect. </param>
		/// <param name="b">A rectangle to intersect. </param>
		/// <filterpriority>1</filterpriority>
		public static RectangleD Intersect(RectangleD a, RectangleD b)
		{
			double num = Math.Max(a.X, b.X);
			double num2 = Math.Min(a.X + a.Width, b.X + b.Width);
			double num3 = Math.Max(a.Y, b.Y);
			double num4 = Math.Min(a.Y + a.Height, b.Y + b.Height);
			if (num2 >= num && num4 >= num3)
			{
				return new RectangleD(num, num3, num2 - num, num4 - num3);
			}
			return RectangleD.Empty;
		}

		/// <summary>Replaces this RectangleD structure with the intersection of itself and the specified RectangleD structure.</summary>
		/// <param name="rect">The rectangle to intersect. </param>
		/// <filterpriority>1</filterpriority>
		public void Intersect(RectangleD rect)
		{
			RectangleD rectangleF = RectangleD.Intersect(rect, this);
			this.X = rectangleF.X;
			this.Y = rectangleF.Y;
			this.Width = rectangleF.Width;
			this.Height = rectangleF.Height;
		}

		/// <summary>Determines if this rectangle intersects with <paramref name="rect" />.</summary>
		/// <returns>This method returns true if there is any intersection.</returns>
		/// <param name="rect">The rectangle to test. </param>
		/// <filterpriority>1</filterpriority>
		public bool IntersectsWith(RectangleD rect)
		{
			return rect.X < this.X + this.Width && this.X < rect.X + rect.Width && rect.Y < this.Y + this.Height && this.Y < rect.Y + rect.Height;
		}

		/// <summary>Adjusts the location of this rectangle by the specified amount.</summary>
		/// <param name="x">The amount to offset the location horizontally. </param>
		/// <param name="y">The amount to offset the location vertically. </param>
		/// <filterpriority>1</filterpriority>
		public void Offset(double x, double y)
		{
			this.X += x;
			this.Y += y;
		}

		/// <summary>Adjusts the location of this rectangle by the specified amount.</summary>
		/// <param name="pos">The amount to offset the location. </param>
		/// <filterpriority>1</filterpriority>
		public void Offset(PointD pos)
		{
			this.Offset(pos.X, pos.Y);
		}

		/// <summary>Creates the smallest possible third rectangle that can contain both of two rectangles that form a union.</summary>
		/// <returns>A third RectangleD structure that contains both of the two rectangles that form the union.</returns>
		/// <param name="a">A rectangle to union. </param>
		/// <param name="b">A rectangle to union. </param>
		/// <filterpriority>1</filterpriority>
		public static RectangleD Union(RectangleD a, RectangleD b)
		{
			double num = Math.Min(a.X, b.X);
			double num2 = Math.Max(a.X + a.Width, b.X + b.Width);
			double num3 = Math.Min(a.Y, b.Y);
			double num4 = Math.Max(a.Y + a.Height, b.Y + b.Height);
			return new RectangleD(num, num3, num2 - num, num4 - num3);
		}

		public override string ToString()
		{
			return string.Concat(new string[]
	{
		"{X=",
		this.X.ToString(CultureInfo.CurrentCulture),
		",Y=",
		this.Y.ToString(CultureInfo.CurrentCulture),
		",Width=",
		this.Width.ToString(CultureInfo.CurrentCulture),
		",Height=",
		this.Height.ToString(CultureInfo.CurrentCulture),
		"}"
	});
		}

		public static bool operator ==(RectangleD left, RectangleD right)
		{
			return left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;
		}

		public static bool operator !=(RectangleD left, RectangleD right)
		{
			return !(left == right);
		}

		public static implicit operator RectangleD(System.Drawing.Rectangle rect)
		{
			return new RectangleD((PointD)rect.Location, (SizeD)rect.Size);
		}

		public static implicit operator System.Drawing.Rectangle(RectangleD rect)
		{
			return new System.Drawing.Rectangle((System.Drawing.Point)rect.Location, (System.Drawing.Size)rect.Size);
		}

		public static implicit operator System.Drawing.RectangleF(RectangleD rect)
		{
			return new System.Drawing.RectangleF((float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height);
		}
	}
}
