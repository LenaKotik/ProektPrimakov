using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Node : UserControl
    {
        public event MouseEventHandler MyClick;
        void CallMyClick(object sender, MouseEventArgs e)
        {
            this.MyClick?.Invoke(this, e);
        }
        public Node()
        {
            InitializeComponent();
            this.MouseEnter += this.OnMouseEnter;
            this.pictureBox1.MouseEnter += this.OnMouseEnter;
            this.label1.MouseEnter += this.OnMouseEnter;
            this.label2.MouseEnter += this.OnMouseEnter;
            this.MouseLeave += this.OnMouseLeave;
            this.pictureBox1.MouseLeave += this.OnMouseLeave;
            this.label1.MouseLeave += this.OnMouseLeave;
            this.label2.MouseLeave += this.OnMouseLeave;
            this.MouseClick += CallMyClick;
            this.label1.MouseClick += CallMyClick;
            this.label2.MouseClick += CallMyClick;
            this.pictureBox1.MouseClick += CallMyClick;
        }
        public Image Image { set => this.pictureBox1.Image = value; get => this.pictureBox1.Image; }
        public string DisplayName { set => label1.Text = value; get => this.label1.Text; }
        public string Date { set => label2.Text = value; }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 128);
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(205, 142, 78);
        }
    }
}
