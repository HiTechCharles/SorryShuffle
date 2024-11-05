using System;
using System.Windows.Forms;

namespace SorryShuffle
{
    public partial class OptionsForm : Form
    {
        #region VARIABLE DECLARATIONS
        public static string[] PNames = { "Black",  "Yellow", "Blue", "Red", "Green" };
         public static bool SpeechToggle;  //speech on or off
        public static int NumPlayers=2;  //number of playas
        #endregion

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void PlayersNUD_ValueChanged(object sender, EventArgs e)
        {
            NumPlayers = Convert.ToInt32(PlayersNUD.Value); //copy NUD value to a public variable 
            switch (PlayersNUD.Value) ////run code based on num players 
            {
                case 2:  //2 players 
                    Player3TB.Visible = false;  //hide p3 and p4 textboxes
                    Player4TB.Visible = false;
                    break;  //dance
                case 3:
                    Player3TB.Visible = true ;  //show p3, hide p4
                    Player4TB.Visible = false;
                    break;
                case 4:
                    Player3TB.Visible = true;
                    Player4TB.Visible = true;  //show p3 & p4
                    break;
            }
        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
            GameForm form2 = new GameForm();  //a horse is a horse is a horse
            this.Hide();  //hide first form
            form2.ShowDialog();
            this.Show();
        }

        private void SpeakCardsCHK_CheckedChanged(object sender, EventArgs e)
        {
            if ( SpeakCardsCHK.Checked)  //if  TTS checked
                SpeechToggle = true;  //speech toggle true
            else
                SpeechToggle = false;  //otherwise false
        }

        #region textbox changed, copy to names array
        private void Player2TB_TextChanged(object sender, EventArgs e)
        {
            PNames[2] = Player2TB.Text;
        }

        private void Player1TB_TextChanged(object sender, EventArgs e)
        {
            PNames[1] = Player1TB.Text; 
        }

        private void Player3TB_TextChanged(object sender, EventArgs e)
        {
            PNames[3] = Player3TB.Text; 
        }

        private void Player4TB_TextChanged(object sender, EventArgs e)
        {
            PNames[4] = Player4TB.Text; 
        }
        #endregion 

    }  //end class
}  //end namespace