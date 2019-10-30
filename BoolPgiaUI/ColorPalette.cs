using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoolPgiaUI
{
    internal partial class ColorPalette : Form
    {
        private Color m_ChoosenColor;

        internal ColorPalette()
        {
            initializeComponent();
        }

        internal Color ChoosenColor
        {
            get { return m_ChoosenColor; }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            m_ChoosenColor = ((Button)sender).BackColor;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}