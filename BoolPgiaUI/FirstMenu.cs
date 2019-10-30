using System;
using System.Text;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    //this is Form class that is the first window(menu) in game
    internal partial class FirstMenu : Form
    {
        private const int k_MinNumOfChanges = 4;
        private const int k_MaxNumOfChanges = 10;
        private int m_NumOfChances = k_MinNumOfChanges;

        internal FirstMenu()
        {
            //this function we get as present
            initializeComponent();
        }

        //this the even when we clicked on the NumOfChancesButton
        private void numOfChancesButton_Click(object sender, EventArgs e)
        {
            m_NumOfChances++;
            if (m_NumOfChances > k_MaxNumOfChanges)
            {
                m_NumOfChances = k_MinNumOfChanges;
            }

            StringBuilder currentNumOfChances = new StringBuilder("Number of chances : ");
            currentNumOfChances.Append(m_NumOfChances.ToString());
            m_NumOfChancesButton.Text = currentNumOfChances.ToString();
        }

        //this the event when cilck the StartButton
        private void startButton_Click(object sender, EventArgs e)
        {
            //hide the firstMenu window
            Hide();
            //create a window with the number of chances the user asked
            new BoardForm(m_NumOfChances).Show();
        }
    }
}