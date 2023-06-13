using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClassLibrary
{
    public class Air:Vehicle
    {
        //AIR CLASS ; Takes no additional information ✅ 
        public Air(string color) : base(color)
        {
        }

        public override string ToString()
        {
            return base.ToString(); // THE TO STRING FROM BASE (VEHICLE) 
        }
    }
}
