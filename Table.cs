using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    public class Table : Furniture
    {
        public int Legs;
        public Table(string color, string material, double measurement, int legs):base(color, material, measurement)
        {
            Legs = legs;
        }
    }
    public class Coffeetable : Table
    {
        public Coffeetable(string color, string material, double measurement, int legs) : base(color, material, measurement,legs)
        {
            
        }
        public void getCoffeetable()
        {
            Console.WriteLine("The coffee table has " + Legs +" legs, \nis made of "+ Material+".\nThe color is "+Color+".\nThe measurement is "+Measurement+" m.");
        }
       

    }
}
