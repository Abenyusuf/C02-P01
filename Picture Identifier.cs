using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker_large_Ahmed_Benyusuf
{
    public partial class PictureIdentifier : Form
    {
        public PictureIdentifier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "The Two Of Clubs";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void SixDiamondPictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "The Six Of Diamond";
        }

        private void QueenHeartPictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "The Queen of Hearts";
        }

        private void KingSpadePictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "The King Of Spades";
        }

        private void AceSpadePictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "The Ace Of spades";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
