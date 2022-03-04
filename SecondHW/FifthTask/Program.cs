using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Порядковый номер месяца: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Минимальная температура = ");
            double minimalTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Максимальная температура = ");
            double maximalTemp = Convert.ToDouble(Console.ReadLine());

            double avgTemp = (minimalTemp + maximalTemp) / 2.0;

            Console.WriteLine("Среднесуточная температура равна {0:f1}", avgTemp);

            bool isRain = avgTemp > 0 ? true : false;           

            Console.Write($"{monthNum} месяц это: ");

            switch (monthNum)
            {
                case 1:
                    Console.WriteLine("Январь"); break;
                case 2:
                    Console.WriteLine("Февраль"); break;
                case 3:
                    Console.WriteLine("Март"); break;
                case 4:
                    Console.WriteLine("Апрель"); break;
                case 5:
                    Console.WriteLine("Май"); break;
                case 6:
                    Console.WriteLine("Июнь"); break;
                case 7:
                    Console.WriteLine("Июль"); break;
                case 8:
                    Console.WriteLine("Август"); break;
                case 9:
                    Console.WriteLine("Сентябрь"); break;
                case 10:
                    Console.WriteLine("Октябрь"); break;
                case 11:
                    Console.WriteLine("Ноябрь"); break;
                case 12:
                    Console.WriteLine("Декабрь"); break;
                default:
                    Console.WriteLine("Месяца с таким номером не существует"); break;
            }

            if (isRain && (monthNum == 12 || monthNum == 1 || monthNum == 2))
            {
                Console.WriteLine("Дождливая зима");
            }

            Console.ReadKey();           
        }
    }
}
