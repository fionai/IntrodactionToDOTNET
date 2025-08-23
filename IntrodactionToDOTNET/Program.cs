//#define STRING_OPERATIONS
#define DATA_TYPES
#define FACTORIAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrodactionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args) 
        {
#if STRING_OPERATIONS

            //Console.Write("\t\tHello, .NET\n");
            //Console.Write("Привет!");
            //Console.WriteLine("Line");
            Console.Write("Enter your name: ");
            string first_name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string last_name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));  //форматирование строк
            Console.WriteLine(first_name + " " + last_name + " " + age); //конкатенация строк
            Console.WriteLine($"{first_name} {last_name} {age}"); //интерполяция строк

#endif

#if DATA_TYPES
            sbyte sb = 0;
            Console.WriteLine($"{sb.GetType()} занимает {sizeof(sbyte)} байт памяти и принимает значение в диапазоне: {sbyte.MinValue} ... {sbyte.MaxValue}");
            byte b = 0;
            Console.WriteLine($"{b.GetType()} занимает {sizeof(byte)} байт памяти и принимает значение в диапазоне: {byte.MinValue} ... {byte.MaxValue}");
            short s = 0;
            Console.WriteLine($"{s.GetType()} занимает {sizeof(short)} байт памяти и принимает значение в диапазоне: {short.MinValue} ... {short.MaxValue}");
            ushort us = 0;
            Console.WriteLine($"{us.GetType()} занимает {sizeof(ushort)} байт памяти и принимает значение в диапазоне: {ushort.MinValue} ... {ushort.MaxValue}");
            int ii = 0;
            Console.WriteLine($"{ii.GetType()} занимает {sizeof(int)} байт памяти и принимает значение в диапазоне: {int.MinValue} ... {int.MaxValue}");
            uint ui = 0;
            Console.WriteLine($"{ui.GetType()} занимает {sizeof(uint)} байт памяти и принимает значение в диапазоне: {uint.MinValue} ... {uint.MaxValue}");
            long l = 0;
            Console.WriteLine($"{l.GetType()} занимает {sizeof(long)} байт памяти и принимает значение в диапазоне: {long.MinValue} ... {long.MaxValue}");
            ulong ul = 0;
            Console.WriteLine($"{ul.GetType()} занимает {sizeof(ulong)} байт памяти и принимает значение в диапазоне: {ulong.MinValue} ... {ulong.MaxValue}");

            float f = 0;
            Console.WriteLine($"\n{f.GetType()} занимает {sizeof(float)} байт памяти и принимает значение в диапазоне: {float.MinValue} ... {float.MaxValue}");
            double d = 0;
            Console.WriteLine($"{d.GetType()} занимает {sizeof(double)} байт памяти и принимает значение в диапазоне: {double.MinValue} ... {double.MaxValue}");
            decimal dc = 0;
            Console.WriteLine($"{dc.GetType()} занимает {sizeof(decimal)} байт памяти и принимает значение в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}");
#endif

#if FACTORIAL
            ulong fact = 1;
            Console.Write("\n\nFactorial\nEnter a number from 0 to 21: ");
            short n = Convert.ToInt16(Console.ReadLine());
            while (n < 0 || n > 21)
            {
                Console.Write("Enter a number from 0 to 21: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++) 
            {
                fact = fact * Convert.ToUInt64(i);
                Console.WriteLine($"{i} - {fact}");
            }
            Console.WriteLine($"Factorial of {n} is equal {fact}");
#endif
        }
    }
}
