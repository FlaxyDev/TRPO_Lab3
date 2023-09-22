using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    using System;

    public class Matrix<T> where T : IComparable<T>, new()
    {
        private T[,] matrix;

        public Matrix(int rows, int columns)
        {
            matrix = new T[rows, columns];
        }

        public T this[int row, int column]
        {
            get { return matrix[row, column]; }
            set { matrix[row, column] = value; }
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return matrix.GetLength(1); }
        }

        public void Display()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
        public T SumNonNegativeColumns()
        {
            dynamic sum = default(T);
            for (int col = 0; col < Columns; col++)
            {
                bool hasNegative = false;
                for (int row = 0; row < Rows; row++)
                {
                    if (matrix[row, col].CompareTo(new T()) < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }
                if (!hasNegative)
                {
                    for (int row = 0; row < Rows; row++)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            return sum;
        }

        public T MaxSumOfParallelDiagonals()
        {
            dynamic maxSum = default(T);
            for (int k = 0; k < Rows; k++)
            {
                dynamic diagonalSum = default(T);
                for (int i = 0, j = k; i < Rows && j < Columns; i++, j++)
                {
                    diagonalSum += matrix[i, j];
                }
                if (diagonalSum.CompareTo(maxSum) > 0)
                {
                    maxSum = diagonalSum;
                }
            }

            for (int k = 1; k < Columns; k++)
            {
                dynamic diagonalSum = default(T);
                for (int i = k, j = 0; i < Rows && j < Columns; i++, j++)
                {
                    diagonalSum += matrix[i, j];
                }
                if (diagonalSum.CompareTo(maxSum) > 0)
                {
                    maxSum = diagonalSum;
                }
            }
            return maxSum;
        }

    }
}

