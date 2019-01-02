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
            Notes['A'].Image = "Images\\Bass\\AInBass.png";
            Notes['B'].Image = "Images\\Bass\\BInBass.png";
            Notes['C'].Image = "Images\\Bass\\CInBass.png";
            Notes['D'].Image = "Images\\Bass\\DInBass.png";
            Notes['E'].Image = "Images\\Bass\\EInBass.png";
            Notes['F'].Image = "Images\\Bass\\FInBass.png";
            Notes['G'].Image = "Images\\Bass\\GInBass.png";
            Notes['A'].Sound = "";
            Notes['B'].Sound = "";
            Notes['C'].Sound = "";
            Notes['D'].Sound = "";
            Notes['E'].Sound = "";
            Notes['F'].Sound = "";
            Notes['G'].Sound = "";
            Oktaves = 3;
        }
    }
}
