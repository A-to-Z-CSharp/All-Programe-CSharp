using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ask_key_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // بسم الله الرحمن الرحيم
            int minvalue = char.MinValue;
            int maxvalue = char.MaxValue;
            Console.WriteLine("\nstore char between {0} and {1}", minvalue, maxvalue);

            // a small and A capital للحرف  ask key code لمعرفة 

            char chara = 'a';char charA = 'A';
            int intchara = chara;int intcharA = charA;
            Console.WriteLine("\nask key code litter (a) is {0} ask key code litter (A) is {1}",
            intchara,intcharA);

            // بهده الطريقة a small and A capital للحرف  ask key code ويمكن اختصار

            int intA = 'A'; int inta = 'a';
            Console.WriteLine("\nask key code litter (a) is {0} ask key code litter (A) is {1}",
            inta, intA);

            //a small = 97 and A capital = 65 للتأكيد أن  

            char convchara = Convert.ToChar(inta);
            char convcharA = Convert.ToChar(intA);
            Console.WriteLine("\nask key code number 97 is ({0}) ask key code number 65 is ({1})",
            convchara, convcharA);

            // للتأكيد ان الرقم 65 = الحرف اه كابتل وأن الرقم 97 يساوي الحرف اه سمول 

            int conva = Convert.ToInt16(convchara);
            int convA = Convert.ToInt16(convcharA);
            Console.WriteLine("\nask key code (a) is ({0}) ask key code (A) is ({1})", conva, convA);

            // string لتعريف متغير من نوع 

            string a = "ahmed";
            Console.WriteLine("\n{0}",a);




            Console.ReadKey();

        }
    }
}
