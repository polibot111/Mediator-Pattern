using Mediator.Mediator_Senaryo_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_1
{
    public class SesKarti : Birim
    {
        public SesKarti(IAnakart anakart):base(anakart)
        {

        }

        public void SesVer(string sesData)
        {
            string[] datas = sesData.Split(',');
            foreach (string data in datas)
            {
                Console.WriteLine($"Gelen ses : {data}");
            }
        }
    }
}
