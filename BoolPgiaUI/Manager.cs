using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using BullsEyeLogic;

namespace BoolPgiaUI
{
    internal static class Manager
    {
        private const int k_SequenceLen = 4;

        internal static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstMenu());
        }

        internal static List<LogicCalc.EFeedBackColor> GetFeedBack(List<Color> i_GuesseColors,
            List<Color> i_ComputerSequence, out bool o_Win)
        {
            List<LogicCalc.EFeedBackColor> feedBack = LogicCalc.CreateFeedback(i_GuesseColors,
                i_ComputerSequence);
            o_Win = LogicCalc.IsPlayerWon(feedBack, i_ComputerSequence.Count);

            return feedBack;
        }

        internal static List<Color> GetRandomColorSequence()
        {
            return LogicCalc.GetSequence(k_SequenceLen);
        }
    }
}
