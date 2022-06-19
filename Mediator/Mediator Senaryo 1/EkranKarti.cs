using Mediator.Mediator_Senaryo_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_1
{
    public class EkranKarti: Birim
    {
        public EkranKarti(IAnakart anakart):base(anakart)
        {

        }

        public void GorselVer(string videoData)
        {
            string[] datas = videoData.Split(',');
            foreach (string item in datas)
            {
                Console.WriteLine($"Gelen görüntü : {item}");
            }
        }
    }
}
