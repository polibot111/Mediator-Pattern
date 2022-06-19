using Mediator.Mediator_Senaryo_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_3
{
    public class Satici : Kisi
    {
        public Satici(ITransfer transfer) : base(transfer)
        {
        }

        public void ParaAl(int tutar)
        {
            Console.WriteLine($"Satıcı : {tutar} TL kadar konut bedeli alınmıştır.");
            _transfer.ParaGonder(this, tutar);
        }
    }
}
