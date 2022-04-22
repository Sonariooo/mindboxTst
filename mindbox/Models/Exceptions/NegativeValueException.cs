using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox.Models
{
    public class NegativeValueException:Exception
    {
        public NegativeValueException() : base("Одно из входных значений равняется или меньше нуля.")
        {
        }

        public NegativeValueException(Exception innerException) : base("Одно из входных значений равняется или меньше нуля.", innerException)
        {
        }
    }
}
