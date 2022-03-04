using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string organization = "ООО \"Газпромнефть - Центр\"";
            string organizationIndividualNumber = "4703105075";
            string date = "02.03.22 18:40";
            string place = "АЗС 12031";
            string email = "urbexmax@yandex.ru";
            string divider = "------------------------------------------";
            string good = "АИ-95-К5/Бензин АИ-95";
            string litersCount = "19,51 X 51.25";
            string summ = "999.89";
            string nds = "166.65";

            Console.WriteLine($"{organization}\n");
            Console.WriteLine($"МЕСТО РАСЧЁТОВ {place}");
            Console.WriteLine($"ДАТА ВЫДАЧИ {date}");
            Console.WriteLine($"ЭЛ. АДР. ПОКУПАТЕЛЯ {email}\n");
            Console.WriteLine($"{divider}");
            Console.WriteLine($"{good}  {litersCount}");
            Console.WriteLine($"{divider}\n");
            Console.WriteLine($"ИНН ПОСТАВЩИКА {organizationIndividualNumber}");
            Console.WriteLine($"ИТОГ {summ}");
            Console.WriteLine($"в т.ч. налоги  СУММА НДС 20 {nds}");
            
            Console.ReadKey();
        }
    }
}
