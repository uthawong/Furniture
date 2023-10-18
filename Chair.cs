using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    public class Chair : Furniture
    {

        public Chair(string color, string material, double measurement) : base(color, material, measurement)
        {
        }
        public void getChair()
        {
            Console.WriteLine("The chair is made of " + Material + ".\nThe color is " + Color + ".\nThe measurement is " + Measurement + " m.");
        }
    }
}



