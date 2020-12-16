using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Листы откуда будем брать данные для рандомных классов
            List<string> positions = new List<string>(new string[] { "Сисадмин", "Программист", "Руководитель",
                "Менеджер", "Бухгалтер", "Ассистент", "Уборщик" });
            List<string> employers = new List<string>(new string[] { "Власов", "Горьков", "Антонов", "Гиркин",
                "Серпанцев", "Венцев", "Арельцев", "Центристов", "Краснов", "Семенов"});
            List<Employee> employees = new List<Employee>();

            Random r = new Random();

            // Заполнение классов
            for (int i = 0; i < 5; i++)
            {
                int age = r.Next(18, 70);

                Employee e = new Employee(age, "Россия");
                for (int j = 0; j < 3; j++)
                {
                    // Рандомный стаж, должность и работодатель
                    int exp = r.Next(1, 30);
                    string pos = positions[r.Next(positions.Count)];
                    string emp = employers[r.Next(employers.Count)];
                    e.NewJob(emp, pos, exp);
                }
                employees.Add(e);
            }

            // Вывод данные рабочих в консоль
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }

            //Расскомментировать одну из строк для вывода ошибки возраста/национальности
            //Employee e2 = new Employee(17, "Россия");
            //Employee e3 = new Employee(18, "Эстония");

            Console.ReadLine();
        }
    }
}
