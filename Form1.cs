using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMyNumberWinForm
{
    public partial class FormGuess : Form
    {
        public int guess = 0;
        static Random r = new Random();
        public int number = r.Next(5);
        public int tries = 3;

        public FormGuess()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            this.MaximizeBox = false;
            btnPlay.Enabled = false;
            lblMessage.Text = "Guess my number. Hint: its between 0 to 5.";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
	    

	this.Controls.Clear();
	this.InitializeComponent();


        }
	
	

	private void label1_Click(object sender, EventArgs e)
        {

        }

	private void btnClose_Click(object sender, EventArgs e)
        {
	this.Close();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            
	 
	if (int.TryParse(txtGuess.Text,out guess))
	{
	   if (tries > 0)
            {
                if (guess != number)
                {
		    tries--;
                    lblMessage.Text = ("You have guessed wrong, guess again. You have" + " " + (tries) + " " + "guesses left");
                    number = int.Parse(txtGuess.Text);
                    
                }
		else
           	{
		    guess = int.Parse(txtGuess.Text);
                    btnCheck.Enabled = false;
                    btnPlay.Enabled = true;
                    lblMessage.Text = ("You have guessed right, my number is" + " " + (Convert.ToString(number)) + ". Play again for $10?");
            	}
            }
	    
            else
	    {
		btnCheck.Enabled = false;
                btnPlay.Enabled = true;
		lblMessage.Text = ("You are out of guesses.");
                 
            }
           }

          else
	  {
		lblMessage.Text = ("Please enter a number...Re-enter your guess.");
	  }
        }
    }
}
        
    
