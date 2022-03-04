using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Порядковый номер месяца: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

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
            
            Console.ReadKey();
        }
    }
}
