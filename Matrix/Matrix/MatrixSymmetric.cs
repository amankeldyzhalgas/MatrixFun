﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix.Matrix
{
    public class MatrixSymmetric : MatrixSquare
    {
        public MatrixSymmetric(int size) : base(size)
        {

        }

        public override int this[int x, int y] {
            get
            {
                return base[x, y];
            }
            set
            {
                base[x, y] = value;
                base[y, x] = value;
            }
        }
    }
}
