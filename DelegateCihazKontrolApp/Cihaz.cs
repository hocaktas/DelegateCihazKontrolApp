using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCihazKontrolApp
{
    class Cihaz
    {
        private delegate void TemsilcimHandler();
        TemsilcimHandler faaliyet;
        public Cihaz()
        {
            faaliyet = new TemsilcimHandler(Ac);
                }
        private void Ac()
        {

            Console.WriteLine("cihaz açıldı");
            faaliyet = Kapat;
        }
        private void Kapat()
        { Console.WriteLine("cihaz kapandı");
            faaliyet = Ac;
        }
        public void Kontrol()
        { faaliyet(); }
    }
}
