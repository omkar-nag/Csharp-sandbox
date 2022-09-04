using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateLibrary
{
    internal class Printer
    {
        public static void Print(PrintDelegate p)
        {
            p();
        }
    }
}
