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
            textBox1.Location = new Point(96, 124);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 131);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 175);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Телефон";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 168);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(96, 51);
            label3.Name = "label3";
            label3.Size = new Size(119, 31);
            label3.TabIndex = 4;
            label3.Text = "Профиль";
            // 
            // Profile_Edit_Button
            // 
            Profile_Edit_Button.Location = new Point(21, 218);
            Profile_Edit_Button.Name = "Profile_Edit_Button";
            Profile_Edit_Button.Size = new Size(282, 56);
            Profile_Edit_Button.TabIndex = 5;
            Profile_Edit_Button.Text = "Редактировать";
            Profile_Edit_Button.UseVisualStyleBackColor = true;
            Profile_Edit_Button.Click += Profile_Edit_Button_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(532, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(424, 284);
            listBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(679, 51);
            label4.Name = "label4";
            label4.Size = new Size(130, 31);
            label4.TabIndex = 7;
            label4.Text = "Ваши авто";
            // 
            // button1
            // 
            button1.Location = new Point(679, 396);
            button1.Name = "button1";
            button1.Size = new Size(130, 56);
            button1.TabIndex = 8;
            button1.Text = "Редактировать авто";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(532, 396);
            button2.Name = "button2";
            button2.Size = new Size(127, 56);
            button2.TabIndex = 9;
            button2.Text = "Добавить авто";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(826, 396);
            button3.Name = "button3";
            button3.Size = new Size(130, 56);
            button3.TabIndex = 10;
            button3.Text = "Удалить авто";
            button3.UseVisualStyleBackColor = true;
            // 
            // Profile_Delete_Button
            // 
            Profile_Delete_Button.Location = new Point(21, 280);
            Profile_Delete_Button.Name = "Profile_Delete_Button";
            Profile_Delete_Button.Size = new Size(282, 56);
            Profile_Delete_Button.TabIndex = 11;
            Profile_Delete_Button.Text = "Удалить";
            Profile_Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 487);
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