using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayProgram.Matrix
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 6 };
            jaggedArray[1] = new int[] { 5, 6 };
            jaggedArray[2] = new int[] { 7, 8, 9 };
            Console.WriteLine("Jagged array is:");
            Console.WriteLine();
            for(int i=0;i<jaggedArray.GetLength(0);i++)
            {
                for(int j = 0;j<jaggedArray[i].Length;j++)
                    Console.Write(jaggedArray[i][j]+" ");
                Console.WriteLine();
            }
        }
    }

    class JaggedPattern
    {
        public int[,] matrix = new int[4, 4];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void ExternallArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0 || j == 3 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void NPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || j == 0 || j == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void ZPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            JaggedPattern obj = new JaggedPattern();
            obj.Accept();
            obj.Display();
            obj.ExternallArray();
            obj.NPatternArray();
            obj.ZPatternArray();
        }
    }
}

