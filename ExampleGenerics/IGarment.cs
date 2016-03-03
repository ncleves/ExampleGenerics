using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerics
{
    interface IGarment : IMakeable
    {
        string Material { get; set; }

        string HasButtons { get; set; }

        decimal RetailPrice { get; set; }

        decimal WholeSalePrice { get; set; }

        string Size { get; set; }

        bool SuitableForSummer();

        bool BusinessCasual();

        decimal GetMargin();
    }

}
