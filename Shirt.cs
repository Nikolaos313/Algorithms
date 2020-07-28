using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Shirt : IClothesStrategy
    {
        public Color Color { get; set; }
        public Size Size { get; set; } 
        public Fabric Fabric  { get; set; }

        public Shirt()
        {}

        public Shirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
        public void OrderDetails(Color color, Size size, Fabric fabric)
        { 
            Color = color;
            Size = size;
            Fabric = fabric;
            Console.WriteLine("You are choose a product with color {0} , size {1} and fabric {2}", Color, size, fabric);
        }
        public void Output()
        {
            Console.WriteLine("{0, 12} | {1, 12} | {2, 12}", Color, Size, Fabric);
        }
        public string PayMethods(int num)
        {
            if (num == 1)
            {
                return "You choose the  Credit Card pay methods";
            }
            else if (num == 2)
            {
                return "You choose the  Bank Transfer pay methods";
            }
            else if (num == 3)
            {
                return "You choose the Cash pay methods";
            }
            return "You dont choose correct methods";
        }

        public void OrderDetails(string Color, string size, string fabric)
        {
            throw new NotImplementedException();
        }
    }
}
