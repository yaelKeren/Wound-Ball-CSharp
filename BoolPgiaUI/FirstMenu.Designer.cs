namespace BoolPgiaUI
{
    internal partial class FirstMenu
    {
        private System.ComponentModel.IContainer m_Components = null;
        private System.Windows.Forms.Button m_NumOfChancesButton;
        private System.Windows.Forms.Button m_StartButton;

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
            this.m_NumOfChancesButton = new System.Windows.Forms.Button();
            this.m_StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumOfChancesButton
            // 
            this.m_NumOfChancesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_NumOfChancesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_NumOfChancesButton.Location = new System.Drawing.Point(12, 22);
            this.m_NumOfChancesButton.Name = "NumOfChancesButton";
            this.m_NumOfChancesButton.Size = new System.Drawing.Size(418, 66);
            this.m_NumOfChancesButton.TabIndex = 0;
            this.m_NumOfChancesButton.Text = "Number of chances : 4";
            this.m_NumOfChancesButton.UseVisualStyleBackColor = true;
            this.m_NumOfChancesButton.Click += new System.EventHandler(this.numOfChancesButton_Click);
            // 
            // StartButton
            // 
            this.m_StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_StartButton.Location = new System.Drawing.Point(281, 210);
            this.m_StartButton.Name = "StartButton";
            this.m_StartButton.Size = new System.Drawing.Size(149, 80);
            this.m_StartButton.TabIndex = 1;
            this.m_StartButton.Text = "Start";
            this.m_StartButton.UseVisualStyleBackColor = true;
            this.m_StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // FirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 302);
            this.Controls.Add(this.m_StartButton);
            this.Controls.Add(this.m_NumOfChancesButton);
            this.Name = "FirstMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }
    }
}