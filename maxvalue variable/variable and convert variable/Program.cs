using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_and_convert_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // بسم الله الرحمن الرحيم

            // decimal لمتغير من نوع maxvalue لمعرفة

            decimal maxvalue = decimal.MaxValue; decimal minvalue = decimal.MinValue;
            Console.WriteLine("\ndecimal maxvalue is= {0}\n\ndecimal minvalue is= {1}", maxvalue, minvalue);
            Console.ReadKey();

            // يجب أن يخزن داخل متغير إنتيجر char لمتغير من نوع maxvalue لمعرفة

            int maxvar_char = char.MaxValue;
            Console.WriteLine("\nmaxvar char is= {0}", maxvar_char);
            Console.ReadKey();

        }
    }
}
