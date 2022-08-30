using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Dummy : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispost() 메서드 호출");
        }
    }
}
