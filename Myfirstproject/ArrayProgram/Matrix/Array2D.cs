using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram.Matrix
{
    class Array2D
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
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+" "); 
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Array2D obj = new Array2D();
            Console.WriteLine("Enter elements of 2D array:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
        }
    }

    class Array2D1
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void RowWiseSum()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine($"Addition of {i} row is {sum}");
            }
        }
        public void ColumnWiseSum()
        {
            int sum = 0;
            for(int i=0;i<matrix.GetLength(1);i++)
            {
                sum = 0;
                for(int j=0;j<matrix.GetLength(0);j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine($"Addition of {i} column is {sum}");
            }
        }
        public int SumOfDiagonal()
        {
            int sum = 0;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    if(i==j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public int SumOfAntiDiagonal()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i+j)==matrix.GetLength(0)-1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            Array2D1 obj = new Array2D1();
            Console.WriteLine("Enter elements of 2D array:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            obj.RowWiseSum();
            obj.ColumnWiseSum();
            Console.WriteLine("Sum of diagonal is: "+obj.SumOfDiagonal());
            Console.WriteLine("Sum of Anti diagonal is: " + obj.SumOfAntiDiagonal());
        }
    }  
}
