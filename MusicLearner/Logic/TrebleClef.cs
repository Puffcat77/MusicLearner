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
            this['A'].Image = "Images\\Treble\\AInTreble.png";
            this['B'].Image = "Images\\Treble\\BInTreble.png";
            this['C'].Image = "Images\\Treble\\CInTreble.png";
            this['D'].Image = "Images\\Treble\\DInTreble.png";
            this['E'].Image = "Images\\Treble\\EInTreble.png";
            this['F'].Image = "Images\\Treble\\FInTreble.png";
            this['G'].Image = "Images\\Treble\\GInTreble.png";
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
