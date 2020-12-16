using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    // Ошибка нациольности (рабочий не из россии)
    public class WrongResidenceError : Exception
    {
        public WrongResidenceError()
        {
        }

        public WrongResidenceError(string message)
            : base(message)
        { }

        public WrongResidenceError(string message, Exception inner)
            : base(message, inner) { }
    }
}
