using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
               
                
                }
                for (int f = 0; f < 24; f++)
                {
                repeat:
                    Console.WriteLine(f + " ");//ekrana f değerini yaz
                    System.Threading.Thread.Sleep(3600000);//1 saat bekle
                    if (f == 24)//eğer f 24 e eşitse f sayısını 0 yap ve repeat yerine git
                    {
                        f = 0;
                        goto repeat;
                    }
                }
          for (int i = 0; i < 60; i++)
                {
                tekrar:
                    Console.WriteLine(i + " ");//ekrana a değerini yaz
                    System.Threading.Thread.Sleep(60000);//1 dakika bekle
                    if (i == 60)
                    {
                        i = 0;
                        goto tekrar;
                    }
                 for (int a = 0; a < 60; a++)
                {
                basla:
                    Console.WriteLine(a);//ekrana a değerini yaz
                    System.Threading.Thread.Sleep(1000);//1 saniye bekle
                    if (a == 60)//eğer a 60 a eşitse a sayısını 0 yap ve basla yerine git
                    {
                        a = 0;
                        goto basla;
                    }
                }
            }  
            
            Console.ReadKey();

        }
    }
}
