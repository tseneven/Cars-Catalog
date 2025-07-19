namespace WindowsForms
{
    partial class Auth_Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Reg_button = new Button();
            PovPas_textBox = new TextBox();
            Pas_textBox = new TextBox();
            Log_textBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            Auth_button = new Button();
            LogPas_textBox = new TextBox();
            LogLog_textBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(396, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Reg_button);
            tabPage1.Controls.Add(PovPas_textBox);
            tabPage1.Controls.Add(Pas_textBox);
            tabPage1.Controls.Add(Log_textBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(388, 292);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Регистрация";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // Reg_button
            // 
            Reg_button.Location = new Point(131, 142);
            Reg_button.Margin = new Padding(3, 2, 3, 2);
            Reg_button.Name = "Reg_button";
            Reg_button.Size = new Size(235, 36);
            Reg_button.TabIndex = 6;
            Reg_button.Text = "Регистрация";
            Reg_button.UseVisualStyleBackColor = true;
            Reg_button.Click += Reg_button_Click;
            // 
            // PovPas_textBox
            // 
            PovPas_textBox.Location = new Point(132, 94);
            PovPas_textBox.Margin = new Padding(3, 2, 3, 2);
            PovPas_textBox.Name = "PovPas_textBox";
            PovPas_textBox.Size = new Size(235, 23);
            PovPas_textBox.TabIndex = 5;
            PovPas_textBox.UseSystemPasswordChar = true;
            // 
            // Pas_textBox
            // 
            Pas_textBox.Location = new Point(132, 57);
            Pas_textBox.Margin = new Padding(3, 2, 3, 2);
            Pas_textBox.Name = "Pas_textBox";
            Pas_textBox.Size = new Size(235, 23);
            Pas_textBox.TabIndex = 4;
            Pas_textBox.UseSystemPasswordChar = true;
            // 
            // Log_textBox
            // 
            Log_textBox.Location = new Point(132, 23);
            Log_textBox.Margin = new Padding(3, 2, 3, 2);
            Log_textBox.Name = "Log_textBox";
            Log_textBox.Size = new Size(235, 23);
            Log_textBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 94);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Повторите пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Auth_button);
            tabPage2.Controls.Add(LogPas_textBox);
            tabPage2.Controls.Add(LogLog_textBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(388, 292);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Авторизация";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Auth_button
            // 
            Auth_button.Location = new Point(135, 106);
            Auth_button.Margin = new Padding(3, 2, 3, 2);
            Auth_button.Name = "Auth_button";
            Auth_button.Size = new Size(235, 36);
            Auth_button.TabIndex = 11;
            Auth_button.Text = "Авторизация";
            Auth_button.UseVisualStyleBackColor = true;
            Auth_button.Click += Auth_button_Click;
            // 
            // LogPas_textBox
            // 
            LogPas_textBox.Location = new Point(136, 59);
            LogPas_textBox.Margin = new Padding(3, 2, 3, 2);
            LogPas_textBox.Name = "LogPas_textBox";
            LogPas_textBox.Size = new Size(235, 23);
            LogPas_textBox.TabIndex = 10;
            LogPas_textBox.UseSystemPasswordChar = true;
            // 
            // LogLog_textBox
            // 
            LogLog_textBox.Location = new Point(136, 22);
            LogLog_textBox.Margin = new Padding(3, 2, 3, 2);
            LogLog_textBox.Name = "LogLog_textBox";
            LogLog_textBox.Size = new Size(235, 23);
            LogLog_textBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 59);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 22);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "Логин";
            // 
            // Auth_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Auth_Register";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button Reg_button;
        private TextBox PovPas_textBox;
        private TextBox Pas_textBox;
        private TextBox Log_textBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Auth_button;
        private TextBox LogPas_textBox;
        private TextBox LogLog_textBox;
        private Label label4;
        private Label label5;
    }
}
