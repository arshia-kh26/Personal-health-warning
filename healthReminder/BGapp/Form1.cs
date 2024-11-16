using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGapp
{
    public partial class Form1 : Form
    { 
        int a = 0;
        int y = 0;
        int y2 = 0;
        public int count = 5;
        public string time;
        public int start = 0;
        int m = 0, h = 0, S = 0;
        public Form1()
        {

            InitializeComponent();
            //notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Visible = true;

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Back to app", null, ShowApp);
            contextMenu.Items.Add("Exit", null, ExitApp);
            notifyIcon1.ContextMenuStrip = contextMenu;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ShowApp(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitApp(object sender, EventArgs e)
        {
            this.Close();

            notifyIcon1.Visible = false;
            Application.Exit();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //time = textBox1.Text;

            //String T1 = textBox1.ToString();
            //if (T1.Length > 0)
            //{
            //    button1.Enabled = true;
            //}
            //else
            //{
            //    button1.Enabled = false;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                S++;
                label10.Text = S.ToString();
                if (S == 60)
                {
                    m++;
                    label12.Text = m.ToString();
                    S = 0;
                }
                if (m == 59)
                {
                    h++;
                    label11.Text = h.ToString();
                    m = 0;
                }
                if (h == count)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Show();
                    Console.Beep(500, 900);
                    this.TopMost = true;
                    this.TopMost = false;
                    groupBox1.Visible = true;
                    label4.Visible = true;
                    label3.Visible = true;
                    h = 0;
                    m = 0;
                    S = 0;
                    label11.Text = h.ToString();
                    label12.Text = m.ToString();
                    label10.Text = S.ToString();
                    timer1.Enabled = false;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (count == 5)
            {
                button3.Enabled = false;
                button4.Enabled = true;
            }
            if (count >= 5)
            {
                button4.Enabled = true;
                button3.Enabled = true;
                count = count - 5;
                textBox1.Text = count.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (count >= 60)
            {
                button4.Enabled = false;
                button3.Enabled = true;
            }

            else
            {
                count = count + 5;
                textBox1.Text = count.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
        }

        private void notifyIcon1_DoubleClick_1(object sender, EventArgs e)
        {
            this.Show();         
            this.WindowState = FormWindowState.Normal;
        }

    }
}
