using System;

namespace MusicLearner
{
    public class NoteEventArgs : EventArgs
    {
        public Note Note {get; set;}
        public bool IsNotValid { get; set; }
    }
}