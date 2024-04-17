using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];
            int[,] array3 = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array1[i, j] = i + 1;
                    array2[i, j] = j + 1;
                    array3[i, j] = (i+1)*(j+1);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(array1[i,j] + "x" + array2[i,j] + "="+ array3[i,j]);
                }
                Console.WriteLine();
            }




        }
    }
}
