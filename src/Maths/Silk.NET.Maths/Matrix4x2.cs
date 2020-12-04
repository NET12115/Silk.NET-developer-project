﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public struct Matrix4x2<T> : IEquatable<Matrix4x2<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private static readonly Matrix4x2<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>
        /// Row 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2<T> Row1;
        
        /// <summary>
        /// Row 2 of the matrix
        /// </summary>
        [IgnoreDataMember]
        public Vector2<T> Row2;
        
        /// <summary>
        /// Row 3 of the matrix
        /// </summary>
        [IgnoreDataMember]
        public Vector2<T> Row3;
        
        /// <summary>
        /// Row 4 of the matrix
        /// </summary>
        [IgnoreDataMember]
        public Vector2<T> Row4;

        
        
        /// <summary>
        /// Column 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4<T> Column1 => new(Row1.X, Row2.X, Row3.X, Row4.X);
        
        /// <summary>
        /// Column 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4<T> Column2 => new(Row1.Y, Row2.Y, Row3.X, Row4.X);

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        [DataMember]
        public T M11
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        [DataMember]
        public T M12
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        [DataMember]
        public T M21
        {
            readonly get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        [DataMember]
        public T M22
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>Value at row 3, column 1 of the matrix.</summary>
        [DataMember]
        public T M31
        {
            readonly get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>Value at row 3, column 2 of the matrix.</summary>
        [DataMember]
        public T M32
        {
            readonly get => Row3.Y;
            set => Row3.Y = value;
        }

        /// <summary>Value at row 4, column 1 of the matrix.</summary>
        [DataMember]
        public T M41
        {
            readonly get => Row4.X;
            set => Row4.X = value;
        }

        /// <summary>Value at row 4, column 2 of the matrix.</summary>
        [DataMember]
        public T M42
        {
            readonly get => Row4.Y;
            set => Row4.Y = value;
        }
        
        /// <summary>
        /// Indexer for the rows of this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        public unsafe Vector2<T> this[int x]
        {
            get
            {
                static void VerifyBounds(int i)
                {
                    static void ThrowHelper() => throw new IndexOutOfRangeException();
                    
                    if (i > 3 || i < 0)
                        ThrowHelper();
                }
                
                VerifyBounds(x);
                return Unsafe.Add(ref Row1, x);
            }
        }

        /// <summary>
        /// Indexer for the values in this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        /// <param name="y">The column to select. Zero based.</param>
        public unsafe T this[int x, int y]
        {
            get
            {
                var row = this[x];
                return row[y];
            }
        }

        /// <summary>
        /// Constructs a Matrix4x2 from the given rows.
        /// </summary>
        public Matrix4x2(Vector2<T> row1, Vector2<T> row2, Vector2<T> row3, Vector2<T> row4)
        {
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
            Row4 = row4;
        }

        /// <summary>Constructs a Matrix4x2 from the given components.</summary>
        public Matrix4x2(T m11, T m12, T m21, T m22, T m31, T m32, T m41, T m42)
        {
            Row1 = new(m11, m12);
            Row2 = new(m21, m22);
            Row3 = new(m31, m32);
            Row4 = new(m41, m42);
        }

        /// <summary>Constructs a Matrix4x2 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix4x2(Matrix3x2<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = default;
            Row4 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a Matrix4x2 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix4x2(Matrix4x3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
            Row4 = new(value.M41, value.M42);
        }

        /// <summary>Constructs a Matrix4x2 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix4x2(Matrix3x4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
            Row4 = default;
        }

        /// <summary>Constructs a Matrix4x2 from the given Matrix3x3.</summary>
        /// <param name="value">The source Matrix3x3.</param>
        public Matrix4x2(Matrix3x3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = default;
            Row4 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a Matrix4x2 from the given Matrix2x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix4x2(Matrix2x4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = default;
            Row4 = default;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4x2<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) &&
               Scalar.Equal(M22, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M21, Scalar<T>.Zero) &&
               Scalar.Equal(M31, Scalar<T>.Zero) && Scalar.Equal(M32, Scalar<T>.Zero) &&
               Scalar.Equal(M41, Scalar<T>.Zero) && Scalar.Equal(M42, Scalar<T>.Zero);


        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix4x2<T> operator +(Matrix4x2<T> value1, Matrix4x2<T> value2)
        {
            return new
            (
                value1.Row1 + value2.Row1, value1.Row2 + value2.Row2, value1.Row3 + value2.Row3,
                value1.Row4 + value2.Row4
            );
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix4x2<T> value1, Matrix4x2<T> value2)
        {
            return Scalar.Equal(value1.M11, value2.M11) && Scalar.Equal(value1.M22, value2.M22) &&
                   // Check diagonal elements first for early out.
                   Scalar.Equal(value1.M12, value2.M12) && Scalar.Equal(value1.M21, value2.M21) &&
                   Scalar.Equal(value1.M31, value2.M31) && Scalar.Equal(value1.M32, value2.M32) &&
                   Scalar.Equal(value1.M41, value2.M41) && Scalar.Equal(value1.M42, value2.M42);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix4x2<T> value1, Matrix4x2<T> value2)
        {
            return Scalar.NotEqual(value1.M11, value2.M11) || Scalar.NotEqual(value1.M22, value2.M22) ||  // Check diagonal elements first for early out.
                   Scalar.NotEqual(value1.M12, value2.M12) || Scalar.NotEqual(value1.M21, value2.M21) ||
                   Scalar.NotEqual(value1.M31, value2.M31) || Scalar.NotEqual(value1.M32, value2.M32) ||
                   Scalar.NotEqual(value1.M41, value2.M41) || Scalar.NotEqual(value1.M42, value2.M42);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x2<T> operator *(Matrix4x2<T> value1, Matrix2x2<T> value2)
        {
            return new(
                    value1.M11 * value2.Row1 + value1.M12 * value2.Row2,
                    value1.M21 * value2.Row1 + value1.M22 * value2.Row2,
                    value1.M31 * value2.Row1 + value1.M32 * value2.Row2,
                    value1.M41 * value2.Row1 + value1.M42 * value2.Row2
                );
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x3<T> operator *(Matrix4x2<T> value1, Matrix2x3<T> value2)
        {
            return new(
                    value1.M11 * value2.Row1 + value1.M12 * value2.Row2,
                    value1.M21 * value2.Row1 + value1.M22 * value2.Row2,
                    value1.M31 * value2.Row1 + value1.M32 * value2.Row2,
                    value1.M41 * value2.Row1 + value1.M42 * value2.Row2
                );
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x4<T> operator *(Matrix4x2<T> value1, Matrix2x4<T> value2)
        {
            return new(
                    value1.M11 * value2.Row1 + value1.M12 * value2.Row2,
                    value1.M21 * value2.Row1 + value1.M22 * value2.Row2,
                    value1.M31 * value2.Row1 + value1.M32 * value2.Row2,
                    value1.M41 * value2.Row1 + value1.M42 * value2.Row2
                );
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x2<T> operator *(Matrix2x4<T> value1, Matrix4x2<T> value2)
        {
            return new(
                    value1.M11 * value2.Row1 + value1.M12 * value2.Row2 + value1.M13 * value2.Row3 + value1.M14 * value2.Row4,
                    value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M23 * value2.Row3 + value1.M24 * value2.Row4
                );
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x2<T> operator *(Matrix3x4<T> value1, Matrix4x2<T> value2)
        {
            return new(
                value1.M11 * value2.Row1 + value1.M12 * value2.Row2 + value1.M13 * value2.Row3 + value1.M14 * value2.Row4,
                value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M23 * value2.Row3 + value1.M24 * value2.Row4,
                value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M23 * value2.Row3 + value1.M24 * value2.Row4
            );
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x2<T> operator *(Matrix4x4<T> value1, Matrix4x2<T> value2)
        {
            return new(
                value1.M11 * value2.Row1 + value1.M12 * value2.Row2 + value1.M13 * value2.Row3 + value1.M14 * value2.Row4,
                value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M23 * value2.Row3 + value1.M24 * value2.Row4,
                value1.M31 * value2.Row1 + value1.M32 * value2.Row2 + value1.M33 * value2.Row3 + value1.M34 * value2.Row4,
                value1.M41 * value2.Row1 + value1.M42 * value2.Row2 + value1.M43 * value2.Row3 + value1.M44 * value2.Row4
            );
        }
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector2<T> operator *(Vector4<T> value1, Matrix4x2<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3 + value1.W * value2.Row4;
        }
                
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix4x2<T> operator *(Matrix4x2<T> value1, T value2)
        {
            return new(value1.Row1 * value2, value1.Row2 * value2, value1.Row3 * value2, value1.Row4 * value2);
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix4x2<T> operator -(Matrix4x2<T> value1, Matrix4x2<T> value2)
        {
            return new(value1.Row1 - value2.Row1, value1.Row2 - value2.Row2, value1.Row3 - value2.Row3, value1.Row4 - value2.Row4);
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix4x2<T> operator -(Matrix4x2<T> value)
        {
            return new(-value.Row1, -value.Row2, -value.Row3, -value.Row4);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix4x2<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix4x2<T> other)
            => this == other;
        
        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);

            hash.Add(M21);
            hash.Add(M22);

            hash.Add(M31);
            hash.Add(M32);

            hash.Add(M41);
            hash.Add(M42);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1}}} {{M21:{2} M22:{3}}} {{M31:{4} M32:{5}}} {{M41:{6} M42:{7}}} }}",
                                 M11, M12,
                                 M21, M22,
                                 M31, M32,
                                 M41, M42);
        }

        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix4x2<Half>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, Half>(from.M11),Scalar.As<T, Half>(from.M12),
                Scalar.As<T, Half>(from.M21),Scalar.As<T, Half>(from.M22),
                Scalar.As<T, Half>(from.M31),Scalar.As<T, Half>(from.M32),
                Scalar.As<T, Half>(from.M41),Scalar.As<T, Half>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix4x2<float>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, float>(from.M11),Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M21),Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M31),Scalar.As<T, float>(from.M32),
                Scalar.As<T, float>(from.M41),Scalar.As<T, float>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix4x2<double>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, double>(from.M11),Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M21),Scalar.As<T, double>(from.M22),
                Scalar.As<T, double>(from.M31),Scalar.As<T, double>(from.M32),
                Scalar.As<T, double>(from.M41),Scalar.As<T, double>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix4x2<decimal>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, decimal>(from.M11),Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M21),Scalar.As<T, decimal>(from.M22),
                Scalar.As<T, decimal>(from.M31),Scalar.As<T, decimal>(from.M32),
                Scalar.As<T, decimal>(from.M41),Scalar.As<T, decimal>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix4x2<sbyte>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, sbyte>(from.M11),Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M21),Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M31),Scalar.As<T, sbyte>(from.M32),
                Scalar.As<T, sbyte>(from.M41),Scalar.As<T, sbyte>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix4x2<byte>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, byte>(from.M11),Scalar.As<T, byte>(from.M12),
                Scalar.As<T, byte>(from.M21),Scalar.As<T, byte>(from.M22),
                Scalar.As<T, byte>(from.M31),Scalar.As<T, byte>(from.M32),
                Scalar.As<T, byte>(from.M41),Scalar.As<T, byte>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix4x2<ushort>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, ushort>(from.M11),Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M21),Scalar.As<T, ushort>(from.M22),
                Scalar.As<T, ushort>(from.M31),Scalar.As<T, ushort>(from.M32),
                Scalar.As<T, ushort>(from.M41),Scalar.As<T, ushort>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix4x2<short>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, short>(from.M11),Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M21),Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M31),Scalar.As<T, short>(from.M32),
                Scalar.As<T, short>(from.M41),Scalar.As<T, short>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix4x2<uint>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, uint>(from.M11),Scalar.As<T, uint>(from.M12),
                Scalar.As<T, uint>(from.M21),Scalar.As<T, uint>(from.M22),
                Scalar.As<T, uint>(from.M31),Scalar.As<T, uint>(from.M32),
                Scalar.As<T, uint>(from.M41),Scalar.As<T, uint>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix4x2<int>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, int>(from.M11),Scalar.As<T, int>(from.M12),
                Scalar.As<T, int>(from.M21),Scalar.As<T, int>(from.M22),
                Scalar.As<T, int>(from.M31),Scalar.As<T, int>(from.M32),
                Scalar.As<T, int>(from.M41),Scalar.As<T, int>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix4x2<ulong>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, ulong>(from.M11),Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M21),Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M31),Scalar.As<T, ulong>(from.M32),
                Scalar.As<T, ulong>(from.M41),Scalar.As<T, ulong>(from.M42)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix4x2<long>(Matrix4x2<T> from)
            => new
            (
                Scalar.As<T, long>(from.M11),Scalar.As<T, long>(from.M12),
                Scalar.As<T, long>(from.M21),Scalar.As<T, long>(from.M22),
                Scalar.As<T, long>(from.M31),Scalar.As<T, long>(from.M32),
                Scalar.As<T, long>(from.M41),Scalar.As<T, long>(from.M42)
            );
    }
}
