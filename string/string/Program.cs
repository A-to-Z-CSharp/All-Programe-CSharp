using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
             // بسم الله الرحمن الرحيم

             // إدا أردنا إظهار عبده بين علامتي تنصيص نقوم بوضع علامة \ قبل كل علامة تنصيص

            string mystring ="\nahmed \"abdo\"\n";
            Console.WriteLine("\a{0}", mystring);

            /* يمكن طباعة جميع الأحرف والأرقام والعلامات 
             * الخاصة داخل متغير سترينج باستثناء علامة التنصيص " وعلامة \ ولطباعتها يجب 
             * وضع قبلهما علامة \ لطباعتهما
             * هده كلها لها وظائف فمثلًا\f \t \v
             * وكل هده العلامات يجب أن توضع بين علامتي تنصيصtab تقوم بوضع \t
             */

            string mystring1 = "ahmed\v\f\t\tabdo ' ' : { } \0 < > : . , / / * ' & ^ % $ # \n\n! )( ( ) ' ; . , | - + ; . , / 2 6 ' ! @ \\  / \" ali";
            Console.WriteLine("\n{0}", mystring1);

            /*لطباعة مسار مثلأ لكثرة العلامات بداخله وتفادي ظهور أي أخطاء 
             * نقوم بوضع علامة @ قبل علامة التنصيص ويمكن تقسيمه على سطرين بدون ظهور علامة خطأ 
             */

            string bath = @"F:\خاص\برمجة السي شارب

\دورات\فيديو";
            Console.WriteLine("\n{0}", bath);

            // كيفية الجمع بين متغيرين سترينج

            string a = "a"; string b = "b";
            string c = a + b;
            Console.WriteLine("\n{0}",c);











            Console.ReadKey();

        }
    }
}
