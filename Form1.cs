using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace Xboxcmd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("nc64.exe", "-lvnp " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("payload_server_win_x64.exe", "--stage2 stage2.bin --run run.exe ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("DumpgameServer.exe");
        }
    }
}