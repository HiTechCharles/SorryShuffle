namespace SorryShuffle
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameLogLBL = new System.Windows.Forms.Label();
            this.FlipCardBTN = new System.Windows.Forms.Button();
            this.CurPlayerLBL = new System.Windows.Forms.Label();
            this.CurPlayerTB = new System.Windows.Forms.TextBox();
            this.CardDrawnTB = new System.Windows.Forms.TextBox();
            this.CardDrawnLBL = new System.Windows.Forms.Label();
            this.GameLogRTB = new System.Windows.Forms.RichTextBox();
            this.RepeatBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameLogLBL
            // 
            this.GameLogLBL.AutoSize = true;
            this.GameLogLBL.Location = new System.Drawing.Point(3, 9);
            this.GameLogLBL.Name = "GameLogLBL";
            this.GameLogLBL.Size = new System.Drawing.Size(177, 39);
            this.GameLogLBL.TabIndex = 0;
            this.GameLogLBL.Text = "Game &Log";
            // 
            // FlipCardBTN
            // 
            this.FlipCardBTN.ForeColor = System.Drawing.Color.Black;
            this.FlipCardBTN.Location = new System.Drawing.Point(541, 427);
            this.FlipCardBTN.Name = "FlipCardBTN";
            this.FlipCardBTN.Size = new System.Drawing.Size(225, 55);
            this.FlipCardBTN.TabIndex = 7;
            this.FlipCardBTN.Text = "Flip a &Card";
            this.FlipCardBTN.UseVisualStyleBackColor = true;
            this.FlipCardBTN.Click += new System.EventHandler(this.FlipCardBTN_Click);
            // 
            // CurPlayerLBL
            // 
            this.CurPlayerLBL.AutoSize = true;
            this.CurPlayerLBL.Location = new System.Drawing.Point(360, 9);
            this.CurPlayerLBL.Name = "CurPlayerLBL";
            this.CurPlayerLBL.Size = new System.Drawing.Size(260, 39);
            this.CurPlayerLBL.TabIndex = 2;
            this.CurPlayerLBL.Text = "Current Player:";
            // 
            // CurPlayerTB
            // 
            this.CurPlayerTB.Location = new System.Drawing.Point(360, 51);
            this.CurPlayerTB.Name = "CurPlayerTB";
            this.CurPlayerTB.ReadOnly = true;
            this.CurPlayerTB.Size = new System.Drawing.Size(399, 46);
            this.CurPlayerTB.TabIndex = 3;
            // 
            // CardDrawnTB
            // 
            this.CardDrawnTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardDrawnTB.Location = new System.Drawing.Point(360, 164);
            this.CardDrawnTB.Multiline = true;
            this.CardDrawnTB.Name = "CardDrawnTB";
            this.CardDrawnTB.ReadOnly = true;
            this.CardDrawnTB.Size = new System.Drawing.Size(399, 243);
            this.CardDrawnTB.TabIndex = 5;
            // 
            // CardDrawnLBL
            // 
            this.CardDrawnLBL.AutoSize = true;
            this.CardDrawnLBL.Location = new System.Drawing.Point(360, 122);
            this.CardDrawnLBL.Name = "CardDrawnLBL";
            this.CardDrawnLBL.Size = new System.Drawing.Size(217, 39);
            this.CardDrawnLBL.TabIndex = 4;
            this.CardDrawnLBL.Text = "Card &Drawn:";
            // 
            // GameLogRTB
            // 
            this.GameLogRTB.AccessibleDescription = "";
            this.GameLogRTB.AccessibleName = "Game Log";
            this.GameLogRTB.Location = new System.Drawing.Point(10, 51);
            this.GameLogRTB.Name = "GameLogRTB";
            this.GameLogRTB.ReadOnly = true;
            this.GameLogRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.GameLogRTB.Size = new System.Drawing.Size(342, 356);
            this.GameLogRTB.TabIndex = 1;
            this.GameLogRTB.Tag = "Game Log";
            this.GameLogRTB.Text = "";
            this.GameLogRTB.TextChanged += new System.EventHandler(this.GameLogRTB_TextChanged);
            // 
            // RepeatBTN
            // 
            this.RepeatBTN.ForeColor = System.Drawing.Color.Black;
            this.RepeatBTN.Location = new System.Drawing.Point(360, 427);
            this.RepeatBTN.Name = "RepeatBTN";
            this.RepeatBTN.Size = new System.Drawing.Size(141, 55);
            this.RepeatBTN.TabIndex = 6;
            this.RepeatBTN.Text = "&Repeat ";
            this.RepeatBTN.UseVisualStyleBackColor = true;
            this.RepeatBTN.Visible = false;
            this.RepeatBTN.Click += new System.EventHandler(this.RepeatBTN_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(776, 494);
            this.Controls.Add(this.RepeatBTN);
            this.Controls.Add(this.GameLogRTB);
            this.Controls.Add(this.CardDrawnLBL);
            this.Controls.Add(this.CardDrawnTB);
            this.Controls.Add(this.FlipCardBTN);
            this.Controls.Add(this.CurPlayerLBL);
            this.Controls.Add(this.GameLogLBL);
            this.Controls.Add(this.CurPlayerTB);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Welcome to SorryShuffle!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GameLogLBL;
        private System.Windows.Forms.Button FlipCardBTN;
        private System.Windows.Forms.Label CurPlayerLBL;
        private System.Windows.Forms.TextBox CurPlayerTB;
        private System.Windows.Forms.TextBox CardDrawnTB;
        private System.Windows.Forms.Label CardDrawnLBL;
        private System.Windows.Forms.RichTextBox GameLogRTB;
        private System.Windows.Forms.Button RepeatBTN;
    }
}