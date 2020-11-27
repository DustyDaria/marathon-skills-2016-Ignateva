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
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(132, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ТОЛЬКО ДЛЯ ТЕСТИРОВНАИЯ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Под каким пользователем вы хотите\r\nвойти в систему?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunner
            // 
            this.btnRunner.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunner.Location = new System.Drawing.Point(164, 226);
            this.btnRunner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunner.Name = "btnRunner";
            this.btnRunner.Size = new System.Drawing.Size(250, 50);
            this.btnRunner.TabIndex = 2;
            this.btnRunner.Text = "Бегун";
            this.btnRunner.UseVisualStyleBackColor = true;
            this.btnRunner.Click += new System.EventHandler(this.btnRunner_Click);
            // 
            // btnCoordinator
            // 
            this.btnCoordinator.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoordinator.Location = new System.Drawing.Point(164, 323);
            this.btnCoordinator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCoordinator.Name = "btnCoordinator";
            this.btnCoordinator.Size = new System.Drawing.Size(250, 50);
            this.btnCoordinator.TabIndex = 3;
            this.btnCoordinator.Text = "Координатор";
            this.btnCoordinator.UseVisualStyleBackColor = true;
            this.btnCoordinator.Click += new System.EventHandler(this.btnCoordinator_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.Location = new System.Drawing.Point(164, 418);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(250, 50);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Администратор";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // AuthorizationRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 527);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCoordinator);
            this.Controls.Add(this.btnRunner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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