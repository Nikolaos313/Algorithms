using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public interface IClothesStrategy
    {
        //fields
       Color Color { get; set; }
       Size Size { get; set; }
       Fabric Fabric { get; set; }

        //Behavior
       string PayMethods(int num);
       void OrderDetails(string Color, string size, string fabric);
    }
}
