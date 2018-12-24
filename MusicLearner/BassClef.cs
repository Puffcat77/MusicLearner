using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearner
{
    class BassClef:Clef
    {
        public BassClef()
        {
            Notes['A'].Image = "Theory\\Images\\BassNotes\\AInBass";
            Notes['B'].Image = "Theory\\Images\\BassNotes\\BInBass";
            Notes['C'].Image = "Theory\\Images\\BassNotes\\CInBass";
            Notes['D'].Image = "Theory\\Images\\BassNotes\\DInBass";
            Notes['E'].Image = "Theory\\Images\\BassNotes\\EInBass";
            Notes['F'].Image = "Theory\\Images\\BassNotes\\FInBass";
            Notes['G'].Image = "Theory\\Images\\BassNotes\\GInBass";
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
