using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace MusicLearner
{
    public class UserProgress
    {
        public uint CorrectAnswers { get; set; }
        public uint Questions { get; set; }
        public DateTime TestDate { get; set; }
        public uint BestQueue { get; set; }
        public uint Queue { get; set; }
    }
}
