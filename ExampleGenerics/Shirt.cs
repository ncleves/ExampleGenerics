using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerics
{
    internal class Shirt : IGarment, IMakeable
    {
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
            
        }

        public void Assemble()
        {
            
        }

        public void Package()
        {

        }
    }
}
