namespace WindowsForms
{
    partial class Profile
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            Profile_Edit_Button = new Button();
            listBox1 = new ListBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Profile_Delete_Button = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 93);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 98);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 131);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Телефон";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 126);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(84, 38);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 4;
            label3.Text = "Профиль";
            // 
            // Profile_Edit_Button
            // 
            Profile_Edit_Button.Location = new Point(18, 164);
            Profile_Edit_Button.Margin = new Padding(3, 2, 3, 2);
            Profile_Edit_Button.Name = "Profile_Edit_Button";
            Profile_Edit_Button.Size = new Size(247, 42);
            Profile_Edit_Button.TabIndex = 5;
            Profile_Edit_Button.Text = "Редактировать";
            Profile_Edit_Button.UseVisualStyleBackColor = true;
            Profile_Edit_Button.Click += Profile_Edit_Button_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(466, 80);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 214);
            listBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(594, 38);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 7;
            label4.Text = "Ваши авто";
            // 
            // button1
            // 
            button1.Location = new Point(594, 297);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 42);
            button1.TabIndex = 8;
            button1.Text = "Редактировать авто";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 297);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 9;
            button2.Text = "Добавить авто";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(723, 297);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(114, 42);
            button3.TabIndex = 10;
            button3.Text = "Удалить авто";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Profile_Delete_Button
            // 
            Profile_Delete_Button.Location = new Point(18, 210);
            Profile_Delete_Button.Margin = new Padding(3, 2, 3, 2);
            Profile_Delete_Button.Name = "Profile_Delete_Button";
            Profile_Delete_Button.Size = new Size(247, 42);
            Profile_Delete_Button.TabIndex = 11;
            Profile_Delete_Button.Text = "Удалить";
            Profile_Delete_Button.UseVisualStyleBackColor = true;
            Profile_Delete_Button.Click += Profile_Delete_Button_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 365);
            Controls.Add(Profile_Delete_Button);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(Profile_Edit_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button Profile_Edit_Button;
        private ListBox listBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Profile_Delete_Button;
    }
}