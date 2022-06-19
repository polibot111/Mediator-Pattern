using Mediator.Mediator_Senaryo_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_2
{

    public class YFirma : Firma
    {
        public YFirma(INakliye nakliye) : base(nakliye)
        {
        }
        public override void NakliyeyeBasla()
        {
            Console.WriteLine("Sivas'tan eşyalar yüklendi.");
            _nakliye.MaliDevret(this);
        }
    }

}
