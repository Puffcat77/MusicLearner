using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearner
{
    public class BassClef:Clef
    {
        public BassClef()
        {
            this['A'].Image = "Images\\Bass\\AInBass.png";
            this['B'].Image = "Images\\Bass\\BInBass.png";
            this['C'].Image = "Images\\Bass\\CInBass.png";
            this['D'].Image = "Images\\Bass\\DInBass.png";
            this['E'].Image = "Images\\Bass\\EInBass.png";
            this['F'].Image = "Images\\Bass\\FInBass.png";
            this['G'].Image = "Images\\Bass\\GInBass.png";
            this['A'].Sound = "";
            this['B'].Sound = "";
            this['C'].Sound = "";
            this['D'].Sound = "";
            this['E'].Sound = "";
            this['F'].Sound = "";
            this['G'].Sound = "";
            Oktaves = 3;
        }
    }
}
