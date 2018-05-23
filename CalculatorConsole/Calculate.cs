using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Calculate
    {

        public void sum(double n1, double n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public void sub(double n1, double n2)
        {
            Console.WriteLine(n1 - n2);
        }
        public void mul(double n1, double n2)
        {
            Console.WriteLine(n1 * n2);
        }
        public void div(double n1, double n2)
        {
            if (n2 != 0)
            {
                Console.WriteLine(n1 + n2);
            }
            else
            {
                Console.WriteLine("Sayı sıfıra bölünemez!");
            }
        }
    }
}
