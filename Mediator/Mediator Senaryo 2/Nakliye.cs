using Mediator.Mediator_Senaryo_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_2
{
    public class Nakliye : INakliye
    {
        XFirma _xfirma;
        YFirma _yfirma;
        ZFirma _zfirma;
        int sayi = 0;
        public XFirma XFirma { set => _xfirma = value; }
        public YFirma YFirma { set => _yfirma = value; }
        public ZFirma ZFirma { set => _zfirma = value; }
        public void MaliDevret(Firma firma)
        {
            sayi++;
            Console.WriteLine(sayi.ToString());
            if (firma is XFirma)
            {
                Console.WriteLine("Eşyalar Sivas'ta tekrar nakledilmek üzere indirildi.\n");
                _yfirma.NakliyeyeBasla();
            }
            else if (firma is YFirma)
            {
                Console.WriteLine("Eşyalar Ankara'da tekrar nakledilmek üzere indirildi.\n");
                _zfirma.NakliyeyeBasla();
            }
            else
                Console.WriteLine("Eşyalar Edirne'ye vardı çok şükür...");
        }
    }
}
