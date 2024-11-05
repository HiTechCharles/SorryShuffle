namespace SorryShuffle
{
    partial class OptionsForm
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
            this.PlayersLBL = new System.Windows.Forms.Label();
            this.PlayersNUD = new System.Windows.Forms.NumericUpDown();
            this.Player1TB = new System.Windows.Forms.TextBox();
            this.Player2TB = new System.Windows.Forms.TextBox();
            this.Player3TB = new System.Windows.Forms.TextBox();
            this.Player4TB = new System.Windows.Forms.TextBox();
            this.NamesLBL = new System.Windows.Forms.Label();
            this.SpeakCardsCHK = new System.Windows.Forms.CheckBox();
            this.PlayBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersLBL
            // 
            this.PlayersLBL.AutoSize = true;
            this.PlayersLBL.Location = new System.Drawing.Point(12, 9);
            this.PlayersLBL.Name = "PlayersLBL";
            this.PlayersLBL.Size = new System.Drawing.Size(325, 39);
            this.PlayersLBL.TabIndex = 0;
            this.PlayersLBL.Text = "&Number of Players:";
            // 
            // PlayersNUD
            // 
            this.PlayersNUD.Location = new System.Drawing.Point(363, 2);
            this.PlayersNUD.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PlayersNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PlayersNUD.Name = "PlayersNUD";
            this.PlayersNUD.Size = new System.Drawing.Size(58, 46);
            this.PlayersNUD.TabIndex = 1;
            this.PlayersNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlayersNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PlayersNUD.ValueChanged += new System.EventHandler(this.PlayersNUD_ValueChanged);
            // 
            // Player1TB
            // 
            this.Player1TB.AccessibleName = "Player 1:";
            this.Player1TB.Location = new System.Drawing.Point(19, 121);
            this.Player1TB.MaxLength = 15;
            this.Player1TB.Name = "Player1TB";
            this.Player1TB.Size = new System.Drawing.Size(399, 46);
            this.Player1TB.TabIndex = 2;
            this.Player1TB.TextChanged += new System.EventHandler(this.Player1TB_TextChanged);
            // 
            // Player2TB
            // 
            this.Player2TB.AccessibleName = "Player 2:";
            this.Player2TB.Location = new System.Drawing.Point(19, 194);
            this.Player2TB.MaxLength = 15;
            this.Player2TB.Name = "Player2TB";
            this.Player2TB.Size = new System.Drawing.Size(399, 46);
            this.Player2TB.TabIndex = 3;
            this.Player2TB.TextChanged += new System.EventHandler(this.Player2TB_TextChanged);
            // 
            // Player3TB
            // 
            this.Player3TB.AccessibleName = "Player 3:";
            this.Player3TB.Location = new System.Drawing.Point(22, 267);
            this.Player3TB.MaxLength = 15;
            this.Player3TB.Name = "Player3TB";
            this.Player3TB.Size = new System.Drawing.Size(399, 46);
            this.Player3TB.TabIndex = 4;
            this.Player3TB.Visible = false;
            this.Player3TB.TextChanged += new System.EventHandler(this.Player3TB_TextChanged);
            // 
            // Player4TB
            // 
            this.Player4TB.AccessibleName = "Player 4:";
            this.Player4TB.Location = new System.Drawing.Point(22, 340);
            this.Player4TB.MaxLength = 15;
            this.Player4TB.Name = "Player4TB";
            this.Player4TB.Size = new System.Drawing.Size(399, 46);
            this.Player4TB.TabIndex = 5;
            this.Player4TB.Visible = false;
            this.Player4TB.TextChanged += new System.EventHandler(this.Player4TB_TextChanged);
            // 
            // NamesLBL
            // 
            this.NamesLBL.AutoSize = true;
            this.NamesLBL.Location = new System.Drawing.Point(15, 79);
            this.NamesLBL.Name = "NamesLBL";
            this.NamesLBL.Size = new System.Drawing.Size(249, 39);
            this.NamesLBL.TabIndex = 6;
            this.NamesLBL.Text = "Player &Names:";
            // 
            // SpeakCardsCHK
            // 
            this.SpeakCardsCHK.AutoSize = true;
            this.SpeakCardsCHK.Location = new System.Drawing.Point(19, 427);
            this.SpeakCardsCHK.Name = "SpeakCardsCHK";
            this.SpeakCardsCHK.Size = new System.Drawing.Size(273, 43);
            this.SpeakCardsCHK.TabIndex = 7;
            this.SpeakCardsCHK.Text = "Text to &Speech";
            this.SpeakCardsCHK.UseVisualStyleBackColor = true;
            this.SpeakCardsCHK.CheckedChanged += new System.EventHandler(this.SpeakCardsCHK_CheckedChanged);
            // 
            // PlayBTN
            // 
            this.PlayBTN.ForeColor = System.Drawing.Color.Black;
            this.PlayBTN.Location = new System.Drawing.Point(314, 409);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(107, 61);
            this.PlayBTN.TabIndex = 8;
            this.PlayBTN.Text = "&Play!";
            this.PlayBTN.UseVisualStyleBackColor = true;
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(431, 487);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.SpeakCardsCHK);
            this.Controls.Add(this.NamesLBL);
            this.Controls.Add(this.Player4TB);
            this.Controls.Add(this.Player3TB);
            this.Controls.Add(this.Player2TB);
            this.Controls.Add(this.Player1TB);
            this.Controls.Add(this.PlayersNUD);
            this.Controls.Add(this.PlayersLBL);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "OptionsForm";
            this.Text = "SorryShuffle - Game Setup";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayersLBL;
        private System.Windows.Forms.NumericUpDown PlayersNUD;
        private System.Windows.Forms.TextBox Player1TB;
        private System.Windows.Forms.TextBox Player2TB;
        private System.Windows.Forms.TextBox Player3TB;
        private System.Windows.Forms.TextBox Player4TB;
        private System.Windows.Forms.Label NamesLBL;
        private System.Windows.Forms.CheckBox SpeakCardsCHK;
        private System.Windows.Forms.Button PlayBTN;
    }
}

