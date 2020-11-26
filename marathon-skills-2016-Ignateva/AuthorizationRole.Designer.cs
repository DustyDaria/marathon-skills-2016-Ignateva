namespace marathon_skills_2016_Ignateva
{
    partial class AuthorizationRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunner = new System.Windows.Forms.Button();
            this.btnCoordinator = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ТОЛЬКО ДЛЯ ТЕСТИРОВНАИЯ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Под каким пользователем вы хотите войти в систему?";
            // 
            // btnRunner
            // 
            this.btnRunner.Location = new System.Drawing.Point(309, 141);
            this.btnRunner.Name = "btnRunner";
            this.btnRunner.Size = new System.Drawing.Size(174, 23);
            this.btnRunner.TabIndex = 2;
            this.btnRunner.Text = "Бегун";
            this.btnRunner.UseVisualStyleBackColor = true;
            this.btnRunner.Click += new System.EventHandler(this.btnRunner_Click);
            // 
            // btnCoordinator
            // 
            this.btnCoordinator.Location = new System.Drawing.Point(309, 212);
            this.btnCoordinator.Name = "btnCoordinator";
            this.btnCoordinator.Size = new System.Drawing.Size(174, 23);
            this.btnCoordinator.TabIndex = 3;
            this.btnCoordinator.Text = "Координатор";
            this.btnCoordinator.UseVisualStyleBackColor = true;
            this.btnCoordinator.Click += new System.EventHandler(this.btnCoordinator_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(309, 297);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(174, 23);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Администратор";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // AuthorizationRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCoordinator);
            this.Controls.Add(this.btnRunner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationRole";
            this.Text = "AuthorizationRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunner;
        private System.Windows.Forms.Button btnCoordinator;
        private System.Windows.Forms.Button btnAdmin;
    }
}