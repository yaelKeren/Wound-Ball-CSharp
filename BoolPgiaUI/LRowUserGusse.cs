using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BullsEyeLogic;

namespace BoolPgiaUI
{
    internal partial class LRowUserGusse : Label
    {
        private const int k_SequanceLen = 4;
        private Dictionary<Color, string> m_ColorValues = new Dictionary<Color, string>();
        private readonly BoardForm r_SendUserGuess; //point to the BoardForm(=> to the parent)

        internal LRowUserGusse(BoardForm i_SendUserGuess)
        {
            initializeComponent();
            r_SendUserGuess = i_SendUserGuess;
        }

        //on this click we want to change the color of the button
        //(remmber cant choose the same color in a guess)
        private void squareGuess_Click(object sender, EventArgs e)
        {
           ColorPalette colorPalette = new ColorPalette();
           DialogResult result = colorPalette.ShowDialog();
           Color buttonColor = ((Button)sender).BackColor;

           if (result == DialogResult.OK)
           {
               if (!m_ColorValues.ContainsKey(colorPalette.ChoosenColor))
               {
                   if (m_ColorValues.ContainsKey(buttonColor))
                   {
                        m_ColorValues.Remove(buttonColor);
                   }

                   m_ColorValues.Add(colorPalette.ChoosenColor, ((Button)sender).Name);
                   ((Button)sender).BackColor = colorPalette.ChoosenColor;
               }

                m_SendGuesse.Enabled = m_ColorValues.Count == k_SequanceLen; //can sumbmit his guess
           }
        }

        private void sendGuesse_Click(object sender, EventArgs e)
        {
            Enabled = false;
            List<Color> guesseColors = new List<Color>();
            bool playerWon;

            foreach(KeyValuePair<Color,string> color in m_ColorValues)
            {
                guesseColors.Add(color.Key);
            }

            List<LogicCalc.EFeedBackColor> feedBack = Manager.GetFeedBack(guesseColors,
                r_SendUserGuess.RandomColorSequence, out playerWon);
            paintFeedbackTextBoxs(feedBack);
            r_SendUserGuess.OnGuessClick(playerWon); //the method in the BoarForm
        }

        private void paintFeedbackTextBoxs(List<LogicCalc.EFeedBackColor> i_FeedBack)
        {
            Color feedBackColor = Color.Gray;
            int currentButton = 1;

            foreach (LogicCalc.EFeedBackColor color in i_FeedBack)
            {
                //paint the feed back texts boxs
                switch (color)
                {
                    case LogicCalc.EFeedBackColor.Pgia:
                        feedBackColor = Color.Yellow;
                        break;
                    case LogicCalc.EFeedBackColor.Bol:
                        feedBackColor = Color.Black;
                        break;
                }

                switch (currentButton)
                {
                    case 1:
                        m_FeedBack1.BackColor = feedBackColor;
                        break;
                    case 2:
                        m_FeedBack2.BackColor = feedBackColor;
                        break;
                    case 3:
                        m_FeedBack3.BackColor = feedBackColor;
                        break;
                    case 4:
                        m_FeedBack4.BackColor = feedBackColor;
                        break;
                }

                currentButton++;
            }
        }
    }
}