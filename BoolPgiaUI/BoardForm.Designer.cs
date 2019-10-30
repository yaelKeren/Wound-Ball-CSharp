using System.ComponentModel;

namespace BoolPgiaUI
{
    internal partial class BoardForm
    {
        private IContainer m_Components = null;
        private System.Windows.Forms.TextBox m_TextBox2;
        private System.Windows.Forms.TextBox m_TextBox3;
        private System.Windows.Forms.TextBox m_TextBox1;
        private System.Windows.Forms.TextBox m_TextBox0;
        private System.Windows.Forms.ColorDialog m_ColorDialog1;
        private System.Windows.Forms.FlowLayoutPanel m_UserGuessesRows;

        protected override void Dispose(bool i_Disposing)
        {
            if (i_Disposing && (m_Components != null))
            {
                m_Components.Dispose();
            }

            base.Dispose(i_Disposing);
        }

        private void initializeComponent()
        {
            this.m_TextBox2 = new System.Windows.Forms.TextBox();
            this.m_TextBox3 = new System.Windows.Forms.TextBox();
            this.m_TextBox1 = new System.Windows.Forms.TextBox();
            this.m_TextBox0 = new System.Windows.Forms.TextBox();
            this.m_ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.m_UserGuessesRows = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.m_TextBox2.BackColor = System.Drawing.Color.Black;
            this.m_TextBox2.Enabled = false;
            this.m_TextBox2.Location = new System.Drawing.Point(218, 12);
            this.m_TextBox2.Multiline = true;
            this.m_TextBox2.Name = "textBox2";
            this.m_TextBox2.Size = new System.Drawing.Size(60, 60);
            this.m_TextBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.m_TextBox3.BackColor = System.Drawing.Color.Black;
            this.m_TextBox3.Enabled = false;
            this.m_TextBox3.Location = new System.Drawing.Point(311, 12);
            this.m_TextBox3.Multiline = true;
            this.m_TextBox3.Name = "textBox3";
            this.m_TextBox3.Size = new System.Drawing.Size(60, 60);
            this.m_TextBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.m_TextBox1.BackColor = System.Drawing.Color.Black;
            this.m_TextBox1.Enabled = false;
            this.m_TextBox1.Location = new System.Drawing.Point(126, 12);
            this.m_TextBox1.Multiline = true;
            this.m_TextBox1.Name = "textBox1";
            this.m_TextBox1.Size = new System.Drawing.Size(60, 60);
            this.m_TextBox1.TabIndex = 1;
            // 
            // textBox0
            // 
            this.m_TextBox0.BackColor = System.Drawing.Color.Black;
            this.m_TextBox0.Enabled = false;
            this.m_TextBox0.Location = new System.Drawing.Point(33, 12);
            this.m_TextBox0.Multiline = true;
            this.m_TextBox0.Name = "textBox0";
            this.m_TextBox0.Size = new System.Drawing.Size(60, 60);
            this.m_TextBox0.TabIndex = 0;
            // 
            // userGuessesRows
            // 
            this.m_UserGuessesRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_UserGuessesRows.Location = new System.Drawing.Point(12, 81);
            this.m_UserGuessesRows.Name = "userGuessesRows";
            this.m_UserGuessesRows.Size = new System.Drawing.Size(408, 414);
            this.m_UserGuessesRows.TabIndex = 5;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.m_TextBox3);
            this.Controls.Add(this.m_TextBox1);
            this.Controls.Add(this.m_TextBox2);
            this.Controls.Add(this.m_TextBox0);
            this.Controls.Add(this.m_UserGuessesRows);
            this.Name = "BoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}