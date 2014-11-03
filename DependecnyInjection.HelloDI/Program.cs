using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecnyInjection.HelloDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            Salutation salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }
}
