using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerics
{
    internal static class MagicFactory
    {
        internal static TProduct Produce<TProduct, TOther>(TProduct raw, TOther other) 
            where TProduct : IMakeable, new()
            where TOther : class, IGarment
        {
            TProduct product = default(TProduct);

            TProduct product2 = new TProduct();

            raw.Prepare();
            raw.Assemble();
            raw.Package();
            return product;
        } 
    }
}
