using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class MatrixSolver
    {


        public static double[,] Multuply(double[,] A, double[,] B) {

            if (A.GetLength(1) != B.GetLength(0))
            {
                
                return null;
            }
            else
            {


                double[,] result = new double[A.GetLength(0), B.GetLength(1)];

                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        for (int k = 0; k < A.GetLength(0); k++)
                        {
                            result[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }

                return result;
            }
        }



        public static void printMatrix(double[,] matrix)  
        {
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}" + " "); 
                }
                Console.WriteLine();
            }
        }

        public static double[,] readMatrix(string path)
        {
            StreamReader file = new StreamReader(path);
            string s = file.ReadToEnd();
            file.Close();
            string[] line = s.Split('\n');
            string[] row = line[0].Split(' ');
            double[,] a = new double[line.Length, row.Length];
            int t = 0;
            for (int i = 0; i < line.Length; i++)
            {
                row = line[i].Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    t = Convert.ToInt32(row[j]);
                    a[i, j] = t;

                }

            }

            return a;
        }
    }
}
