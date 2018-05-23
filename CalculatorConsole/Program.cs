using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            double n1, n2;
            int q;

            while (true)
            {
                Console.Write("İlk sayıyı girin: ");
                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata - " + e);
                    continue;
                }
                Console.Write("İkinci sayıyı girin: ");
                try
                {
                    n2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata - " + e);
                    continue;
                }
                Console.Write("İşleminizi Seçin\n 1: Toplama\n 2: Çıkarma\n 3: Çarpma\n 4: Bölme\n Seçiminiz: ");
                try
                {
                    q = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata - " + e);
                    continue;
                }
                switch (q)
                {
                    case 1:
                        calculate.sum(n1, n2);
                        break;
                    case 2:
                        calculate.sub(n1, n2);
                        break;
                    case 3:
                        calculate.mul(n1, n2);
                        break;
                    case 4:
                        calculate.div(n1, n2);
                        break;
                    default:
                        Console.WriteLine("Uygun bir seçim yapmadınız.");
                        Console.Write("İlk sayıyı girin: ");
                        try
                        {
                            n1 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Hata - "+ e);
                            break;
                        }
                        Console.Write("İkinci sayıyı girin: ");
                        try
                        {
                            n2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Hata - " + e);
                            break;
                        }
                        Console.Write("İşleminizi Seçin\n 1: Toplama\n 2: Çıkarma\n 3: Çarpma\n 4: Bölme\n Seçiminiz: ");
                        try
                        {
                            q = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Hata - " + e);
                            break;
                        }
                        break;
                }

            }
        }

    }
}
