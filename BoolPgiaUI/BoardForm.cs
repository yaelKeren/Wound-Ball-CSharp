using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    //this is Form class is the game window
    internal partial class BoardForm : Form, ISendUserGuess
    {
        private int m_CurrentNumOfGuess = 0;
        private readonly int r_MaxNumOfGuess;
        private readonly List<Color> r_RandomColorSequence;

        internal BoardForm(int i_NumberOfGusses)
        {
            initializeComponent();
            r_MaxNumOfGuess = i_NumberOfGusses;
            r_RandomColorSequence = Manager.GetRandomColorSequence();
            createGuessesTable();
            updateWindowSize();
        }

        internal List<Color> RandomColorSequence
        {
            get { return r_RandomColorSequence; }
        }

        private void updateWindowSize()
        {
            //update window size
            MinimumSize = new Size(Width, Height);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void createGuessesTable()
        {
            //we add by i_NumberOfGusses an obj(LRowUserGusse) that display a row on the game board
            for (int i = 0; i < r_MaxNumOfGuess; i++)
            {
                //lisener for Row user guess (if the SendUserGusse -->> button click)
                LRowUserGusse lRowUserGusse = new LRowUserGusse(this);
                //allowed cilcks only on the first row on board
                lRowUserGusse.Enabled = i == 0;
                m_UserGuessesRows.Controls.Add(lRowUserGusse);
            }

            m_UserGuessesRows.AutoSize = true;
            //display each flowPanel items in new line
            m_UserGuessesRows.FlowDirection = FlowDirection.TopDown;
        }

        //this method check if the user win the game/he has no guess
        public void OnGuessClick(bool i_PlayerWon)
        {
            m_CurrentNumOfGuess++;
            if (i_PlayerWon || m_CurrentNumOfGuess.Equals(r_MaxNumOfGuess))
            {
                for (int i = 0; i < r_RandomColorSequence.Count; i++)
                {
                    paintTextBox(i);
                }
            }
            else
            {
                //Releases the next line of guess
                m_UserGuessesRows.Controls[m_CurrentNumOfGuess].Enabled = true;
            }
        }

        private void paintTextBox(int i_IndexInSequence)
        {
            //paint the randomSequence
            switch (i_IndexInSequence)
            {
                case 0:
                    m_TextBox0.BackColor = r_RandomColorSequence[i_IndexInSequence];
                    break;
                case 1:
                    m_TextBox1.BackColor = r_RandomColorSequence[i_IndexInSequence];
                    break;
                case 2:
                    m_TextBox2.BackColor = r_RandomColorSequence[i_IndexInSequence];
                    break;
                case 3:
                    m_TextBox3.BackColor = r_RandomColorSequence[i_IndexInSequence];
                    break;
            }
        }
    }
}