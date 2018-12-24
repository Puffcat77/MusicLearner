using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearner
{
    class TrebleClef: Clef
    {
        public TrebleClef()
        {
            Notes['A'].Image = "Theory\\Images\\TrebelNotes\\AInTreble";
            Notes['B'].Image = "Theory\\Images\\TrebelNotes\\BInTreble";
            Notes['C'].Image = "Theory\\Images\\TrebelNotes\\CInTreble";
            Notes['D'].Image = "Theory\\Images\\TrebelNotes\\DInTreble";
            Notes['E'].Image = "Theory\\Images\\TrebelNotes\\EInTreble";
            Notes['F'].Image = "Theory\\Images\\TrebelNotes\\FInTreble";
            Notes['G'].Image = "Theory\\Images\\TrebelNotes\\GInTreble";
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
