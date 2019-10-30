namespace BoolPgiaUI
{
    internal partial class ColorPalette
    {
        private System.ComponentModel.IContainer m_Components = null;
        private System.Windows.Forms.Button m_ColorButton1;
        private System.Windows.Forms.Button m_ColorButton2;
        private System.Windows.Forms.Button m_ColorButton3;
        private System.Windows.Forms.Button m_ColorButton4;
        private System.Windows.Forms.Button m_ColorButton5;
        private System.Windows.Forms.Button m_ColorButton6;
        private System.Windows.Forms.Button m_ColorButton7;
        private System.Windows.Forms.Button m_ColorButton8;
        private System.Windows.Forms.ColorDialog m_ColorDialog;

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
            this.m_ColorButton1 = new System.Windows.Forms.Button();
            this.m_ColorButton2 = new System.Windows.Forms.Button();
            this.m_ColorButton3 = new System.Windows.Forms.Button();
            this.m_ColorButton4 = new System.Windows.Forms.Button();
            this.m_ColorButton5 = new System.Windows.Forms.Button();
            this.m_ColorButton6 = new System.Windows.Forms.Button();
            this.m_ColorButton7 = new System.Windows.Forms.Button();
            this.m_ColorButton8 = new System.Windows.Forms.Button();
            this.m_ColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.m_ColorButton1.BackColor = System.Drawing.Color.Fuchsia;
            this.m_ColorButton1.Location = new System.Drawing.Point(12, 12);
            this.m_ColorButton1.Name = "button1";
            this.m_ColorButton1.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton1.TabIndex = 0;
            this.m_ColorButton1.UseVisualStyleBackColor = false;
            this.m_ColorButton1.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button2
            // 
            this.m_ColorButton2.BackColor = System.Drawing.Color.Yellow;
            this.m_ColorButton2.Location = new System.Drawing.Point(86, 79);
            this.m_ColorButton2.Name = "button2";
            this.m_ColorButton2.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton2.TabIndex = 1;
            this.m_ColorButton2.UseVisualStyleBackColor = false;
            this.m_ColorButton2.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button3
            // 
            this.m_ColorButton3.BackColor = System.Drawing.Color.Maroon;
            this.m_ColorButton3.Location = new System.Drawing.Point(156, 79);
            this.m_ColorButton3.Name = "button3";
            this.m_ColorButton3.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton3.TabIndex = 2;
            this.m_ColorButton3.UseVisualStyleBackColor = false;
            this.m_ColorButton3.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button4
            // 
            this.m_ColorButton4.BackColor = System.Drawing.Color.White;
            this.m_ColorButton4.Location = new System.Drawing.Point(232, 79);
            this.m_ColorButton4.Name = "button4";
            this.m_ColorButton4.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton4.TabIndex = 3;
            this.m_ColorButton4.UseVisualStyleBackColor = false;
            this.m_ColorButton4.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button5
            // 
            this.m_ColorButton5.BackColor = System.Drawing.Color.Aqua;
            this.m_ColorButton5.Location = new System.Drawing.Point(232, 12);
            this.m_ColorButton5.Name = "button5";
            this.m_ColorButton5.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton5.TabIndex = 4;
            this.m_ColorButton5.UseVisualStyleBackColor = false;
            this.m_ColorButton5.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button6
            // 
            this.m_ColorButton6.BackColor = System.Drawing.Color.Lime;
            this.m_ColorButton6.Location = new System.Drawing.Point(156, 12);
            this.m_ColorButton6.Name = "button6";
            this.m_ColorButton6.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton6.TabIndex = 5;
            this.m_ColorButton6.UseVisualStyleBackColor = false;
            this.m_ColorButton6.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button7
            // 
            this.m_ColorButton7.BackColor = System.Drawing.Color.Red;
            this.m_ColorButton7.Location = new System.Drawing.Point(86, 12);
            this.m_ColorButton7.Name = "button7";
            this.m_ColorButton7.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton7.TabIndex = 6;
            this.m_ColorButton7.UseVisualStyleBackColor = false;
            this.m_ColorButton7.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button8
            // 
            this.m_ColorButton8.BackColor = System.Drawing.Color.Beige;
            this.m_ColorButton8.Location = new System.Drawing.Point(12, 79);
            this.m_ColorButton8.Name = "button8";
            this.m_ColorButton8.Size = new System.Drawing.Size(48, 45);
            this.m_ColorButton8.TabIndex = 7;
            this.m_ColorButton8.UseVisualStyleBackColor = false;
            this.m_ColorButton8.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorDialog1
            // 
            this.m_ColorDialog.Color = System.Drawing.Color.Fuchsia;
            // 
            // ColorPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(294, 149);
            this.Controls.Add(this.m_ColorButton8);
            this.Controls.Add(this.m_ColorButton7);
            this.Controls.Add(this.m_ColorButton6);
            this.Controls.Add(this.m_ColorButton5);
            this.Controls.Add(this.m_ColorButton4);
            this.Controls.Add(this.m_ColorButton3);
            this.Controls.Add(this.m_ColorButton2);
            this.Controls.Add(this.m_ColorButton1);
            this.Name = "ColorPalette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pik a Color:";
            this.ResumeLayout(false);

        }
    }
}