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
            theory.Add("Staff", new TheoryComponent() {ComponentImage= "Theory\\Images\\Staff.png",ComponentText = "Theory\\Texts\\Staff.txt"});
            theory.Add("TrebleClef", new TheoryComponent() { ComponentImage = "Theory\\Images\\TrebleClef.png", ComponentText = "Theory\\Texts\\TrebleClef.txt" });

        }

        Dictionary<string, TheoryComponent> theory = new Dictionary<string, TheoryComponent>();


    }
}
