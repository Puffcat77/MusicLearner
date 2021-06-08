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
            Notes = new List<Note>
            {
                new Note { Image = "Path to A note image", Sound = "Path to A note sound", Symbol = 'A' },
                new Note { Image = "Path to B note image", Sound = "Path to B note sound", Symbol = 'B' },
                new Note { Image = "Path to B note image", Sound = "Path to B note sound", Symbol = 'C' },
                new Note { Image = "Path to d note image", Sound = "Path to D note sound", Symbol = 'D' },
                new Note { Image = "Path to E note image", Sound = "Path to E note sound", Symbol = 'E' },
                new Note { Image = "Path to F note image", Sound = "Path to F note sound", Symbol = 'F' },
                new Note { Image = "Path to G note image", Sound = "Path to G note sound", Symbol = 'G' }
            };
            NotesDictionary = Notes.ToDictionary(key => key.Symbol, value => value);
        }
        private Dictionary<char, Note> NotesDictionary;
        public int Oktaves { get; set; }
        public List<Note> Notes;

        public Note this[int index]
        {
            get { return Notes[index]; }
            set { Notes[index] = value; }
        }

        public Note this[char symbol]
        {
            get { return NotesDictionary[symbol]; }
            set { NotesDictionary[symbol] = value; }
        }
    }
}
