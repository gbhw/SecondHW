using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Минимальная температура = ");
            double minimalTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Максимальная температура = ");
            double maximalTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Среднесуточная температура равна {0:f1}", (minimalTemp+maximalTemp)/2.0);
            Console.ReadKey();
        }
    }
}
