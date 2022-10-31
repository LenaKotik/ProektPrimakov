using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Linq;

namespace Project
{
    public partial class Quiz : Form
    {
        int left = 60*1000;
        int value = 0;
        string correct;
        Button[] butts;
        Dictionary<string, int> quizData;
        int num;
        public Quiz()
        {
            InitializeComponent();
            timer1.Tick += Update;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.label1.Location = new Point(this.label1.Location.X + 150, this.label1.Location.Y + 150);
            this.label2.Location = new Point(this.label2.Location.X, this.label2.Location.Y + 400);
            this.label3.Location = new Point(this.label3.Location.X + 550, this.label3.Location.Y + 400);
            butts = new Button[4] { button1, button2, button3, button4 };
            foreach (Button b in butts)
            {
                b.Location = new Point(b.Location.X + 150, b.Location.Y + 250);
            }
        }
        public Quiz(Dictionary<string, int> quizData, int time, int num) : this()
        {
            timeleft.BackColor = Color.Transparent;
            label2.BackColor = Color.FromArgb(150, Color.White);
            label3.BackColor = Color.Transparent;
            this.num = num;
            label3.Text = $"{num}/10";
            this.quizData = quizData;
            string data = quizData.Keys.First();
            int value = quizData[data];
            this.value = value;
            quizData.Remove(data);
            label2.Text = (value == 1) ? "задание на 1 балл" : (value == 5) ? "задание на 5 баллов" : $"задание на {value} балла";
            left = time*1000;
            progressBar1.Maximum = left / 100;
            progressBar1.Value = left / 100;
            label1.Text = data.Split(':')[0];
            correct = data.Split(':')[1].Split(';')[0];
            foreach (Button b in butts)
            {
                b.Text = "";
                b.Click += OnClick;
                b.BackColor = Color.Linen;
            }
            Random R = new Random(DateTime.Now.Second);
            foreach (string a in data.Split(':')[1].Split(';'))
            {
                int i = R.Next(4);
                while (butts[i].Text != "")
                    i = R.Next(4);
                butts[i].Text = a;
            }
        }
        void OnClick(object sender, EventArgs e)
            {
            foreach (Button b in butts)
            {
                b.Click -= OnClick;
            }
                Button but = (Button)sender;
                if (but.Text == correct)
                {
                    but.BackColor = Color.LimeGreen;
                    Program.score += this.value;
                }
                else
                {
                    but.BackColor = Color.Red;
                    foreach (Button butn in butts)
                    {
                        if (butn.Text == correct)
                        {
                            butn.BackColor = Color.LimeGreen;
                        }
                    }
                }
            }
        void Update(object sender, EventArgs e)
        {
            left -= 100;
            progressBar1.PerformStep();
            timeleft.Text = ((int)(left / 1000)).ToString();
            if (left == 0)
            {
                Finished();
            }
        }
        void Finished()
        {
            if (quizData.Count == 0)
            {
                Result r = new Result();
                r.Show();
            }
            else
            {
                Quiz q = new Quiz(quizData, 15, num+1);
                q.Show();
            }
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.score = 0;
            Program.mainForm.Show();
            this.Close();
        }
    }
}
