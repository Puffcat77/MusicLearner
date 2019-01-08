using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearner
{
    public class Theory
    {
        public Theory()
        {
            char note = 'A';
            for (int i = 0; i < 7; i++)
            {
                noteImages.Add(note, new string[] { $@"Images\Bass\{note}InBass.png", $@"Images\BoardNotes\{note}OnTheBoard.png", $@"Images\Trebel\{note}InTreble.png" });
                note = (char)(note + 1);
            }
            //theory.Add("Staff", new TheoryComponent() {ComponentImage= "Theory\\Images\\Staff.png",ComponentText = "Theory\\Texts\\Staff.txt"});
            //theory.Add("TrebleClef", new TheoryComponent() { ComponentImage = "Theory\\Images\\TrebleClef.png", ComponentText = "Theory\\Texts\\TrebleClef.txt" });

        }

        //Dictionary<string, TheoryComponent> theory = new Dictionary<string, TheoryComponent>();
        Dictionary<char, string[]> noteImages = new Dictionary<char, string[]>();

        public string[] GetNoteImages(char note)
        {
            string[] paths = noteImages[note];
            return paths;
        }

    }
}
