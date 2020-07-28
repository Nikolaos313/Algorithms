using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ClothesPlannerStrategy
    {
        //field
        private IClothesStrategy _shirtStrategy;
       
        //ExecuteMethod
        public void ExecuteStrategy(IClothesStrategy shirtStrategy)
        {
            _shirtStrategy = shirtStrategy;
        }
        public void PayMethods(int num)
        {
            var pay = _shirtStrategy.PayMethods(num);
            Console.WriteLine(pay);
        }
        public void OrderDetails(string Color, string size, string fabric)
        {
            _shirtStrategy.OrderDetails(Color, size, fabric);
        }
    }
}
