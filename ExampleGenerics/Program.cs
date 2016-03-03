using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Hat cap = new Hat("rayon")
            {
                Size = "L", RetailPrice = 20.00m, WholeSalePrice = 5.00m
            };

            Shirt tshirt = new Shirt { Material = "cotton", Size = "L", RetailPrice = 30.00m, WholeSalePrice = 10.00m };
            MagicFactory.Produce(cap, tshirt);
            MagicFactory.Produce(tshirt, cap);
            Console.ReadKey();
        }
    }
}
