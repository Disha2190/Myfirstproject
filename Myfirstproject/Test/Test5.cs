using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    //2D Array
    class AcceptData
    {
        int[,] matrix = new int[3, 4];
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
            AcceptData obj = new AcceptData();
            Console.WriteLine("Enter matrix elements:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
        }
    }

    class FixedRows
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] =new int[] {1,2,3,4};
            matrix[1] = new int[] { 1, 2 };
            matrix[2] = new int[] { 1, 2, 3 };
            Console.WriteLine("The Matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class MaxRow  //Maximun number in Row
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j = 0;j<matrix.GetLength(1);j++)
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
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void Maxrow()
        {
            int max = 0;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                max = 0;
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    if (matrix[i, j] > 0)
                        max = matrix[i, j];
                }
                Console.WriteLine($"Maximum of row {i}: {max}");
            }
        }
        static void Main(string[] args)
        {
            MaxRow obj = new MaxRow();
            Console.WriteLine("Enter the elements of matrix:");
            obj.Accept();
            Console.WriteLine("The matrix is:");
            obj.Display();
            obj.Maxrow();
        }
    }
    class MaxCol  // Maximum number in column
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
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void Maxcol()
        {
            int max1 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                max1 = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] > max1)
                    {
                        max1 = matrix[j, i];
                    }
                }
                Console.WriteLine($"Maximun of column[{i}]:{max1}");
            }
        }
        static void Main(string[] args)
        {
            MaxCol obj = new MaxCol();
            Console.WriteLine("Enter the elements of matrix:");
            obj.Accept();
            Console.WriteLine("The matrix is:");
            obj.Display();
            obj.Maxcol();
        }
    }

    class Pattern
    {
        int[,] matrix = new int[4, 4];
        public void Accept()
        {
            for(int i = 0;i < matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
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
        public void Patt()
        {
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    if(i==0 || j==0 || i==3 ||j==3)
                        Console.Write(matrix[i,j]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Pattern obj = new Pattern();
            Console.WriteLine("Enter matrix elements:");
            obj.Accept();
            Console.WriteLine("The matrix is:");
            obj.Display();
            obj.Patt();
        }
    }

    class SparseMatrix
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
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
        public void Check()
        {
            int cnt = 0,flag=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                flag++;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                        cnt++;
                }
            }
            if(cnt>flag/2)
                Console.WriteLine("Sparse");
           else
                Console.WriteLine("Not Sparse");
        }
        static void Main(string[] args)
        {
            SparseMatrix obj = new SparseMatrix();
            Console.WriteLine("Enter matrix elements:");
            obj.Accept();
            Console.WriteLine("The Matrix is:");
            obj.Display();
            obj.Check();
        }
    }
    class TransposeMatrix
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
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

        public void Transpose()
        {
            int[,] matrix1 = new int[3, 3];
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    matrix1[i, j] = matrix[j, i];
                }
            }
            Console.WriteLine("Transpose matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix1[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            TransposeMatrix obj = new TransposeMatrix();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("Th matrix is:");
            obj.Display();
            obj.Transpose();
        }
    }
    class SubtractMatrix
    {
        int[,] matrix = new int[3, 3];

        public void Subtract()
        {
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            Console.WriteLine("Enter first matrix:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The first matrix is:");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEnter second matrix:");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The second matrix is:");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            Console.WriteLine("\nSubtraction of two matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            SubtractMatrix  obj = new SubtractMatrix();
            obj.Subtract();
        }
    }
    class MatrixSum
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
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine($"Addition of {i} column is {sum}");
            }
        }
        static void Main(string[] args)
        {
            MatrixSum obj = new MatrixSum();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            obj.RowWiseSum();
            obj.ColumnWiseSum();
        }
    }
    class MatrixDiagSum
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
        public void DiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i==j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Matrix Diagonal sum is: "+sum);
        }
        static void Main(string[] args)
        {
            MatrixDiagSum obj = new MatrixDiagSum();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            obj.DiagonalSum();
        }
    }
    class Average
    {
        int[,] matrix = new int[4, 4];
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
        public void AvgInnerEle()
        {
            int sum = 0,cnt=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != 0 || j != 0||i!=3||j!=3)
                    {
                        sum += matrix[i, j];
                        cnt++;
                    }
                }
            }
            int Avg = sum /cnt ;
            Console.WriteLine("Average of inner most element of matrix is: "+Avg);
        }
        static void Main(string[] args)
        {

            Average obj = new Average();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            obj.AvgInnerEle();
        }
    }
    class UpperTriangularMatrix
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
        public bool IsUpperTriangular()
        {
            bool upperTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            upperTriangular = false;
                            break;
                        }

                    }
                }
            }
            return upperTriangular;
        }

        static void Main(string[] args)
        {
            UpperTriangularMatrix obj = new UpperTriangularMatrix();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            if (obj.IsUpperTriangular())
                Console.WriteLine("Given Matrix is upper Triangular Matrix");
            else
                Console.WriteLine("Not upper Triangular Matrix");
        }

    }
    class LowerTriangularMatrix
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
        public void LowerTriangular()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of Lower Triangulat matrix is: "+sum);
        }
        static void Main(string[] args)
        {
            LowerTriangularMatrix obj = new LowerTriangularMatrix();
            Console.WriteLine("Enter elements of matrix:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            obj.LowerTriangular();
        }
    }
}
    
