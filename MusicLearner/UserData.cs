using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace MusicLearner
{
    public
        class UserData
    {
        public UserData()
        {
            this.TestDate = DateTime.Today;
        }
        public uint CorrectAnswers { get; set; }
        public uint Questions { get; set; }
        public DateTime TestDate { get; set; }
    }
}
