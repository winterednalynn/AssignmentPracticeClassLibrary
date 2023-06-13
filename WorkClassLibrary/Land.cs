using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClassLibrary
{
    public class Land:Vehicle
    {
        //FIELDS ✅ 
        int _wheels;

        //CONSTRUCTOR ✅ 
        public Land(string color, int _wheels) : base(color)
        {
            this._wheels = _wheels;
        }

        //PROPERTY ✅  
        public int Wheels { get => _wheels; set => _wheels = value; }

        //OVERRIDE TO STRING , Including base (Vehicle) to string ✅ 
        public override string ToString()
        {
            return base.ToString() + $"-Number of Wheels: {_wheels}";
        }
    }
}
