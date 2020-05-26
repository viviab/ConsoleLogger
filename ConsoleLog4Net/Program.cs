using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLog4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Init();
            Bootstrap.Execute();
        }
    }
}
