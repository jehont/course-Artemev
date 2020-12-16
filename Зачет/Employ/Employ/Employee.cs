using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    public class Employee : Object
    {
        // Свойства возраста, национальноти, список прошлых работ
        public int Age { get; set; }

        public string Residence { get; set; }

        public List<Job> PreviousJobs;

        // Свойство которое вычисляет общий стаж 
        public string TotalExperience
        {
            get
            {
                int total = 0;
                foreach (Job j in this.PreviousJobs)
                {
                    total += j.Experience;
                }
                return $"{Convert.ToString(total / 12)} лет {Convert.ToString(total % 12)} мес";
            }
        }

        // Основная функция добавления новой работы (работодатель, должность, сколько проработал - стаж)
        public void NewJob(string employer, string position, int experience)
        {
            this.PreviousJobs.Add(new Job(employer, position, experience));
        }

        // Конструктор рабочего
        public Employee(int age, string residence)
        {

            // не создавать класс если выходят эти ошибки
            if (age < 18)
            {
                throw new InsufficientAgeError("Возраст должен быть больше 18 лет");
            }

            else if (residence != "Россия")
            {
                throw new WrongResidenceError("Требуется национальность России");
            }

            else
            {
                this.Age = age;
                this.Residence = residence;
                this.PreviousJobs = new List<Job>();
            }
        }

        // Перевод списка прошлых работ в строку
        public string JobsList()
        {
            string list = "";
            foreach (Job j in this.PreviousJobs)
            {
                list = list + j.ToString() + "\n";
            }
            return list;
        }

        // Комбинация всей информации о рабочем в 1-у строку для вывода в консоль
        public override string ToString()
        {
            return $"Возраст: {this.Age}, Национальность: {this.Residence}, Общий стаж: {this.TotalExperience}\n"
            + "Предыдущие работы\n---\n" + JobsList();
        }
    }
}
