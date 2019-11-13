using System;

namespace schrikkeljaar_opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int jaar = 1900; jaar < 2000;)
            {
                jaar = jaar + 4;
                Console.WriteLine(jaar);
            }
            
        } 
    }
}
