using Matrix.Matrix;
using System;
using System.Collections.Generic;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myMatrixes = new List<MatrixBase>();
            //myMatrixes.Add(new MatrixSymmetric(5));
            //myMatrixes.Add(new MatrixSquare(5));

            //foreach (var matrix in myMatrixes)
            //{
            //    matrix[1, 2] = 5;
            //    Console.WriteLine(matrix);
            //}

            MatrixBase mat1 = new MatrixDiagonal(5);
            mat1[1, 1] = 7;
            mat1[2, 2] = 2;

            var mat2 = new MatrixDiagonal(5);
            mat2[2] = 1;
            mat2[4] = 9;

            var mat3 = mat2 + mat1;

            Console.WriteLine(mat3);

            Console.ReadLine();
        }
    }
}
