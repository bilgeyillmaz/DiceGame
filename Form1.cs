using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int totalFirstPlayer = 0;
        int totalSecondPlayer = 0;  

        private void button1FirstPlayer_Click(object sender, EventArgs e)
        {
            button1FirstPlayer.Enabled = false;
            button1.Enabled = true;
            int a = random.Next(1, 7);
            int b = random.Next(1, 7);
            totalFirstPlayer = totalFirstPlayer + a + b;

            if(a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\1.jpg";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\3.jpg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\4.jpg";

            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\5.jpg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\6.jpg";
            }
            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\1.jpg";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\2.jpg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\3.jpg";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\4.jpg";

            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\5.jpg";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\6.jpg";
            }
            FirstPlayerPointTableValue.Text = totalFirstPlayer.ToString();

            Dice1FirstPlayerValue.Text = a.ToString();
            Dice2FirstPlayerValue.Text = b.ToString();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1FirstPlayer.Enabled = true;
            button1.Enabled = false;
            int c = random.Next(1, 7);
            int d = random.Next(1, 7);
            totalSecondPlayer = totalFirstPlayer + c + d;

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\1.jpg";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\2.jpg";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\3.jpg";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\4.jpg";

            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\5.jpg";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\6.jpg";
            }
            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\1.jpg";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\2.jpg";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\3.jpg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\4.jpg";

            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\5.jpg";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\billg\\source\repos\\WindowsFormsApp_DiceGame\\WindowsFormsApp_DiceGame\\6.jpg";
            }
            FirstPlayerPointTableValue.Text = totalFirstPlayer.ToString();

            Dice1SecondPlayerValue.Text = c.ToString();
            Dice2SecondPlayerValue.Text = d.ToString();
            if (totalSecondPlayer>100 && totalSecondPlayer>totalFirstPlayer)
            {
                PointTableWinner.Text = "Aaaaand the winner is Second Player!!! Yeeey!! Congratulations!!! ";
            }
            if (totalFirstPlayer > 100 && totalSecondPlayer < totalFirstPlayer)
            {
                PointTableWinner.Text = "Aaaaand the winner is First Player!!! Yeeey!! Congratulations!!! ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1FirstPlayer.Enabled = true;
            button1.Enabled = false;
        }
    }
}
