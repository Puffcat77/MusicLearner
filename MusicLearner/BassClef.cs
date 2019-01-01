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
            Notes['A'].Image = "Theory\\Images\\BassNotes\\AInBass.png";
            Notes['B'].Image = "Theory\\Images\\BassNotes\\BInBass.png";
            Notes['C'].Image = "Theory\\Images\\BassNotes\\CInBass.png";
            Notes['D'].Image = "Theory\\Images\\BassNotes\\DInBass.png";
            Notes['E'].Image = "Theory\\Images\\BassNotes\\EInBass.png";
            Notes['F'].Image = "Theory\\Images\\BassNotes\\FInBass.png";
            Notes['G'].Image = "Theory\\Images\\BassNotes\\GInBass.png";
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
