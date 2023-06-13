using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClassLibrary
{
    public class Helicopter:Air
    {
        // FIELDS ✅ 
        int _numberOfPropellers;

        //CONSTRUCTORS✅
        public Helicopter(string color, int _numberOfPropellers) : base(color)
        {
            this._numberOfPropellers = _numberOfPropellers;
        }
        // OVERRIDE TO STRING ✅
        public override string ToString()
        {
            return base.ToString() + $"-Number of Propellers: {_numberOfPropellers}";
        }

    }
}
