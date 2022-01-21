using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Threading;
namespace Menu
{
    public class VoiceControls
    {
        public static void Controls(ref string[] str)
        {
            str = new string[] { "Stop", "Play", "Pause", "Resume", "Next", "Previous" ,"Exit"};
        }
        
    }
}
