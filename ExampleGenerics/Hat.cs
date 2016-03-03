using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerics
{
    internal class Hat : IGarment, IMakeable
    {
        public Hat(string material) : this()
        {
            Material = material;
        }

        public Hat()
        {
            
        }

        public string Material { get; set; }

        public string HasButtons { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal WholeSalePrice { get; set; }

        public string Size { get; set; }

        public bool SuitableForSummer()
        {
            throw new NotImplementedException();
        }

        public bool BusinessCasual()
        {
            throw new NotImplementedException();
        }

        public decimal GetMargin()
        {
            throw new NotImplementedException();
        }

        public void Prepare()
        {
            Console.WriteLine("You've prepared a hat!");
        }

        public void Assemble()
        {
            Console.WriteLine("Your hat has been assembled!");
        }

        public void Package()
        {
            Console.WriteLine("We've packaged the hat!");
        }
    }
}
