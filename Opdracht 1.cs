using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom Bij de BMI berekening");
            Console.WriteLine("Geprogameerd door Jasper Tempelman");

             Console.Write("Gewicht in kilogram: ");
            int kg;
            kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hoogte in centimers: ");
            int m;
            m = Convert.ToInt32(Console.ReadLine());
            
        
           double BMI = kg / ( ( m / 100.0 ) * ( m / 100.0 ) );
            Console.WriteLine("Je BMI is '{0}'", BMI);

        }
    }
}
