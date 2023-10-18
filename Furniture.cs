using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    public class Furniture
    {
        public string Color;
        public string Material;
        public double Measurement;

        public Furniture(string color, string material, double measurement)
        {
            Color = color;
            Material = material;
            Measurement = measurement;
        }
    }
    
}
