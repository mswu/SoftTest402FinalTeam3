using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTest402FinalTeam3
{
    class TedNPadConstant
    {
        public int TedEditWindow = 0x3FC;

        public const int WAIT_FOR_INPUT_IDLE = 1000;
        public const int THREAD_SLEEP = 1000;
        public const int WAIT_FOR_EXIT = 1000;
        public const int WAIT_TIME = 500;

        public enum MainMenu : int
        {
            File = 0,
            Edit = 1,
            Search = 2,
            Tools = 3,
            Facourites = 4,
            Clips = 5,
            Options = 6,
            Help = 7
        }
        
        /// <summary>
        ///  The index of the Edit Submenu labels
        /// </summary>
        public enum EditSubMenu : int
        {
            Undo = 0,
            Redo = 1,
            Cut = 3,
            Copy = 4,
            Paste = 5,
            Swap = 6,
            Insert = 8,
            GoTo = 10,
            SelectWord = 11,
            SelectLine = 12,
            SelectParagraph = 13,
            SelectAll = 14,
            DeleteLine = 16,
            SmartReturn = 22

        }

        public enum EditInsertMenu : int
        {
            TimeDate = 6,
            Date = 10
        }
    }
}
