using Mediator.Mediator_Senaryo_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_3
{
    public class Transfer : ITransfer
    {
        Alici alici;
        Emlakci emlakci;
        Satici satici;

        public Alici Alici { set => alici = value; }
        public Emlakci Emlakci { set => emlakci = value; }
        public Satici Satici { set => satici = value; }

        public void ParaGonder(Kisi kisi, int tutar)
        {
            if (kisi is Alici && tutar > 100000)
                satici.ParaAl(tutar);
            else if (kisi is Alici && tutar <= 100000)
            {
                emlakci.KomisyonAl(tutar * 10 / 100);
                satici.ParaAl(tutar);
            }
            else if (kisi is Satici && tutar > 100000)
                emlakci.KomisyonAl(tutar * 3 / 100);
        }
    }
}
