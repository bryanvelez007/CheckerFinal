using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            bunifuPanel7.BackColor = Color.FromArgb(30, Color.Transparent);
            bunifuPanel7.BackgroundColor = Color.FromArgb(50, Color.FromArgb(116, 98, 209));

            // Create an instance of a TextBox control.

            livescard.SelectAll();
            livescard.SelectionIndent += 15;//play with this values to match yours
            livescard.SelectionRightIndent += 15;//this too
            livescard.SelectionLength = 0;
            //this is a little hack because without this
            //i've got the first line of my richTB selected anyway.
            livescard.SelectionBackColor = livescard.BackColor;

        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {


        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Thread TypingThread2 = new Thread(delegate () 
            {
                gate1 obj = new gate1();

                obj.fillCards();

                String[] finalCard = obj.migate1();
                for (var x = 0; x < finalCard.Length; x++)
                {
                    paintCard(Color.Red, finalCard[x]);
                }

            });

            TypingThread2.Start();

        }

        public void paintCard(Color color, String card)
        {

            Thread TypingThread = new Thread(delegate ()
            {

                if (livescard.InvokeRequired)
                {
                    livescard.Invoke(new MethodInvoker(delegate
                    {
                        livescard.SelectionStart = livescard.TextLength;
                        livescard.SelectionLength = 0;
                        livescard.SelectionColor = color;
                        livescard.AppendText(card + System.Environment.NewLine);
                        livescard.SelectionColor = livescard.ForeColor;
                    }));
                }
            });

            TypingThread.Start();

        }

        private void livescard_Enter(object sender, EventArgs e)
        {

        }

        private void livescard_Leave(object sender, EventArgs e)
        {

        }


    }
}
