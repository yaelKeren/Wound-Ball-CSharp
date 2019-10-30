namespace BoolPgiaUI
{
    internal partial class LRowUserGusse
    {
        private System.ComponentModel.IContainer m_Components = null;
        private System.Windows.Forms.Panel m_RowOfGuesses;
        private System.Windows.Forms.TextBox m_FeedBack4;
        private System.Windows.Forms.TextBox m_FeedBack3;
        private System.Windows.Forms.TextBox m_FeedBack2;
        private System.Windows.Forms.TextBox m_FeedBack1;
        private System.Windows.Forms.Button m_Fourth;
        private System.Windows.Forms.Button m_Third;
        private System.Windows.Forms.Button m_SendGuesse;
        private System.Windows.Forms.Button m_Second;
        private System.Windows.Forms.Button m_First;

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
            this.m_RowOfGuesses = new System.Windows.Forms.Panel();
            this.m_FeedBack4 = new System.Windows.Forms.TextBox();
            this.m_FeedBack3 = new System.Windows.Forms.TextBox();
            this.m_FeedBack2 = new System.Windows.Forms.TextBox();
            this.m_FeedBack1 = new System.Windows.Forms.TextBox();
            this.m_Fourth = new System.Windows.Forms.Button();
            this.m_Third = new System.Windows.Forms.Button();
            this.m_SendGuesse = new System.Windows.Forms.Button();
            this.m_Second = new System.Windows.Forms.Button();
            this.m_First = new System.Windows.Forms.Button();
            this.m_RowOfGuesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // RowOfGuesses
            // 
            this.m_RowOfGuesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_RowOfGuesses.Controls.Add(this.m_FeedBack4);
            this.m_RowOfGuesses.Controls.Add(this.m_FeedBack3);
            this.m_RowOfGuesses.Controls.Add(this.m_FeedBack2);
            this.m_RowOfGuesses.Controls.Add(this.m_FeedBack1);
            this.m_RowOfGuesses.Controls.Add(this.m_Fourth);
            this.m_RowOfGuesses.Controls.Add(this.m_Third);
            this.m_RowOfGuesses.Controls.Add(this.m_SendGuesse);
            this.m_RowOfGuesses.Controls.Add(this.m_Second);
            this.m_RowOfGuesses.Controls.Add(this.m_First);
            this.m_RowOfGuesses.Location = new System.Drawing.Point(0, 0);
            this.m_RowOfGuesses.Name = "RowOfGuesses";
            this.m_RowOfGuesses.Size = new System.Drawing.Size(400, 84);
            this.m_RowOfGuesses.TabIndex = 5;
            // 
            // feedBack4
            // 
            this.m_FeedBack4.Location = new System.Drawing.Point(354, 43);
            this.m_FeedBack4.Multiline = true;
            this.m_FeedBack4.Name = "feedBack4";
            this.m_FeedBack4.Size = new System.Drawing.Size(14, 14);
            this.m_FeedBack4.TabIndex = 10;
            // 
            // feedBack3
            // 
            this.m_FeedBack3.Location = new System.Drawing.Point(374, 18);
            this.m_FeedBack3.Multiline = true;
            this.m_FeedBack3.Name = "feedBack3";
            this.m_FeedBack3.Size = new System.Drawing.Size(14, 14);
            this.m_FeedBack3.TabIndex = 9;
            // 
            // feedBack2
            // 
            this.m_FeedBack2.Location = new System.Drawing.Point(374, 43);
            this.m_FeedBack2.Multiline = true;
            this.m_FeedBack2.Name = "feedBack2";
            this.m_FeedBack2.ReadOnly = true;
            this.m_FeedBack2.Size = new System.Drawing.Size(14, 14);
            this.m_FeedBack2.TabIndex = 8;
            // 
            // feedBack1
            // 
            this.m_FeedBack1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.m_FeedBack1.Location = new System.Drawing.Point(354, 18);
            this.m_FeedBack1.Multiline = true;
            this.m_FeedBack1.Name = "feedBack1";
            this.m_FeedBack1.ReadOnly = true;
            this.m_FeedBack1.Size = new System.Drawing.Size(14, 14);
            this.m_FeedBack1.TabIndex = 7;
            this.m_FeedBack1.WordWrap = false;
            // 
            // fourth
            // 
            this.m_Fourth.BackColor = System.Drawing.SystemColors.Control;
            this.m_Fourth.Location = new System.Drawing.Point(218, 18);
            this.m_Fourth.Name = "fourth";
            this.m_Fourth.Size = new System.Drawing.Size(49, 49);
            this.m_Fourth.TabIndex = 6;
            this.m_Fourth.UseVisualStyleBackColor = false;
            this.m_Fourth.Click += new System.EventHandler(this.squareGuess_Click);
            // 
            // thered
            // 
            this.m_Third.BackColor = System.Drawing.SystemColors.Control;
            this.m_Third.Location = new System.Drawing.Point(149, 18);
            this.m_Third.Name = "thered";
            this.m_Third.Size = new System.Drawing.Size(49, 49);
            this.m_Third.TabIndex = 5;
            this.m_Third.UseVisualStyleBackColor = false;
            this.m_Third.Click += new System.EventHandler(this.squareGuess_Click);
            // 
            // sendGuesse
            // 
            this.m_SendGuesse.Enabled = false;
            this.m_SendGuesse.Location = new System.Drawing.Point(284, 31);
            this.m_SendGuesse.Name = "sendGuesse";
            this.m_SendGuesse.Size = new System.Drawing.Size(60, 23);
            this.m_SendGuesse.TabIndex = 4;
            this.m_SendGuesse.Text = "-->>";
            this.m_SendGuesse.UseVisualStyleBackColor = true;
            this.m_SendGuesse.Click += new System.EventHandler(this.sendGuesse_Click);
            // 
            // secuond
            // 
            this.m_Second.Location = new System.Drawing.Point(79, 18);
            this.m_Second.Name = "secuond";
            this.m_Second.Size = new System.Drawing.Size(49, 49);
            this.m_Second.TabIndex = 2;
            this.m_Second.UseVisualStyleBackColor = false;
            this.m_Second.Click += new System.EventHandler(this.squareGuess_Click);
            // 
            // first
            // 
            this.m_First.Location = new System.Drawing.Point(13, 18);
            this.m_First.Name = "first";
            this.m_First.Size = new System.Drawing.Size(49, 49);
            this.m_First.TabIndex = 0;
            this.m_First.UseVisualStyleBackColor = false;
            this.m_First.Click += new System.EventHandler(this.squareGuess_Click);
            // 
            // LRowUserGusse
            // 
            this.Controls.Add(this.m_RowOfGuesses);
            this.Size = new System.Drawing.Size(400, 70);
            this.m_RowOfGuesses.ResumeLayout(false);
            this.m_RowOfGuesses.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}