using System.Threading.Channels;

namespace hesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc;
            char secim;
            Console.WriteLine("1. sayı:");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
                       
            Console.Write(" + \n - \n * \n / \n seçiminiz(+,-,*,/)");
            secim = Convert.ToChar(Console.ReadLine());
            switch(secim)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Sonuç :{0}", sonuc);
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Sonuç :{0}", sonuc);
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Sonuç :{0}", sonuc);
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç :{0}", sonuc);
                    break;
            }
            

           
           




                                   
               
        }

    }
}
