using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerics
{
    internal class Garment<TObject> where TObject : IGarment, IDisposable
    {
        public TObject Article { get; set; }

        public void DoSomething(TObject article)
        {
            
        }
    }

    internal class Garment2
    {
        public IGarment Article { get; set; }

        public void DoSomething(IGarment article)
        {
            
        }
    }
}
