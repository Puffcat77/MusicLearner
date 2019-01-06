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
        public int CorrectAnswers { get; set; }
        public int Questions { get; set; }
        public DateTime TestDate { get; set; }
        public int BestQueue { get; set; }
        public int Queue { get; set; }
    }
}
