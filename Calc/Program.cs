using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TO EXIT ENTER q OR Q\n\nEnter a 2-variables expression:");
            string expr;            //строка - выражение
            string[] simbs;         //массив операндов в выражении
            double res;

            expr = Console.ReadLine();
            while (expr != "q" &&  expr != "Q")
            {
                if (expr.IndexOf('+') != -1)
                {
                    simbs = expr.Split('+');
                    res = Convert.ToDouble(simbs[0]) + Convert.ToDouble(simbs[1]);
                    Console.WriteLine($"{simbs[0]} + {simbs[1]} = {res}");
                }
                else if (expr.IndexOf('-') != -1)
                {
                    simbs = expr.Split('-');
                    res = Convert.ToDouble(simbs[0]) - Convert.ToDouble(simbs[1]);
                    Console.WriteLine($"{simbs[0]} - {simbs[1]} = {res}");
                }
                else if (expr.IndexOf('*') != -1)
                {
                    simbs = expr.Split('*');
                    res = Convert.ToDouble(simbs[0]) * Convert.ToDouble(simbs[1]);
                    Console.WriteLine($"{simbs[0]} * {simbs[1]} = {res}");
                }
                else if (expr.IndexOf('/') != -1)
                {
                    simbs = expr.Split('/');
                    res = Convert.ToDouble(simbs[0]) / Convert.ToDouble(simbs[1]);
                    Console.WriteLine($"{simbs[0]} / {simbs[1]} = {res}");
                }


                expr = Console.ReadLine();
            }
        }
    }
}
