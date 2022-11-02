using System;
using System.Collections.Generic;
using System.Text;

namespace TG.MathEx
{
    /// <summary>
    /// Represents an ordered pair of double x- and y-coordinates that defines a point in a two-dimensional plane.
    /// </summary>
    public struct SizeD
    {
        /// <summary>
        /// Represents a new instance of the PointD struct with member data left uninitialized.
        /// </summary>
        /// <returns></returns>
        public static SizeD Empty = default(SizeD);

        double _width, _height;

        /// <summary>
        /// Initializes a new instance of the PointD struct with the specified
        /// width and height.
        /// </summary>
        /// <param name="width">The width component of the new SizeD structure.</param>
        /// <param name="height">The height component of the new SizeD structure.</param>
        public SizeD(double width, double height)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// Initializes a new instance of the PointD struct with the specified
        /// width and height.
        /// </summary>
        /// <param name="width">The width component of the new SizeD structure.</param>
        /// <param name="height">The height component of the new SizeD structure.</param>
        public SizeD(float width, float height)
        {
            _width = (double)width;
            _height = (double)height;
        }

        /// <summary>
        /// Initializes a new instance of the PointD struct with the specified
        /// <see cref="System.Drawing.Size"/>
        /// </summary>
        /// <param name="size">The size of the new SizeD structure.</param>
        public SizeD(System.Drawing.Size size)
        {
            _width = (double)size.Width;
            _height = (double)size.Height;
        }

        /// <summary>
        /// Initializes a new instance of the PointD struct with the specified
        /// <see cref="System.Drawing.SizeF"/>
        /// </summary>
        /// <param name="size">The size of the new SizeD structure.</param>
        public SizeD(System.Drawing.SizeF size)
        {
            _width = (double)size.Width;
            _height = (double)size.Height;
        }

        /// <summary>
        /// Gets or sets the horizontal component of this SizeD structure.
        /// </summary>
        /// <value>Double</value>
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// Gets or sets the vertical component of this SizeD structure.
        /// </summary>
        /// <value></value>
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// Explicitly converts this SizeD structure to <see cref="System.Drawing.Size"/>.
        /// </summary>
        /// <param name="size"><see cref="System.Drawing.Size"/></param>
        public static explicit operator System.Drawing.Size(SizeD size)
        {
            return new System.Drawing.Size((int)size.Width, (int)size.Height);
        }

        /// <summary>
        /// Explicitly converts this SizeD structure to <see cref="System.Drawing.SizeF"/>.
        /// </summary>
        /// <param name="size"><see cref="System.Drawing.SizeF"/></param>
        public static explicit operator System.Drawing.SizeF(SizeD size)
        {
            return new System.Drawing.SizeF((float)size.Width, (float)size.Height);
        }

        /// <summary>
        /// Explicitly converts this <see cref="System.Drawing.Size"/> structure to SizeD.
        /// </summary>
        /// <param name="size"><see cref="SizeD"/></param>
        public static explicit operator SizeD(System.Drawing.Size size)
        {
            return new SizeD(size);
        }

        /// <summary>
        /// Explicitly converts this <see cref="System.Drawing.SizeF"/> structure to SizeD.
        /// </summary>
        /// <param name="size"><see cref="SizeD"/></param>
        public static explicit operator SizeD(System.Drawing.SizeF size)
        {
            return new SizeD(size);
        }

        /// <summary>
        /// Tests whether two <see cref="SizeD"/> structures are equal.
        /// </summary>
        /// <param name="left">The <see cref="SizeD"/> structure on the left
        /// side of the equality operator.</param>
        /// <param name="right">The <see cref="SizeD"/> structure on the right
        /// side of the equality operator.</param>
        /// <returns><see cref="bool"/></returns>
        public static bool operator ==(SizeD left, SizeD right)
        {
            return left.Width == right.Width && left.Height == right.Height;
        }

        /// <summary>
        /// Tests whether two <see cref="SizeD"/> structures are not equal.
        /// </summary>
        /// <param name="left">The <see cref="SizeD"/> structure on the left
        /// side of the equality operator.</param>
        /// <param name="right">The <see cref="SizeD"/> structure on the right
        /// side of the equality operator.</param>
        /// <returns><see cref="bool"/></returns>
        public static bool operator !=(SizeD left, SizeD right)
        {
            return left.Width != right.Width || left.Height != right.Height;
        }

        /// <summary>
        /// Subtracts the width and height of one <see cref="SizeD"/> structure
        /// from the width and height of another <see cref="SizeD"/> structure.
        /// </summary>
        /// <param name="left">The <see cref="SizeD"/> structure on the left side of the subtraction operator.</param>
        /// <param name="right">The <see cref="SizeD"/> structure on the right side of the subtraction operator.</param>
        /// <returns><see cref="SizeD"/></returns>
        public static SizeD operator -(SizeD left, SizeD right)
        {
            return new SizeD(left.Width - right.Width, left.Height - right.Height);
        }

        /// <summary>
        /// Adds the width and height of one <see cref="SizeD"/> structure
        /// from the width and height of another <see cref="SizeD"/> structure.
        /// </summary>
        /// <param name="left">The <see cref="SizeD"/> structure on the left side of the addition operator.</param>
        /// <param name="right">The <see cref="SizeD"/> structure on the right side of the addition operator.</param>
        /// <returns><see cref="SizeD"/></returns>
        public static SizeD operator +(SizeD left, SizeD right)
        {
            return new SizeD(left.Width + right.Width, left.Height + right.Height);
        }

        /// <summary>
        /// Tests to see whether the specified object is a <see cref="SizeD"/> structure
        /// with the same dimensions as this <see cref="SizeD"/> structure.
        /// </summary>
        /// <param name="obj">The <see cref="Object"/> to test.</param>
        /// <returns><see cref="Boolean"/></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is SizeD))
                return false;
            return this == (SizeD)obj;
        }

		/// <summary>
		/// Creates a human-readable string that represents this <see cref="SizeD"/> structure.
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}", Width, Height);
        }
		
		/// <summary>
		/// Returns a hash code for this <see cref="SizeD"/> structure.
		/// </summary>
		/// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
