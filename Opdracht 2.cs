using System;

namespace opdracht_2._0
{
    class Program
    {
        static void Main(string[] args)

        {
            int prijs = 25000;
            int ans1;
            int ans2;
            int ans3;
            int ans4;
            Console.WriteLine("Goeiedag Ron Janssen hier kunt u aanpassingen aan de auto invoeren.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("wilt u metallic lak? 5% verhoging van de standaard prijs.");
            Console.WriteLine("1. ja");
            Console.WriteLine("2. nee");

            ans1 = Convert.ToInt32(Console.ReadLine());

            if (ans1 == 1)
            {
                prijs = prijs + 1250;
                Console.WriteLine("de kosten zijn nu: {0} ", prijs);
            }
            if (ans1 == 2)
            {
               
                Console.WriteLine("de kosten zijn nu: {0} ", prijs);
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("wilt u leren bekleding? 5% verhoging van de standaard prijs.");
            Console.WriteLine("1. ja");
            Console.WriteLine("2. nee");

            ans2 = Convert.ToInt32(Console.ReadLine());

            if (ans2 == 1)
            {
                prijs = prijs + 1250;
                Console.WriteLine("de kosten zijn nu: {0} ", prijs);
            }
            if (ans2 == 2)
            {

                Console.WriteLine("de kosten zijn nu: {0} ", prijs);
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("wilt u een automaat? 1000,- verhoging van de standaard prijs.");
            Console.WriteLine("1. ja");
            Console.WriteLine("2. nee");

            ans3 = Convert.ToInt32(Console.ReadLine());
            if (ans3 == 1)
            {
                prijs = prijs + 1000;
                Console.WriteLine("de kosten zijn nu: {0} ", prijs);
            }
            if (ans3 == 2)
            {

                Console.WriteLine("de kosten zijn nu: {0} ", prijs);
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("wat u moet betalen incl 21% btw {0} ", prijs * 1.21);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("wilt u betalen? ");
            Console.WriteLine("1. ja");
            Console.WriteLine("2. nee");

            ans4 = Convert.ToInt32(Console.ReadLine());
            if (ans4 == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("bedankt voor de aankoop!");
            }
            if (ans4 == 2)
            {
                Console.WriteLine("druk op een knop om het af te breken.");
            }
            






        }
    }
}
