
namespace Project_Employee_Portal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datetime = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clocktext = new System.Windows.Forms.Label();
            this.empid1 = new System.Windows.Forms.TextBox();
            this.lastname1 = new System.Windows.Forms.TextBox();
            this.firstname1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_datetime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.empid2 = new System.Windows.Forms.Label();
            this.currHours = new System.Windows.Forms.Label();
            this.weektotalHour = new System.Windows.Forms.Label();
            this.sickleave1 = new System.Windows.Forms.Label();
            this.vaca1 = new System.Windows.Forms.Label();
            this.ytdhours1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.welcome01 = new System.Windows.Forms.Label();
            this.savetime = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Location = new System.Drawing.Point(593, 43);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(0, 13);
            this.datetime.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 438);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.lb_datetime);
            this.tabPage1.Controls.Add(this.clocktext);
            this.tabPage1.Controls.Add(this.empid1);
            this.tabPage1.Controls.Add(this.lastname1);
            this.tabPage1.Controls.Add(this.firstname1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // clocktext
            // 
            this.clocktext.AutoSize = true;
            this.clocktext.Location = new System.Drawing.Point(342, 351);
            this.clocktext.Name = "clocktext";
            this.clocktext.Size = new System.Drawing.Size(0, 18);
            this.clocktext.TabIndex = 21;
            // 
            // empid1
            // 
            this.empid1.Location = new System.Drawing.Point(397, 235);
            this.empid1.Name = "empid1";
            this.empid1.Size = new System.Drawing.Size(100, 25);
            this.empid1.TabIndex = 20;
            // 
            // lastname1
            // 
            this.lastname1.Location = new System.Drawing.Point(397, 176);
            this.lastname1.Name = "lastname1";
            this.lastname1.Size = new System.Drawing.Size(100, 25);
            this.lastname1.TabIndex = 19;
            // 
            // firstname1
            // 
            this.firstname1.Location = new System.Drawing.Point(397, 118);
            this.firstname1.Name = "firstname1";
            this.firstname1.Size = new System.Drawing.Size(100, 25);
            this.firstname1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clock Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clock In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Portal";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.Controls.Add(this.savetime);
            this.tabPage2.Controls.Add(this.welcome01);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ytdhours1);
            this.tabPage2.Controls.Add(this.vaca1);
            this.tabPage2.Controls.Add(this.sickleave1);
            this.tabPage2.Controls.Add(this.weektotalHour);
            this.tabPage2.Controls.Add(this.currHours);
            this.tabPage2.Controls.Add(this.empid2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time Keeping";
            // 
            // lb_datetime
            // 
            this.lb_datetime.AutoSize = true;
            this.lb_datetime.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datetime.Location = new System.Drawing.Point(30, 342);
            this.lb_datetime.Name = "lb_datetime";
            this.lb_datetime.Size = new System.Drawing.Size(0, 29);
            this.lb_datetime.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time Keeping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Today\'s Hours:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Week\'s Total Hours:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Employee ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sick Leave:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Vacation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "YTD Hours Worked:";
            // 
            // empid2
            // 
            this.empid2.AutoSize = true;
            this.empid2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid2.Location = new System.Drawing.Point(143, 92);
            this.empid2.Name = "empid2";
            this.empid2.Size = new System.Drawing.Size(0, 21);
            this.empid2.TabIndex = 7;
            // 
            // currHours
            // 
            this.currHours.AutoSize = true;
            this.currHours.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currHours.Location = new System.Drawing.Point(159, 139);
            this.currHours.Name = "currHours";
            this.currHours.Size = new System.Drawing.Size(0, 21);
            this.currHours.TabIndex = 8;
            // 
            // weektotalHour
            // 
            this.weektotalHour.AutoSize = true;
            this.weektotalHour.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weektotalHour.Location = new System.Drawing.Point(232, 187);
            this.weektotalHour.Name = "weektotalHour";
            this.weektotalHour.Size = new System.Drawing.Size(33, 21);
            this.weektotalHour.TabIndex = 9;
            this.weektotalHour.Text = "40";
            // 
            // sickleave1
            // 
            this.sickleave1.AutoSize = true;
            this.sickleave1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sickleave1.Location = new System.Drawing.Point(133, 240);
            this.sickleave1.Name = "sickleave1";
            this.sickleave1.Size = new System.Drawing.Size(33, 21);
            this.sickleave1.TabIndex = 10;
            this.sickleave1.Text = "40";
            // 
            // vaca1
            // 
            this.vaca1.AutoSize = true;
            this.vaca1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaca1.Location = new System.Drawing.Point(114, 283);
            this.vaca1.Name = "vaca1";
            this.vaca1.Size = new System.Drawing.Size(33, 21);
            this.vaca1.TabIndex = 11;
            this.vaca1.Text = "40";
            // 
            // ytdhours1
            // 
            this.ytdhours1.AutoSize = true;
            this.ytdhours1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ytdhours1.Location = new System.Drawing.Point(193, 333);
            this.ytdhours1.Name = "ytdhours1";
            this.ytdhours1.Size = new System.Drawing.Size(41, 21);
            this.ytdhours1.TabIndex = 12;
            this.ytdhours1.Text = "180";
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Employee:";
            // 
            // welcome01
            // 
            this.welcome01.AutoSize = true;
            this.welcome01.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome01.Location = new System.Drawing.Point(499, 92);
            this.welcome01.Name = "welcome01";
            this.welcome01.Size = new System.Drawing.Size(0, 21);
            this.welcome01.TabIndex = 14;
            // 
            // savetime
            // 
            this.savetime.Location = new System.Drawing.Point(400, 330);
            this.savetime.Name = "savetime";
            this.savetime.Size = new System.Drawing.Size(99, 23);
            this.savetime.TabIndex = 15;
            this.savetime.Text = "Save Time";
            this.savetime.UseVisualStyleBackColor = true;
            this.savetime.Click += new System.EventHandler(this.savetime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.datetime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label clocktext;
        private System.Windows.Forms.TextBox empid1;
        private System.Windows.Forms.TextBox lastname1;
        private System.Windows.Forms.TextBox firstname1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_datetime;
        private System.Windows.Forms.Label empid2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ytdhours1;
        private System.Windows.Forms.Label vaca1;
        private System.Windows.Forms.Label sickleave1;
        private System.Windows.Forms.Label weektotalHour;
        private System.Windows.Forms.Label currHours;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label welcome01;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button savetime;
    }
}

