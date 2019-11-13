using System;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {   // Alles wat gebruikt moet worden staat hieronder op een rij.
            int Swis;
            int Sschei;
            int Snatu;

            // Hier worden de punten ingevoerd voor wiskunde en word de input omgezet naar een int.
            Console.WriteLine("Hoeveel punten zijn er bij wiskunde gehaald: ");
            Swis = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(500);

            // Hier worden de punten ingevoerd voor scheikunde en word de input omgezet naar een int.
            Console.WriteLine("Hoeveel punten zijn er bij scheikunde gehaald: ");
            Sschei = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(500);

            // Hier worden de punten ingevoerd voor Natuurkunde en word de input omgezet naar een int.
            Console.WriteLine("Hoeveel punten zijn er bij Natuurkunde gehaald: ");
            Snatu = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);

            // Int totaal berekent de totale score die gehaald is.
            int Totaal = Swis + Sschei + Snatu;

            // Hier word bepaalt of hij/zij examen mag doen.
            if (Swis < 60 || Sschei < 39 || Snatu < 39)
            {
                Console.WriteLine("De leerling mag niet door naar het examen");
            }
            else if (Swis == 0 || Sschei == 0 || Snatu == 0)
            {
                Console.WriteLine("De leerling mag niet door naar het examen");
            }
            else if (Swis >= 60 && Sschei >= 60 && Snatu < 60)
            {
                Console.WriteLine("De leerling mag door naar het examen");
            }
            else if (Swis >= 60 && Sschei < 60 && Snatu >= 60)
            {
                Console.WriteLine("De leerling mag door naar het examen");
            }
            else if (Swis >= 60 && Sschei < 60 && Snatu < 60)
            {
                Console.WriteLine("De leerling mag niet door naar het examen");
            }
            else if (Totaal >= 180 && Swis >= 60)
            {
                Console.WriteLine("De leerling mag door naar het examen");
            }
            else if (Swis < 60)
            {
                Console.WriteLine("De leerling mag niet door naar het examen.");
            }
        }
    }
}
        
    

