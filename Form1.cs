using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int S = 0;
        int M = 0;
        int H = 0;
        int Record = 1;
        bool Toggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++S;
            if (S == 60)
            {
                S = 0;
                ++M;
                if (M == 60)
                {
                    M = 0;
                    ++H;
                    if(H == 24)
                    {
                        timer1.Stop();
                        Toggle = false;
                    }
                }
            }
            lab_All.Text = $"{string.Format("{0:D2}", H)}:{string.Format("{0:D2}", M)}:{string.Format("{0:D2}", S)}";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                Toggle = false;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Stop();
                H = 0;
                M = 0;
                S = 0;
                lab_All.Text = $"{string.Format("{0:D2}", H)}:{string.Format("{0:D2}", M)}:{string.Format("{0:D2}", S)}";
                lab_Record1.Text = "";
                lab_Record2.Text = "";
                lab_Record3.Text = "";
            }

            else MessageBox.Show("타이머를 정지해주세요!", "에러");
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            if (Record < 11)
            {
                lab_Record1.Text += $"{string.Format("{0:D2}", Record)}. {string.Format("{0:D2}", H)}:{string.Format("{0:D2}", M)}:{string.Format("{0:D2}", S)}\n";
                ++Record;
            }

            else if (Record < 21)
            {
                lab_Record2.Text += $"{string.Format("{0:D2}", Record)}. {string.Format("{0:D2}", H)}:{string.Format("{0:D2}", M)}:{string.Format("{0:D2}", S)}\n";
                ++Record;
            }

            else if (Record < 31)
            {
                lab_Record3.Text += $"{string.Format("{0:D2}", Record)}. {string.Format("{0:D2}", H)}:{string.Format("{0:D2}", M)}:{string.Format("{0:D2}", S)}\n";
                ++Record;
            }

            else MessageBox.Show("기록 가능한 개수를 초과했습니다.", "에러");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
