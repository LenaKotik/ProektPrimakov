
namespace Project
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.label1 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.relative = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Твоя оценка:";
            // 
            // grade
            // 
            this.grade.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grade.ForeColor = System.Drawing.Color.ForestGreen;
            this.grade.Location = new System.Drawing.Point(315, 46);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(177, 136);
            this.grade.TabIndex = 1;
            this.grade.Text = "6";
            this.grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.percent.ForeColor = System.Drawing.Color.Navy;
            this.percent.Location = new System.Drawing.Point(489, 37);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(69, 37);
            this.percent.TabIndex = 2;
            this.percent.Text = "69%";
            // 
            // relative
            // 
            this.relative.AutoSize = true;
            this.relative.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.relative.ForeColor = System.Drawing.Color.Navy;
            this.relative.Location = new System.Drawing.Point(582, 37);
            this.relative.Name = "relative";
            this.relative.Size = new System.Drawing.Size(88, 37);
            this.relative.TabIndex = 3;
            this.relative.Text = "50/24";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(315, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTxt.Location = new System.Drawing.Point(20, 15);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PlaceholderText = "Введи имя";
            this.NameTxt.Size = new System.Drawing.Size(180, 29);
            this.NameTxt.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.Location = new System.Drawing.Point(20, 65);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(180, 34);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Отправить результат";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Location = new System.Drawing.Point(274, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 119);
            this.panel1.TabIndex = 7;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::Project.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.relative);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Result";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label relative;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panel1;
    }
}