using System;

namespace Urban_Planner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("71 5th Ave")
            {
                Width = 1001.12,
                Height = 250,
                Stories = 5,
            };
            Building building2 = new Building("431 Heney Dr")
            {
                Width = 500,
                Height = 800.25,
                Stories = 100,
            };
            Console.WriteLine($"{building1.Address()}");
            Console.WriteLine($"Designed by {building1.Designer("Pish posh")}");
            Console.WriteLine($"Constructed on {building1.Construct()}");
            Console.WriteLine($"Owned by {building1.Purchase("Ryan McNair")}");
            Console.WriteLine($"{building1.Volume} cubic meters of space");
            Console.WriteLine();
            Console.WriteLine($"{building2.Address()}");
            Console.WriteLine($"Designed by {building2.Designer("A fish")}");
            Console.WriteLine($"Constructed on {building2.Construct()}");
            Console.WriteLine($"Owned by {building2.Purchase("A new owner")}");
            Console.WriteLine($"{building2.Volume} cubic meters of space");
            Console.WriteLine();
        }
    }
}
