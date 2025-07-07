namespace WindowsForms
{
    partial class Auth_Registr
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Reg_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PovPas_textBox = new System.Windows.Forms.TextBox();
            this.Pas_textBox = new System.Windows.Forms.TextBox();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Auth_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogPas_textBox = new System.Windows.Forms.TextBox();
            this.LogLog_textBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Reg_button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PovPas_textBox);
            this.tabPage1.Controls.Add(this.Pas_textBox);
            this.tabPage1.Controls.Add(this.Log_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Reg_button
            // 
            this.Reg_button.Location = new System.Drawing.Point(139, 217);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(283, 44);
            this.Reg_button.TabIndex = 6;
            this.Reg_button.Text = "Регистрация";
            this.Reg_button.UseVisualStyleBackColor = true;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите пароль";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // PovPas_textBox
            // 
            this.PovPas_textBox.Location = new System.Drawing.Point(139, 152);
            this.PovPas_textBox.Name = "PovPas_textBox";
            this.PovPas_textBox.Size = new System.Drawing.Size(283, 22);
            this.PovPas_textBox.TabIndex = 2;
            // 
            // Pas_textBox
            // 
            this.Pas_textBox.Location = new System.Drawing.Point(139, 98);
            this.Pas_textBox.Name = "Pas_textBox";
            this.Pas_textBox.Size = new System.Drawing.Size(283, 22);
            this.Pas_textBox.TabIndex = 1;
            // 
            // Log_textBox
            // 
            this.Log_textBox.Location = new System.Drawing.Point(139, 45);
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(283, 22);
            this.Log_textBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Auth_button);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.LogPas_textBox);
            this.tabPage2.Controls.Add(this.LogLog_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Авторизация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Auth_button
            // 
            this.Auth_button.Location = new System.Drawing.Point(149, 146);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(283, 44);
            this.Auth_button.TabIndex = 11;
            this.Auth_button.Text = "Авторизиция";
            this.Auth_button.UseVisualStyleBackColor = true;
            this.Auth_button.Click += new System.EventHandler(this.Auth_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин";
            // 
            // LogPas_textBox
            // 
            this.LogPas_textBox.Location = new System.Drawing.Point(149, 81);
            this.LogPas_textBox.Name = "LogPas_textBox";
            this.LogPas_textBox.Size = new System.Drawing.Size(283, 22);
            this.LogPas_textBox.TabIndex = 8;
            // 
            // LogLog_textBox
            // 
            this.LogLog_textBox.Location = new System.Drawing.Point(149, 27);
            this.LogLog_textBox.Name = "LogLog_textBox";
            this.LogLog_textBox.Size = new System.Drawing.Size(283, 22);
            this.LogLog_textBox.TabIndex = 7;
            // 
            // Auth_Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Auth_Registr";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Reg_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PovPas_textBox;
        private System.Windows.Forms.TextBox Pas_textBox;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Auth_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LogPas_textBox;
        private System.Windows.Forms.TextBox LogLog_textBox;
    }
}

