using System;

namespace Urban_Planner
{
    class Building
    {
        //Properties
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; } = DateTime.Now;
        private string _address { get; set; }
        private string _owner { get; set; }


        public int Stories { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Volume => Width * Height * (3 * Stories);

        public Building(string address)
        {
            _address = address;
        }
        public DateTime Construct() => _dateConstructed;

        public string Purchase(string newOwner)
        {
            _owner = newOwner;
            return _owner;
        }

        public string Designer(string newDesigner)
        {
            _designer = newDesigner;
            return _designer;
        }

        public string Address() => _address;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("71 5th Ave")
            {
                Width = 100,
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

        }
    }
}
