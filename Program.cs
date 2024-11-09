using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriOdev9
/*Ackermann fonksiyonunun tanımını:
𝐴(0,𝑛)=𝑛+1
A(0,n)=n+1 — Yani m = 0 olduğunda, sonuç 
𝑛+1
n+1'dir.
𝐴(𝑚,0=𝐴(𝑚−1,1)
A(m,0)=A(m−1,1) — Yani m > 0 ve n = 0 olduğunda, fonksiyon bir adım geri gidip 
𝐴(𝑚−1,1)
A(m−1,1)'i hesaplar.
𝐴(𝑚,𝑛)=𝐴(𝑚−1,𝐴(𝑚,𝑛−1))
A(m,n)=A(m−1,A(m,n−1)) — Diğer durumlarda ise fonksiyon kendisini iç içe çağırarak, hem m'i hem de n'i değiştirir.*/

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 2;
            int b= 4;

            Console.WriteLine($"Ackermann({a}, {b}) = {Ackermann(a, b)}");
            Console.ReadLine();
        }

        // Ackermann fonksiyonunu öz yinelemeli olarak hesaplayan fonksiyon yapısı
        static int Ackermann(int a, int b)
        {
            if (a == 0)// Eğer a= 0 ise
            {
                return b + 1;
            }
            else if (a > 0 && b == 0)// Eğer a > 0 ve b = 0 ise
            {
                return Ackermann(a- 1, 1);
            }
            else // a> 0 ve b > 0
            {
                return Ackermann(a - 1, Ackermann(a, b - 1));
            }
        }
    }
}
