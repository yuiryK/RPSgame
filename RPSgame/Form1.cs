using Microsoft.VisualBasic.Devices;
using System.Runtime.CompilerServices;

namespace RPSgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int GetRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            return randomNumber;
        }
        private void GetWinner(int computer, int gamer)
        {
            if (computer == 1)
            {
                label1.Text = "Copmputer has chosen Rock";
                if (gamer == 1)
                {
                    label2.Text = "You have chosen Rock";
                    label3.Text = "There is no winner. Please try again";
                }
                else if (gamer == 2)
                {
                    label2.Text = "You have chosen Paper";
                    label3.Text = "You wins";

                }
                else
                {
                    label2.Text = "You have chosen Scissors";
                    label3.Text = "Computer wins";
                }
            }
            else if (computer == 2)
            {
                label1.Text = "Copmputer has chosen Paper";
                if (gamer == 1)
                {
                    label2.Text = "You have chosen Rock";
                    label3.Text = "Computer wins";
                }
                else if (gamer == 2)
                {
                    label2.Text = "You have chosen Paper";
                    label3.Text = "There is no winner. Please try again";
                }
                else
                {
                    label2.Text = "You have chosen Scissors";
                    label3.Text = "You wins";
                }
            }
            else
            {
                label1.Text = "Copmputer has chosen Scissors";
                if (gamer == 1)
                {
                    label2.Text = "You have chosen Rock";
                    label3.Text = "You wins";
                }
                else if (gamer == 2)
                {
                    label2.Text = "You have chosen Paper";
                    label3.Text = "Computer wins";
                }
                else
                {
                    label2.Text = "You have chosen Scissors";
                    label3.Text = "There is no winner. Please try again";

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int computer = GetRandomNumber();
            int gamer = 1;
            GetWinner(computer, gamer);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int computer = GetRandomNumber();
            int gamer = 2;
            GetWinner(computer, gamer);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int computer = GetRandomNumber();
            int gamer = 3;
            GetWinner(computer, gamer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}