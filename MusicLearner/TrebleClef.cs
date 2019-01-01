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
            Notes['A'].Image = "Theory\\Images\\TrebelNotes\\AInTreble.png";
            Notes['B'].Image = "Theory\\Images\\TrebelNotes\\BInTreble.png";
            Notes['C'].Image = "Theory\\Images\\TrebelNotes\\CInTreble.png";
            Notes['D'].Image = "Theory\\Images\\TrebelNotes\\DInTreble.png";
            Notes['E'].Image = "Theory\\Images\\TrebelNotes\\EInTreble.png";
            Notes['F'].Image = "Theory\\Images\\TrebelNotes\\FInTreble.png";
            Notes['G'].Image = "Theory\\Images\\TrebelNotes\\GInTreble.png";
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
