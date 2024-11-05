using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;  //for text to speech
using System.Threading;

namespace SorryShuffle
{
    public partial class GameForm : Form
    {
        Stopwatch AppTimer = new Stopwatch();
        
        #region VARIABLE DECLARATIONS
        //current player, cards left in deck, card number picked
        public static int Turn =0, CardsLeft, SCard;
        public static string[] CardDesc = new string[14]; //store card descriptions     
        public static int[] CardDeck = new int[14];  //stores how many of each card are available
        public static SpeechSynthesizer Speech = new SpeechSynthesizer();  //start speech synth
        #endregion

        public GameForm()
        {
            InitializeComponent();
            AppTimer.Start();

            //put player order in game log
            WriteLog("PLAYER ORDER:");
            for (int i = 1; i < OptionsForm.NumPlayers + 1; i++)  //loop for each player
            {
                GameLogRTB.AppendText(OptionsForm.PNames[i] + ", "); //commas in between names
            }
            WriteLog(""); //blank line

            Speech.Rate = 2;  //make all speech a little faster
            if (OptionsForm.SpeechToggle == true)  //if speech is on,
            {
                RepeatBTN.Visible = true;
                Speech.SpeakAsync(GameLogRTB.Text); //read entire game log
            }
            ShuffleCards();  //shuffle the cards

        }

        private bool CheckCard (int CardNum) //examine chosen card
        {
            if (CardDeck[CardNum] > 0 )  //if cards of this number are in the deck
            {
                CardDeck[CardNum]--;  //remove one card of that type
                CardsLeft--;  //keep track of cards left in deck

                if ( CardsLeft == 0 )  //shuffle when no cards remain
                {
                    ShuffleCards();
                }
                return true;  //the card picked was available
            }
            return false;  //pick another card
        }

        private void WriteLog(string msg)  //write to game log 
        {
            GameLogRTB.AppendText(msg + "\n");  //write to text box, starting new line after each line
        }

        private void SpeakTurn ()  //speak player name and chosen card
        {
            if ( OptionsForm.SpeechToggle == true )   //if speech on
            {

                //name
                Speech.SpeakAsync(CurPlayerTB.Text);
                Speech.SpeakAsync(CardDrawnTB.Text);  //card
            }
        }

        private void GameLogRTB_TextChanged(object sender, EventArgs e)
        {
            //make sure game log automatically scrolls
            //when new text is added
            GameLogRTB.SelectionStart = GameLogRTB.Text.Length;
            GameLogRTB.ScrollToCaret();
        }

        private void FlipCardBTN_Click(object sender, EventArgs e)
        {            
            Turn++; //go to next player
            if (Turn > OptionsForm.NumPlayers)  //if turn value past number of players
            {
                Turn = 1;  //reset to first player
            }

            CurPlayerTB.Text = OptionsForm.PNames[Turn];  //put player name in textbox
        GetCard:
            Random RNG = new Random();  //random number generator
            SCard = RNG.Next(1, 14);  //1 2 3 4 5 7 8 10 11 12 sorry

            if (CheckCard(SCard) == true)  //see if the card picked is available
            {
                CardDrawnTB.Text = CardDesc[SCard]; //put card desc in a textbox
                switch (SCard)  //do code for special cases
                {
                    case 13:  //sorry  don't want to print card 13
                        WriteLog(OptionsForm.PNames[Turn] + " - SORRY!");  //write to log
                        SpeakTurn();
                        break;
                    case 2:  //draw again
                        WriteLog(OptionsForm.PNames[Turn] + " - " + SCard);
                        Turn--;  //keep turn the same
                        SpeakTurn();  //speak turn
                        return;  //exit function
                        break;
                    default:  //all other numbers
                        WriteLog(OptionsForm.PNames[Turn] + " - " + SCard);
                        SpeakTurn();  //speak card picked if speech on

                        break;
                }
            }
            else  //if card not in deck, pick another
            {
                goto GetCard;
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppTimer.Stop();
            TimeSpan ts = AppTimer.Elapsed;
            string TimeMessage = String.Format("{0} Hours, {1} Minutes, {2} Seconds",
            ts.Hours, ts.Minutes, ts.Seconds);
            
            WriteLog("Elapsed time:  " + TimeMessage);

            if (OptionsForm.SpeechToggle == true)  //if speech is on,
            {
                Speech.Speak("Elapsed time:  " + TimeMessage);
            }    
            Thread.Sleep(3000);
            this.Close();
        }

        private void RepeatBTN_Click(object sender, EventArgs e)
        {
            SpeakTurn();  //repeat current turn
        }

        void ShuffleCards()  //shuffle at beginning of game and after all cards seen 
        {
              for (int i = 2; i < 14; i++)  //2 to sorry
            {       
                CardDeck[i] = 4;   //there are 4 of each card
            }
            CardDeck[1] = 5;  //except 1, which there are 5
            CardDeck[6] = 0;  //no 6s or 9s
            CardDeck[9] = 0;
            CardsLeft = 45;  //deck contains 45
            WriteLog("Shuffled Cards"); //write to log when shuffles occur
            
            if ( OptionsForm.SpeechToggle == true ) //say cards shuffled if speech on
            {
                Speech.SpeakAsync("Cards have been shuffled.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //set card descriptions
            CardDesc[1] = "- 1 - Move from start or move forward 1.";
            CardDesc[2] = "- 2 - Move from start  or move forward 2.  DRAW AGAIN!";
            CardDesc[3] = "- 3 - Move forward 3.";
            CardDesc[4] = "- 4 - Move backward 4.";
            CardDesc[5] = "- 5 - Move forward 5.";
            CardDesc[7] = "- 7 - Move forward 7, or split between two pawns.";
            CardDesc[8] = "- 8 - Move forward 8.";
            CardDesc[10] = "- 10 - Move forward 10, or move backward 1.";
            CardDesc[11] = "- 11 - Move forward 11, or swap places with an opposing pawn.";
            CardDesc[12] = "- 12 - Move forward 12.";
            CardDesc[13] = "- SORRY! - Take  a pawn from start and move it to a square occupied by an opponent's pawn, sending it back to its own start";
        }
    
    }  //end class
}      //end name