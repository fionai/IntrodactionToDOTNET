//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if ARRAYS_1
            Console.WriteLine("Arrays");
            Console.Write("Enter array size: ");
            int n = 5; // Convert.ToInt32( Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Array size: {arr.Length}");
            Console.WriteLine($"Количество измерений: {arr.Rank}");
            Console.WriteLine($"Array size: {arr.GetLength(0)}");

            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            double average = 0;
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
                average += arr[i];
            }
            average /= arr.Length;
            Console.WriteLine($"sum = {average * arr.Length}, average = {average}, min = {min}, max = {max}");
            Console.WriteLine($"sum = {arr.Sum()}, average = {arr.Average()}, min = {arr.Min()}, max = {arr.Max()}");

#endif

#if ARRAYS_2
            Console.Write("Enter num of strings: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num of cols: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] i_arr_2 = new int[rows, cols];
            Random rand = new Random(0);
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = rand.Next(100);
                }
            }
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"sum = {i_arr_2.Cast<int>().Sum()}, average = {i_arr_2.Cast<int>().Average()}, min = {i_arr_2.Cast<int>().Min()}, max = {i_arr_2.Cast<int>().Max()}");     
#endif


#if JAGGED_ARRAYS
            int[][] arr = new int[][]
            {
                new int[]{ 3, 5, 8},
                new int[]{ 13, 21},
                new int[]{ 34, 55, 89},
                new int[]{ 144, 233}
            };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
#endif

        }
    }
}
