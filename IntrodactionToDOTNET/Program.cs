//#define STRING_OPERATIONS
#define DATA_TYPES
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
            Console.WriteLine(sizeof(bool));


            short var = 0;
            Console.WriteLine($"{var.GetType()} занимает {sizeof(short)} байт памяти и принимает значение в диапазоне: {short.MinValue} ... {short.MaxValue}");
#endif
        }
    }
}
