using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    // Ошибка возраста ( рабочий младше 18 лет )
    public class InsufficientAgeError : Exception
    {
        public InsufficientAgeError()
        {
        }

        public InsufficientAgeError(string message)
            : base(message)
        { }

        public InsufficientAgeError(string message, Exception inner)
            : base(message, inner) { }
    }
}
