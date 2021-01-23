using System;
using System.Collections.Generic;
using System.Text;

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
}
