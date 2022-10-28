using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
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
            /* works no longer, sadly
               using (HttpClient client = new HttpClient())
               {
                   string url = "https://historyserver20211206012050.azurewebsites.net/Home/Table?n=0";
                   try
                   {
                       var msg = await client.GetStreamAsync(url);
                       List<DisplayModel> students = DisplayModel.Parse(await JsonSerializer.DeserializeAsync<List<Student>>(msg));
                       dataGridView1.DataSource = (students.Count > 20) ? students.GetRange(0,20) : students;
                   }
                   catch
                   {
                       MessageBox.Show("Не удалось получить данные с сервера", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   } 
               }
            */
            string localTablePath = "LocalSave.txt";
            if (!File.Exists(localTablePath)) return;
            try
            {
                string text = File.ReadAllText(localTablePath);
                List<DisplayModel> students = DisplayModel.Parse(text.Split(';'));
                dataGridView1.DataSource = (students.Count > 20) ? students.GetRange(0, 20) : students;
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось получить данные с диска " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    class DisplayModel
    {
        public string Имя { set; get; }
        public DateTime Дата { set; get; }
        public int Результат { set; get; }

        public static List<DisplayModel> Parse(List<Student> students)
        {
            List<DisplayModel> res = new List<DisplayModel>();
            DoubleEncoding decoder = new DoubleEncoding();
            foreach (Student s in students)
            {
                DisplayModel dm = new DisplayModel();
                dm.Дата = s.Date.ToLocalTime();
                dm.Имя = decoder.Decode(s.Name);
                dm.Результат = s.Result;
                res.Add(dm);
            }
            return res;
        }
        public static List<DisplayModel> Parse(IEnumerable<string> str)
        {
            List<DisplayModel> res = new List<DisplayModel>();
            DoubleEncoding decoder = new DoubleEncoding();
            foreach (string s in str)
            {
                if (s == "") continue;
                string[] splits = s.Split(',');
                DisplayModel dm = new DisplayModel();
                dm.Имя = decoder.Decode(splits[0]);
                dm.Результат = int.Parse(splits[1]);
                dm.Дата = DateTime.Parse(splits[2]);
                res.Add(dm);
            }
            return res;
        }
    }
}
