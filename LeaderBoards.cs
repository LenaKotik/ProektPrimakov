using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Project
{
    public partial class LeaderBoards : Form
    {
        public LeaderBoards()
        {
            InitializeComponent();
            this.buttonExit.Location = new Point(this.buttonExit.Location.X + 400, this.buttonExit.Location.Y);
            this.FormClosing += (object sender, FormClosingEventArgs e) => { Program.mainForm.Show(); };
            this.FormBorderStyle = 0;//None
            this.WindowState = FormWindowState.Maximized;
            PrintResponse();
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
        }
        async void PrintResponse()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://historyserver20211206012050.azurewebsites.net/Home/Table/0";
                try
                {
                    var msg = await client.GetStreamAsync(url);
                    List<Student> students = await JsonSerializer.DeserializeAsync<List<Student>>(msg);
                    dataGridView1.DataSource = (students.Count > 20) ? students.GetRange(0,20) : students;
                }
                catch
                {
                    MessageBox.Show("Не удалось получить данные с сервера", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
