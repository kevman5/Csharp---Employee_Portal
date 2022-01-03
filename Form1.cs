using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Diagnostics;
using System.IO;
// using Timer = System.Windows.Forms.Timer;

namespace Project_Employee_Portal
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        public Form1()
        {
            InitializeComponent();
            lb_datetime.Text = DateTime.Now.ToString();
            
        }

        private void time_keep(object sender, EventArgs e)
        {
            //int sick = 40;
            //int vaca = 25;
            //int prevweekhr = 40;
            // timer1 = Textbox1.Text;
            weektotalHour.Text = 40.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string fname, lname, empid;
            fname = firstname1.Text;
            lname = lastname1.Text;
            empid = empid1.Text;
            sw = new Stopwatch();
            timer1.Start();
            sw.Start();
            empid2.Text = empid;
            welcome01.Text = fname + " " + lname;
            MessageBox.Show(fname + " " + lname + " " + "Has Successfully Clocked In!");
            firstname1.Clear();
            lastname1.Clear();
            empid1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname, lname, empid;
            fname = firstname1.Text;
            lname = lastname1.Text;
            empid = empid1.Text;
           
            timer1.Stop();
            sw.Stop();
            currHours.Text = sw.Elapsed.Hours.ToString() + " " + "Hours," + " " + sw.Elapsed.Minutes.ToString() + " Minutes," + " " + sw.Elapsed.Seconds.ToString() + " Seconds";
            
            MessageBox.Show(fname + " " + lname + " " + "Has Successfully Clocked Out!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void savetime_Click(object sender, EventArgs e)
        {
            String textFile = "c://time_keeping.csv";
            String path = @"C://time_keeping.csv";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("File Created");
                }
            }
            String time_keeping1;
            time_keeping1 = firstname1.Text;

            time_keeping1 = time_keeping1 + ", " + lastname1.Text;
            time_keeping1 = time_keeping1 + ", " + empid1.Text;
            time_keeping1 = time_keeping1 + ", " + currHours.Text;
           

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(time_keeping1);
            }

            lastname1.Clear();
            empid1.Clear();
            
        }
    }
}
