using Mediator.Mediator_Senaryo_3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_3
{
    public abstract class Kisi
    {
        protected ITransfer _transfer;
        protected Kisi(ITransfer transfer)
        {
            _transfer = transfer;
        }
    }
}
