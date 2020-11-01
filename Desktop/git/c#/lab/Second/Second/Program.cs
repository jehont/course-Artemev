using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество дней: ");
            string days = Console.ReadLine();
            int years = Convert.ToInt32(days) / 365 ;
            int month = (Convert.ToInt32(days) % 365) / 30;
            Console.WriteLine(days + " Дней  = " + years + " лет(года) и " + month + " мес.");
        }
    }
}
