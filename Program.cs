using Assignment.SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothesPlannerStrategy shirtStrategy = new ClothesPlannerStrategy();
            shirtStrategy.ExecuteStrategy(new Shirt());

            SynthticData db = new SynthticData();
            var newLista = new List<Shirt>(db.Shirts);
            
            //BubbleSort
            Console.WriteLine("Sorting By Size with Bubble Method");
            BubbleSort.SortShirtsSize(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }

            Console.WriteLine("Sorting By SizeDesc with Bubble Method");
            BubbleSort.SortShirtsSizeDesc(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }

            Console.WriteLine("Sorting By FabricDesc with Bubble Method");
            BubbleSort.SortShirtsFabricDesc(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }

            Console.WriteLine("Sorting By ColorDesc with Bubble Method");
            BubbleSort.SortShirtsColourDesc(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }

            //QuickSort
            Console.WriteLine("Sorting By Fabric with QuickSort Method");
            QuickSort.SortShirtsFabric(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }
           
            //BucketSort
            Console.WriteLine("Sorting By Color with Bucket Method");
            var sortedListBucketColor = BucketSort.SortShirtsColor(newLista);
            foreach (var item in sortedListBucketColor)
            {
                item.Output();
            }

            // Asc with Bubbles Method 3color-size-fabric
            Console.WriteLine("Sorting By 3Asc with Bubble Method");
            BubbleSort.SortShirts3Asc(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }

            // Desc with Bubbles Method 3color-size-fabric
            Console.WriteLine("Sorting By 3Desc with Bubble Method");
            BubbleSort.SortShirts3Desc(newLista);
            foreach (var item in newLista)
            {
                item.Output();
            }
           
            try
            {
                Console.WriteLine("If you want to pay with Credit Card please write 1");
                Console.WriteLine("If you want to pay with  Bank Transfer please write 2");
                Console.WriteLine("If you want to pay with Cash please write 3");
                int num = Convert.ToInt32(Console.ReadLine());
                shirtStrategy.PayMethods(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { };
           
        }
    }
}
