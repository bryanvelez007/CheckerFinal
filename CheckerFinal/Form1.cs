using OpenQA.Selenium.Chrome;
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
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://aspnetcoremaster.com";
            Thread.Sleep(7000);
            driver.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
