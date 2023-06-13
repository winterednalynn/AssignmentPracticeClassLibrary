using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClassLibrary
{
    public class Plane:Air
    {
        //FIELDS ✅ 
        int _numberOfJets;

        //CONSTRUCTOR✅  
        public Plane(string color, int _numberOfJets) : base(color)
        {
            this._numberOfJets = _numberOfJets;

        }

        //OVERRIDE including Parent To string ✅ 
        public override string ToString()
        {
            return base.ToString() + $"-Number of jets: {_numberOfJets}";
        }
    }
}
