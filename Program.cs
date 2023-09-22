
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> intMatrix = new Matrix<int>(3, 3);
            intMatrix[0, 0] = 1;
            intMatrix[0, 1] = 2;
            intMatrix[0, 2] = 30;
            intMatrix[1, 0] = 4;
            intMatrix[1, 1] = 5;
            intMatrix[1, 2] = 6;
            intMatrix[2, 0] = 7;
            intMatrix[2, 1] = 8;
            intMatrix[2, 2] = 9;

            intMatrix.Display();

            Console.WriteLine($"Max sum of Diagonals: {intMatrix.MaxSumOfParallelDiagonals()}");
            Console.WriteLine($"Sum Non Negative Columns: {intMatrix.SumNonNegativeColumns()}");
        }
    }
}
