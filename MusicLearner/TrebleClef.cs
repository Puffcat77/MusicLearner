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
            Notes['A'].Image = "Images\\Trebel\\AInTreble.png";
            Notes['B'].Image = "Images\\Trebel\\BInTreble.png";
            Notes['C'].Image = "Images\\Trebel\\CInTreble.png";
            Notes['D'].Image = "Images\\Trebel\\DInTreble.png";
            Notes['E'].Image = "Images\\Trebel\\EInTreble.png";
            Notes['F'].Image = "Images\\Trebel\\FInTreble.png";
            Notes['G'].Image = "Images\\Trebel\\GInTreble.png";
            Notes['A'].Sound = "";
            Notes['B'].Sound = "";
            Notes['C'].Sound = "";
            Notes['D'].Sound = "";
            Notes['E'].Sound = "";
            Notes['F'].Sound = "";
            Notes['G'].Sound = "";
            Oktaves = 4;
        }
    }
}
