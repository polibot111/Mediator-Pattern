using Mediator.Mediator_Senaryo_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_3
{
    public class Emlakci : Kisi
    {
        public Emlakci(ITransfer transfer) : base(transfer)
        {
        }

        public void KomisyonAl(int tutar)
            => Console.WriteLine($"Emlakçı : {tutar} TL kadar komisyon alınmıştır.");
    }
}
