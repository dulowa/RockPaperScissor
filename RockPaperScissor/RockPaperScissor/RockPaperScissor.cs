using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class RockPaperScissor : Form
    {
        Random random = new Random();
        int human_choice;
        int computer_choice;
        static int human_score;
        static int com_score;
        public RockPaperScissor()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            pictureBoxHuman.Image = new Bitmap(@"C:\Users\Acer-pc\source\repos\RockPaperScissor\RockPaperScissor\Images\rock.png");
            human_choice = 0;
            ComputerChoice();
            checkWinner();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pictureBoxHuman.Image = new Bitmap(@"C:\Users\Acer-pc\source\repos\RockPaperScissor\RockPaperScissor\Images\paper.png");
            human_choice = 1;
            ComputerChoice();
            checkWinner();
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            pictureBoxHuman.Image = new Bitmap(@"C:\Users\Acer-pc\source\repos\RockPaperScissor\RockPaperScissor\Images\scissor.png");
            human_choice = 2;
            ComputerChoice();
            checkWinner();
        }
        public void ComputerChoice()
        {
            computer_choice = random.Next(0, 3);
            switch(computer_choice)
            {
                case 0:
                    pictureBoxCom.Image = new Bitmap(@"C:\Users\Acer-pc\source\repos\RockPaperScissor\RockPaperScissor\Images\rock.png");
                    break;
                case 1: pictureBoxCom.Image = new Bitmap(@"C:\Users\Acer-pc\source\repos\RockPaperScissor\RockPaperScissor\Images\paper.png");
                    break;
                case 2: pictureBoxCom.Image = new Bitmap(@"C:\Users\Acer-pc\source\repos\RockPaperScissor\RockPaperScissor\Images\scissor.png");
                    break;
            }
        }
        public void checkWinner()
        {
            if (human_choice == computer_choice)
                lblWin.Text = "Tie";
            else if ((human_choice - computer_choice) % 3 == 1)

            {
                lblWin.Text = "Human wins !";
                human_score++;
                lblScoreHuman.Text = human_score.ToString();
            }
            else
            {
                lblWin.Text = "Computer wins !";
                com_score++;
                LblScoreCom.Text = com_score.ToString();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            human_score = 0;
            com_score = 0;
            lblScoreHuman.Text = "0";
            LblScoreCom.Text = "0";
            lblWin.Text = "Who wins ?";
        }
    }
     
}
