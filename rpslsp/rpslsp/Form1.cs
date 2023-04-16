using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpslsp
{
    public partial class Form1 : Form
    {
        private int playerScore = 0;
        private int computerScore = 0;
        private string[] choices = { "rock", "paper", "scissors", "lizard", "spock" };
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = "Player: 0 | Computer: 0";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string playerChoice = ((TextBox)sender).Tag.ToString();
            string computerChoice = choices[random.Next(choices.Length)];

            switch (playerChoice)
            {
                case "rock":
                    if (computerChoice == "scissors" || computerChoice == "lizard")
                    {
                        playerScore++;
                        resultLabel.Text = "You win!";
                    }
                    else if (computerChoice == "paper" || computerChoice == "spock")
                    {
                        computerScore++;
                        resultLabel.Text = "Computer wins!";
                    }
                    else
                    {
                        resultLabel.Text = "It's a tie!";
                    }
                    break;
                case "paper":
                    if (computerChoice == "rock" || computerChoice == "spock")
                    {
                        playerScore++;
                        resultLabel.Text = "You win!";
                    }
                    else if (computerChoice == "scissors" || computerChoice == "lizard")
                    {
                        computerScore++;
                        resultLabel.Text = "Computer wins!";
                    }
                    else
                    {
                        resultLabel.Text = "It's a tie!";
                    }
                    break;
                case "scissors":
                    if (computerChoice == "paper" || computerChoice == "lizard")
                    {
                        playerScore++;
                        resultLabel.Text = "You win!";
                    }
                    else if (computerChoice == "rock" || computerChoice == "spock")
                    {
                        computerScore++;
                        resultLabel.Text = "Computer wins!";
                    }
                    else
                    {
                        resultLabel.Text = "It's a tie!";
                    }
                    break;
                case "lizard":
                    if (computerChoice == "paper" || computerChoice == "spock")
                    {
                        playerScore++;
                        resultLabel.Text = "You win!";
                    }
                    else if (computerChoice == "rock" || computerChoice == "scissors")
                    {
                        computerScore++;
                        resultLabel.Text = "Computer wins!";
                    }
                    else
                    {
                        resultLabel.Text = "It's a tie!";
                    }
                    break;
                case "spock":
                    if (computerChoice == "rock" || computerChoice == "scissors")
                    {
                        playerScore++;
                        resultLabel.Text = "You win!";
                    }
                    else if (computerChoice == "paper" || computerChoice == "lizard")
                    {
                        computerScore++;
                        resultLabel.Text = "Computer wins!";
                    }
                    else
                    {
                        resultLabel.Text = "It's a tie!";
                    }
                    break;
            }
           scoreLabel.Text = $"Player: {playerScore} | Computer: {computerScore}";
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
