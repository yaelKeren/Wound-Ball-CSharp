using System;
using System.Collections.Generic;
using System.Drawing;

namespace BullsEyeLogic
{
    public static class LogicCalc
    {
        public enum EColorOptions
        {
            Fuchsia,
            Yellow,
            Maroon,
            White,
            Aqua,
            Lime,
            Red,
            Beige
        }

        public enum EFeedBackColor
        {
            Bol,
            Pgia
        }

        public static List<Color> GetSequence(int i_SequenceLen)
        {
            List<int> sequenceInt = getSequenceInt(i_SequenceLen);
            List<Color> sequence = new List<Color>();

            foreach (int colorInt in sequenceInt)
            {
                switch (colorInt)
                {
                    case 0:
                        sequence.Add(Color.Fuchsia);
                        break;
                    case 1:
                        sequence.Add(Color.Yellow);
                        break;
                    case 2:
                        sequence.Add(Color.Maroon);
                        break;
                    case 3:
                        sequence.Add(Color.White);
                        break;
                    case 4:
                        sequence.Add(Color.Aqua);
                        break;
                    case 5:
                        sequence.Add(Color.Lime);
                        break;
                    case 6:
                        sequence.Add(Color.Red);
                        break;
                    case 7:
                        sequence.Add(Color.Beige);
                        break;
                }
            }

            return sequence;
        }

        public static bool IsPlayerWon(List<EFeedBackColor> i_FeedBack, int i_SequenceLen)
        {
            bool won = true;

            if (i_FeedBack.Count == i_SequenceLen)
            {
                foreach (EFeedBackColor feedbackColor in i_FeedBack)
                {
                    if (feedbackColor.Equals(EFeedBackColor.Pgia))
                    {
                        won = false;
                        break;
                    }
                }
            }
            else
            {
                won = false;
            }

            return won;
        }

        private static List<int> getSequenceInt(int i_SequenceLen)
        {
            int currentSequenceLen = 0;
            List<int> sequence = new List<int>();
            Random randomObj = new Random();

            while (currentSequenceLen < i_SequenceLen)
            {
                bool isNumInSequence = false;
                int randomColorInt = randomObj.Next(0, Enum.GetNames(typeof(EColorOptions)).Length - 1);
                isNumInSequence = sequence.Contains(randomColorInt);

                if (!sequence.Contains(randomColorInt))
                {
                    sequence.Add(randomColorInt);
                    currentSequenceLen++;
                }
            }

            return sequence;
        }

        public static List<EFeedBackColor> CreateFeedback(List<Color> i_GuesseColors, 
            List<Color> i_ComputerSequence)
        {
            List<EFeedBackColor> feedback = new List<EFeedBackColor>();
           
            for (int i = 0; i < i_GuesseColors.Count; ++i)
            {
                if (i_GuesseColors[i].Equals(i_ComputerSequence[i]))
                {
                    feedback.Add(EFeedBackColor.Bol);
                }
                else if (i_ComputerSequence.Contains(i_GuesseColors[i]))
                {
                    feedback.Add(EFeedBackColor.Pgia);
                }
            }

            return feedback;
        }
    }
}