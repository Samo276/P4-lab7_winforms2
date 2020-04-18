using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_lab7_winforms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
            textBox1.Text = settings.MySetting;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Color";
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                button2.BackColor = colorDialog1.Color;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000, "tytul", "tresc ", ToolTipIcon.Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           fontDialog1.ShowDialog();
            var font = fontDialog1.Font;
            var color = fontDialog1.Color;
            richTextBox1.Font = font;
            richTextBox1.ForeColor = color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }
    }
}
