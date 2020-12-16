using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    public class Job : Object
    {
        // Свойства работодателя, должности и стажа
        public string Employer { get; set; }

        public string Position { get; set; }

        public int Experience { get; set; }

        // Конструктор новой работы
        public Job(string employer, string position, int experience)
        {
            this.Employer = employer;
            this.Position = position;
            this.Experience = experience;
        }

        // Репрезентация работы в строке
        public override string ToString()
        {
            return $"Работодатель: {this.Employer}, Должность: {this.Position}, Стаж: {this.Experience} мес";
        }
    }
}
