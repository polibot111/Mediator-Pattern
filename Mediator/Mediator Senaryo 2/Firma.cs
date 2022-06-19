using Mediator.Mediator_Senaryo_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_2
{
    public abstract class Firma
    {
        protected INakliye _nakliye;

        protected Firma(INakliye nakliye)
        {
            _nakliye = nakliye;
        }
        public abstract void NakliyeyeBasla();
    }
}
