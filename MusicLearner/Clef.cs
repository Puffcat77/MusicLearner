using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearner
{
    public class Clef
    {
        public Clef()
        {
            Notes.Add('A', new Note { Image = "Path to A note image", Sound = "Path to A note sound" });
            Notes.Add('B', new Note { Image = "Path to B note image", Sound = "Path to B note sound" });
            Notes.Add('C', new Note { Image = "Path to C note image", Sound = "Path to C note sound" });
            Notes.Add('D', new Note { Image = "Path to d note image", Sound = "Path to D note sound" });
            Notes.Add('E', new Note { Image = "Path to E note image", Sound = "Path to E note sound" });
            Notes.Add('F', new Note { Image = "Path to F note image", Sound = "Path to F note sound" });
            Notes.Add('G', new Note { Image = "Path to G note image", Sound = "Path to G note sound" });
            
        }
        public int Oktaves { get; set; }
        public Dictionary<char, Note> Notes = new Dictionary<char, Note>();
    }
}
