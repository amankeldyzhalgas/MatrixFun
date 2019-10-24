using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix.Matrix
{
    public class MatrixDiagonal : MatrixSquare
    {
        public MatrixDiagonal(int size) : base(size)
        {

        }

        public int this[int x] {
            get => base[x, x];
            set => base[x, x] = value;
        }

        /// <summary>
        /// Лучше используйте индексер с одним параметром.
        /// </summary>
        /// <param name="x">должен быть равен у</param>
        /// <param name="y">должен быть равен х</param>
        /// <returns></returns>
        public override int this[int x, int y] {
            get => base[x, y];
            set
            {
                if (x != y)
                {
                    throw new ArgumentException("В диагональной матрице, можно задавать значения только для главное диаогнали. x должен быть равен y");
                }

                base[x, x] = value;
            }
        }

        public static MatrixDiagonal operator +(MatrixDiagonal d1, MatrixDiagonal d2)
        {
            return AddMatrix(d1, d2);
        }

        public static MatrixDiagonal operator +(MatrixDiagonal d1, MatrixBase d2)
        {
            return AddMatrix(d1, d2);
        }

        public static MatrixDiagonal operator +(MatrixBase d1, MatrixDiagonal d2)
        {
            return AddMatrix(d1, d2);
        }

        private static MatrixDiagonal AddMatrix(MatrixBase d1, MatrixBase d2)
        {
            if (d1.Width != d2.Width)
            {
                throw new ArgumentException("Складывать можно только матрица одного размера");
            }

            var result = new MatrixDiagonal(d1.Width);

            for (int i = 0; i < d1.Width; i++)
            {
                result[i] = d1[i, i] + d2[i, i];
            }

            return result;
        }

    }
}
