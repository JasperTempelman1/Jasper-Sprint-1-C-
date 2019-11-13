using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] taal = { "De huidige maand is April.", "Der aktuelle Monat ist April.", "The current month is April", "Le mois en cours est avril.", "El mes actual es abril.", " The current month is April." };

        Console.WriteLine("1 = Nederlands\n2 = Duits\n3 = Engels\n4 = Frans\n5 = Spaans\n6 = mijn taal ");

        Console.WriteLine("type num: ");
        int num = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine(taal[num-=1]);
        }
    }
}
