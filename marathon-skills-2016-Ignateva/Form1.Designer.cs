namespace marathon_skills_2016_Ignateva
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunner = new System.Windows.Forms.Button();
            this.btnSponsorship = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelTestYear = new System.Windows.Forms.Label();
            this.labelTestMounth = new System.Windows.Forms.Label();
            this.labelTestDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(374, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS 2016";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(438, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Москва, Россия\r\nсреда 23 декабря 2020";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunner
            // 
            this.btnRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunner.Location = new System.Drawing.Point(335, 241);
            this.btnRunner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunner.Name = "btnRunner";
            this.btnRunner.Size = new System.Drawing.Size(450, 80);
            this.btnRunner.TabIndex = 2;
            this.btnRunner.Text = "Я хочу стать бегуном";
            this.btnRunner.UseVisualStyleBackColor = true;
            this.btnRunner.Click += new System.EventHandler(this.btnRunner_Click);
            // 
            // btnSponsorship
            // 
            this.btnSponsorship.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSponsorship.Location = new System.Drawing.Point(335, 357);
            this.btnSponsorship.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSponsorship.Name = "btnSponsorship";
            this.btnSponsorship.Size = new System.Drawing.Size(450, 80);
            this.btnSponsorship.TabIndex = 3;
            this.btnSponsorship.Text = "Я хочу стать спонсором бегуна";
            this.btnSponsorship.UseVisualStyleBackColor = true;
            this.btnSponsorship.Click += new System.EventHandler(this.btnSponsorship_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuest.Location = new System.Drawing.Point(335, 461);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(450, 80);
            this.btnGuest.TabIndex = 4;
            this.btnGuest.Text = "Я хочу узнать больше о событии";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(975, 533);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(509, 591);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(46, 17);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "label4";
            // 
            // labelTestYear
            // 
            this.labelTestYear.AutoSize = true;
            this.labelTestYear.Location = new System.Drawing.Point(70, 480);
            this.labelTestYear.Name = "labelTestYear";
            this.labelTestYear.Size = new System.Drawing.Size(46, 17);
            this.labelTestYear.TabIndex = 8;
            this.labelTestYear.Text = "label4";
            // 
            // labelTestMounth
            // 
            this.labelTestMounth.AutoSize = true;
            this.labelTestMounth.Location = new System.Drawing.Point(70, 539);
            this.labelTestMounth.Name = "labelTestMounth";
            this.labelTestMounth.Size = new System.Drawing.Size(46, 17);
            this.labelTestMounth.TabIndex = 9;
            this.labelTestMounth.Text = "label4";
            // 
            // labelTestDay
            // 
            this.labelTestDay.AutoSize = true;
            this.labelTestDay.Location = new System.Drawing.Point(70, 591);
            this.labelTestDay.Name = "labelTestDay";
            this.labelTestDay.Size = new System.Drawing.Size(46, 17);
            this.labelTestDay.TabIndex = 10;
            this.labelTestDay.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 659);
            this.Controls.Add(this.labelTestDay);
            this.Controls.Add(this.labelTestMounth);
            this.Controls.Add(this.labelTestYear);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnSponsorship);
            this.Controls.Add(this.btnRunner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunner;
        private System.Windows.Forms.Button btnSponsorship;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelTestYear;
        private System.Windows.Forms.Label labelTestMounth;
        private System.Windows.Forms.Label labelTestDay;
    }
}

