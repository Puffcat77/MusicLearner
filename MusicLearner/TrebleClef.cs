using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearner
{
    public class TrebleClef: Clef
    {
        public TrebleClef()
        {
            this['A'].Image = "Images\\Trebel\\AInTreble.png";
            this['B'].Image = "Images\\Trebel\\BInTreble.png";
            this['C'].Image = "Images\\Trebel\\CInTreble.png";
            this['D'].Image = "Images\\Trebel\\DInTreble.png";
            this['E'].Image = "Images\\Trebel\\EInTreble.png";
            this['F'].Image = "Images\\Trebel\\FInTreble.png";
            this['G'].Image = "Images\\Trebel\\GInTreble.png";
            this['A'].Sound = "";
            this['B'].Sound = "";
            this['C'].Sound = "";
            this['D'].Sound = "";
            this['E'].Sound = "";
            this['F'].Sound = "";
            this['G'].Sound = "";
            Oktaves = 4;
        }
    }
}
