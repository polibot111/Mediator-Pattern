using Mediator.Mediator_Senaryo_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_3
{
    public class Alici : Kisi
    {
        public Alici(ITransfer transfer) : base(transfer)
        {
        }

        public void KonutParasiOde(int tutar)
        {
            Console.WriteLine("Alıcı : Ödeme yapılmıştır.");
            _transfer.ParaGonder(this, tutar);
        }
    }
}
