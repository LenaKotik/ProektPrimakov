using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> quizData = new Dictionary<string, int>();
        void QuizInit()
        {
            quizData.Add("Какой высший орган власти создала Екатерина I\nв помощь себе для управления государством?:Верховный Тайный совет;Отряд Меншикова;Тайная Канцелярия;Святейший Синод", 2);
            quizData.Add("Кто сменил Петра II на Русском престоле?:Анна Иоановна;Иван Грозный;Петр III;Ярополк", 1);
            quizData.Add("Укажите годы правления Екатерины I:1725-1727;1724-1725;1727-1730;1725-1726", 2);
            quizData.Add("Кто изначально стал регентом при Иване VI?:Бирон;Меншиков;Анна Иоановна;Ломоносов", 3);
            quizData.Add("Кто из правителей создал Академию наук?:Екатерина I;Петр I;Екатерина II;Елизавета Петровна", 2);
            quizData.Add("Что является одной из многих предпосылок для\nначала дворцовых переворотов?:Указ о престолонаследии;Смерть Алексея Михайловича;Русско-Шведская война;Табель о рангах(1722)", 3);
            quizData.Add("Почему русский народ не был в восторге от\nвосшествия на престол Петра III?:Он не был патриотом своей страны;Он был женат на своей сестре;Он был слабоумным;Екатерина I была лучше по их мнению", 1);
            quizData.Add("Укажите верную дату участия России в\nСемилетней войне.:1757-1762;1757-1764;1756-1761;1761-1762", 3);
            quizData.Add("Востановите цепочку правителей в эпоху\nдворцовых переворотов \"ЕкатеринаI -> ... -> Анна Иоановна\n-> ИванVI -> ... -> ПетрIII\":ПетрII,Елизавета Петровна;ЕкатеринаII,Миних;Бирон,ПетрII;ПетрII,Бирон", 5);
            quizData.Add("При каком правителе Россия вышла из\nСемилетней войны?:ПетрIII;ИванVI;Елизавета Петровна;ИванIV", 2);// 24 max
        }
        public Form1()
        {
            InitializeComponent();
            #region Node Initialization
            nodeAlM.Image = Properties.Resources.AlehzeyMich;
            nodeAlM.DisplayName = "Алексей Михайлович";
            nodeAlM.Date = "";
            nodeAlM.Location = new Point(nodeAlM.Location.X + 300, nodeAlM.Location.Y);
            nodeAnI.Image = Properties.Resources.AnneIoanovna;
            nodeAnI.DisplayName = "Анна Иоановна";
            nodeAnI.Date = "1730-1740";
            nodeAnI.MyClick += OnClick;
            nodeAl.Image = Properties.Resources.AlehzeyPetrovi4;
            nodeAl.DisplayName = "Алексей Петрович";
            nodeAl.Date = "";
            nodeE1.Image = Properties.Resources.Ekaterine1;
            nodeE1.DisplayName = "Екатерина I";
            nodeE1.Date = "1725-1727";
            nodeE1.MyClick += OnClick;
            nodeE1.Location = new Point(nodeE1.Location.X + 300, nodeE1.Location.Y);
            nodeAn.Image = Properties.Resources.AnnePetrovna;
            nodeAn.DisplayName = "Анна Петровна";
            nodeAn.Date = "";
            node1.Image = Properties.Resources.Ivan6;
            node1.DisplayName = "Иван VI";
            node1.Date = "1740-1741";
            node1.MyClick += OnClick;
            nodeAnL.Image = Properties.Resources.AnneLeo;
            nodeAnL.DisplayName = "Анна Леопольдовна";
            nodeAnL.Date = "";
            nodeE.Image = Properties.Resources.EkaterineIoanovna;
            nodeE.DisplayName = "Екатерина Иоановна";
            nodeE.Date = "";
            nodeE2.Image = Properties.Resources.Ekaterine2;
            nodeE2.DisplayName = "Екатерина II";
            nodeE2.Date = "1762-1796";
            nodeE2.Location = new Point(nodeE2.Location.X + 100, nodeE2.Location.Y);
            //nodeE2.MyClick += OnClick;
            nodeEl.Image = Properties.Resources.ElizabethPetrovna;
            nodeEl.DisplayName = "Елизавета Петровна";
            nodeEl.Date = "1740-1761";
            nodeEl.MyClick += OnClick;
            nodeEvL.Image = Properties.Resources.EvdokiaLopukhina;
            nodeEvL.DisplayName = "Евдокия Лопухина";
            nodeEvL.Date = "";
            nodeI5.Image = Properties.Resources.Ivan5;
            nodeI5.DisplayName = "Иван V";
            nodeI5.Date = "1682-1696";
            nodeMaM.Image = Properties.Resources.MariaMilosl;
            nodeMaM.DisplayName = "Мария Милославская";
            nodeMaM.Date = "";
            nodeNaN.Image = Properties.Resources.NataliaNarish;
            nodeNaN.DisplayName = "Наталья Нарыжкина";
            nodeNaN.Date = "";
            nodeNaN.Location = new Point(nodeNaN.Location.X + 300, nodeNaN.Location.Y);
            nodeP1.Image = Properties.Resources.Petr1;
            nodeP1.DisplayName = "Пётр I";
            nodeP1.Date = "1682-1725";
            nodeP1.Location = new Point(nodeP1.Location.X + 200, nodeP1.Location.Y);
            //nodeP1.MyClick += OnClick;
            nodeP2.Image = Properties.Resources.Petr2;
            nodeP2.DisplayName = "Пётр II";
            nodeP2.Date = "1727-1730";
            nodeP2.MyClick += OnClick;
            nodeP3.Image = Properties.Resources.Petr3;
            nodeP3.DisplayName = "Пётр III";
            nodeP3.Date = "1761-1762";
            nodeP3.MyClick += OnClick;
            #endregion
            this.buttonExit.Location = new Point(this.buttonExit.Location.X+375,this.buttonExit.Location.Y);
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            QuizInit();
            this.Paint += this.Draw;
            quiz.Click += this.Quiz;
            quiz.Cursor = Cursors.Hand;
            info.Click += (object sender, EventArgs e) => { MessageBox.Show("Проект выполнили Примак Олег и Марсакова Полина", "info", MessageBoxButtons.OK, MessageBoxIcon.Information); };
        }
        private void Quiz(object sender, EventArgs e)
        {
            if (quizData.Count == 0) QuizInit();
            Random R = new Random(DateTime.Now.Second);
            quizData = quizData.OrderBy(x => { return R.Next(); })
                .ToDictionary(item => item.Key, item => item.Value);
            this.Hide();
            Quiz q = new Quiz(quizData, 15, 1);
            q.Show();
        }
        private void Draw(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(255, 192, 128), 5);
            Graphics G = e.Graphics;
            G.DrawLine(p, nodeAlM.Location.X, nodeAlM.Location.Y + 75, nodeMaM.Location.X + 150, nodeAlM.Location.Y + 75);
            G.DrawLine(p, nodeAlM.Location.X + 150, nodeAlM.Location.Y + 75, nodeNaN.Location.X, nodeAlM.Location.Y + 75);
            G.DrawLine(p, nodeI5.Location.X + 75, nodeI5.Location.Y, nodeI5.Location.X + 75, nodeMaM.Location.Y + 75);
            G.DrawLine(p, nodeP1.Location.X + 75, nodeP1.Location.Y, nodeP1.Location.X + 75, nodeMaM.Location.Y + 75);
            G.DrawLine(p, nodeI5.Location.X, nodeI5.Location.Y + 75, nodeAnI.Location.X + 75, nodeI5.Location.Y+75);
            G.DrawLine(p, nodeAnI.Location.X + 75, nodeI5.Location.Y + 75, nodeAnI.Location.X + 75, nodeAnI.Location.Y);
            G.DrawLine(p, nodeI5.Location.X + 75, nodeI5.Location.Y + 150, nodeI5.Location.X + 75, nodeE.Location.Y);
            G.DrawLine(p, nodeE.Location.X + 75, nodeE.Location.Y + 150, nodeE.Location.X + 75, nodeAnL.Location.Y);
            G.DrawLine(p, nodeAnL.Location.X + 75, nodeAnL.Location.Y + 150, nodeAnL.Location.X + 75, node1.Location.Y);
            G.DrawLine(p, nodeP1.Location.X, nodeP1.Location.Y + 75, nodeEvL.Location.X + 150, nodeEvL.Location.Y + 75);
            G.DrawLine(p, nodeP1.Location.X + 150, nodeP1.Location.Y + 75, nodeE1.Location.X, nodeE1.Location.Y + 75);
            G.DrawLine(p, nodeP1.Location.X - (nodeP1.Location.X - (nodeEvL.Location.X + 150)) / 2, nodeEvL.Location.Y + 75, nodeP1.Location.X - (nodeP1.Location.X - (nodeEvL.Location.X + 150)) / 2, nodeP1.Location.Y + 175);
            G.DrawLine(p, nodeP1.Location.X - (nodeP1.Location.X - (nodeEvL.Location.X + 150)) / 2+3, nodeP1.Location.Y + 175, nodeAl.Location.X + 75, nodeP1.Location.Y + 175);
            G.DrawLine(p, nodeAl.Location.X + 75, nodeAl.Location.Y, nodeAl.Location.X + 75, nodeAl.Location.Y - 25);
            G.DrawLine(p, nodeP1.Location.X + 150 - (nodeP1.Location.X + 150 - nodeE1.Location.X) / 2, nodeP1.Location.Y + 75, nodeP1.Location.X + 150 - (nodeP1.Location.X + 150 - nodeE1.Location.X) / 2, nodeP1.Location.Y + 175);
            G.DrawLine(p, nodeP1.Location.X + 150 - (nodeP1.Location.X + 150 - nodeE1.Location.X) / 2, nodeP1.Location.Y + 175, nodeAn.Location.X + 75, nodeP1.Location.Y + 175);
            G.DrawLine(p, nodeP1.Location.X + 150 - (nodeP1.Location.X + 150 - nodeE1.Location.X) / 2, nodeP1.Location.Y + 175, nodeEl.Location.X + 75, nodeP1.Location.Y + 175);
            G.DrawLine(p, nodeAn.Location.X + 75, nodeP1.Location.Y + 175, nodeAn.Location.X + 75, nodeAn.Location.Y);
            G.DrawLine(p, nodeEl.Location.X + 75, nodeP1.Location.Y + 175, nodeEl.Location.X + 75, nodeEl.Location.Y);
            G.DrawLine(p, nodeAl.Location.X + 75, nodeAl.Location.Y + 150, nodeAl.Location.X + 75, nodeP2.Location.Y);
            G.DrawLine(p, nodeAn.Location.X + 75, nodeAn.Location.Y + 150, nodeAn.Location.X + 75, nodeP3.Location.Y);
            G.DrawLine(p, nodeP3.Location.X + 150, nodeP3.Location.Y + 75, nodeE2.Location.X, nodeE2.Location.Y + 75);
        }
        private void OnClick(object sender, MouseEventArgs e)
        {
            string data = Properties.Resources.ResourceManager.GetString(((Node)sender).DisplayName, Properties.Resources.Culture);
            Form2 f2 = new Form2(data, ((Node)sender).Image);
            f2.Text = ((Node)sender).DisplayName;
            f2.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            LeaderBorads l = new LeaderBorads();
            l.Show();
            this.Hide();
        }
    }
}
