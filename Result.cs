using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace Project
{
    public partial class Result : Form
    {
        float p;
        public Result()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.button1.Location = new Point(this.button1.Location.X + 300, this.button1.Location.Y + 300);
            this.label1.Location = new Point(this.label1.Location.X + 300, this.label1.Location.Y);
            this.grade.Location = new Point(this.grade.Location.X + 300, this.grade.Location.Y);
            this.relative.Location = new Point(this.relative.Location.X + 300, this.relative.Location.Y);
            panel1.BackColor = Color.FromArgb(150, Color.White);
            relative.BackColor = Color.FromArgb(150, Color.White);
            grade.BackColor = Color.FromArgb(150, Color.White);
            label1.BackColor = Color.FromArgb(150, Color.White);
            percent.BackColor = Color.FromArgb(150, Color.White);
            button1.Click += (object sender, EventArgs e) => { Program.mainForm.Show(); this.Close(); Program.score = 0; };
            buttonSend.Click += Send;
            p = Program.score / 24.0f;
            percent.Text = ((int)(p * 100)).ToString() + "%";
            relative.Text = $"{Program.score}/24";
            grade.Text = (Math.Round(p / 2 * 10, MidpointRounding.ToPositiveInfinity)).ToString();
        }
        async void Send(object sender, EventArgs e)
        {
            if (this.NameTxt.Text.Length < 3 || this.NameTxt.Text.Length > 30)
            {
                MessageBox.Show("Имя должно быть не короче 3 символов и не длинее 30 символов", "Неправильное имя", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            DoubleEncoding encoder = new DoubleEncoding();
            Student s = new Student();
            s.Name = encoder.Encode(this.NameTxt.Text);
            s.Result = (int)(p * 100);
            string url = "https://historyserver20211206012050.azurewebsites.net/send";
            using HttpClient client = new HttpClient();
            {
                try
                {
                    Dictionary<string, string> d = new Dictionary<string, string>()
                    {
                        { "name", s.Name },
                        { "result",s.Result.ToString() } 
                    };
                    var content = new FormUrlEncodedContent(d);
                    await client.PostAsync(url, content);
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Неудалось отправить данные: \n{exc.Message}", $"{exc.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Отправлено успешно!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
