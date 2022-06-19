using Mediator.Mediator_Senaryo_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediator_Senaryo_1
{
    public class CPU : Birim
    {
        public CPU(IAnakart anakart):base(anakart)
        {

        }
        string _videoData;
        string _sesData;
        public string VideoData => _videoData;
        public string SesData => _sesData;

        public void DataIsle(string cdData)
        {
            string[] array = cdData.Split('*');
            _videoData = array[0];
            _sesData = array[1];
            _anakart.Degistir(this);
        }
    }
}
