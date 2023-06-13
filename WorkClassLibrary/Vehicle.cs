using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClassLibrary
{
    public class Vehicle
    {
        //FIELDS ✅ 
        string _color;

        //CONSTRUCTOR ✅ 
        public Vehicle(string color)
        {
            Color = color;
        }
        //PROPERTY ✅ 
        public string Color { get => _color; set => _color = value; }

        //OVERRIDE TOSTRING ✅ 
        public override string ToString()
        {
            return $"{this.GetType().Name} - {_color}";
        }
    }
}
