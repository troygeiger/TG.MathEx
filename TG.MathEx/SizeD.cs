using System;
using System.Collections.Generic;
using System.Text;

namespace TG
{
	public struct SizeD
	{
		public static SizeD Empty = default(SizeD);

		double _width, _height;

		public SizeD(double width, double height)
		{
			_width = width; 
			_height = height;
		}

		public SizeD(float width, float height)
		{
			_width = (double)width;
			_height = (double)height;
		}

		public SizeD(System.Drawing.Size size)
		{
			_width = (double)size.Width;
			_height = (double)size.Height;
		}

		public SizeD(System.Drawing.SizeF size)
		{
			_width = (double)size.Width;
			_height = (double)size.Height;
		}

		public double Width
		{
			get { return _width; }
			set { _width = value; }
		}

		public double Height
		{
			get { return _height; }
			set { _height = value; }
		}

		public static explicit operator System.Drawing.Size(SizeD size)
		{
			return new System.Drawing.Size((int)size.Width, (int)size.Height);
		}

		public static explicit operator System.Drawing.SizeF(SizeD size)
		{
			return new System.Drawing.SizeF((float)size.Width, (float)size.Height);
		}

		public static explicit operator SizeD(System.Drawing.Size size)
		{
			return new SizeD(size);
		}

		public static explicit operator SizeD(System.Drawing.SizeF size)
		{
			return new SizeD(size);
		}

		public static bool operator ==(SizeD left, SizeD right)
		{
			return left.Width == right.Width && left.Height == right.Height;
		}

		public static bool operator !=(SizeD left, SizeD right)
		{
			return left.Width != right.Width || left.Height != right.Height;
		}

		public static SizeD operator -(SizeD left, SizeD right)
		{
			return new SizeD(left.Width - right.Width, left.Height - right.Height);
		}

		public static SizeD operator +(SizeD left, SizeD right)
		{
			return new SizeD(left.Width + right.Width, left.Height + right.Height);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is SizeD))
				return false;
			return this == (SizeD)obj;
		}

		public override string ToString()
		{
			return string.Format("{0}, {1}", Width, Height);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
