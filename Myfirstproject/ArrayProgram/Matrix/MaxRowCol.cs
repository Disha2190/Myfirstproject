using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram.Matrix
{
    class MaxRowCol
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void MaxRow()
        {
            int max = 0;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                max = 0;
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    if(matrix[i,j]>max)
                    {
                        max = matrix[i, j];
                    }
                }
                Console.WriteLine($"Maximun of Row[{i}]:{max}");
            }
        }
        public void MaxCol()
        {
            int max1 = 0;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                max1 = 0;
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    if(matrix[j,i]>max1)
                    {
                        max1 = matrix[j, i];
                    }
                }
                Console.WriteLine($"Maximun of column[{i}]:{max1}");
            }
        }
        static void Main(string[] args)
        {
            MaxRowCol obj = new MaxRowCol();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("The matrix is:");
            obj.Display();
            obj.MaxRow();
            obj.MaxCol();
        }
    }
}
