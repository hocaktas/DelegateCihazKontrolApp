using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCihazKontrolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cihaz chz = new Cihaz();
            for (int i = 0; i < 7; i++)
            {
                chz.Kontrol();
            }
            Console.ReadKey();
        }
    }
}
