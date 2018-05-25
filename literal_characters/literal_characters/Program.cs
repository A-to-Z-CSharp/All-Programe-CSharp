using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literal_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            // بسم الله الرحمن الرحيم
            ulong myinvar = 1000l;

            /*خاصة إدا كانت هناك علامة عشرية.float سواء كابتل أو سمول بدون مسافة بين قيمة المتغير من نوع f يجب وضع حرف 
            /*خاصة إدا كانت هناك علامة عشرية.decimal سواء كابتل أو سمول بدون مسافة بين قيمة المتغير من نوع m يجب وضع حرف 
            */

            float myflvar = 10215.56F;
            Double mydouvar = 5000.1;
            decimal mydecvar = 66666666666.6m;

            Console.WriteLine("\nmy int = {0} my double = {1} my decimal = {2}", myinvar,mydouvar,mydecvar);

            //ويمكن طباعة القيم السابقة بطريقة مختصرة وجميلة وفرتها شركة مايكروسوفت تسمى دالة الاستقراء الداخلي

            Console.WriteLine($"\n\nmy int = {myinvar} my double = {mydouvar} my decimal = {mydecvar}");
            Console.ReadKey();
         }
    }
}
