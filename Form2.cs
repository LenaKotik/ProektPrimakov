using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += (object sender, EventArgs e)=>{Close();};
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Location = new Point(550, pictureBox1.Location.Y);
            Location = Program.mainForm.Location;
            FormClosed += (object sender, FormClosedEventArgs e) => { Program.mainForm.Show(); };
        }
        public Form2(string data, Image image) : this()
        {
            pictureBox1.Image = image;
            string[] vs = data.Split('\n');
            int i = 0;
            foreach(string str in vs)
            {
                int sep = 18;
                Label label = new Label();
                this.Controls.Add(label);
                label.Text = str;
                label.AutoSize = true;
                label.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Italic);
                label.Location = new Point(5, 200 + (int)(sep * 1.5 * i));
                label.Show();
                i++;
            }
        }
    }
}
