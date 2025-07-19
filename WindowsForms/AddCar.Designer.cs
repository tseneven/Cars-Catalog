namespace WindowsForms
{
    partial class AddCar
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
            Name_TextBox = new TextBox();
            Years_TextBox = new TextBox();
            Mileage_TtextBox = new TextBox();
            Technical_Сondition_TextBox = new TextBox();
            Price_TextBox = new TextBox();
            Save_Button = new Button();
            Back_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(34, 39);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(125, 27);
            Name_TextBox.TabIndex = 0;
            // 
            // Years_TextBox
            // 
            Years_TextBox.Location = new Point(189, 39);
            Years_TextBox.Name = "Years_TextBox";
            Years_TextBox.Size = new Size(125, 27);
            Years_TextBox.TabIndex = 1;
            // 
            // Mileage_TtextBox
            // 
            Mileage_TtextBox.Location = new Point(352, 39);
            Mileage_TtextBox.Name = "Mileage_TtextBox";
            Mileage_TtextBox.Size = new Size(125, 27);
            Mileage_TtextBox.TabIndex = 2;
            // 
            // Technical_Сondition_TextBox
            // 
            Technical_Сondition_TextBox.Location = new Point(512, 39);
            Technical_Сondition_TextBox.Name = "Technical_Сondition_TextBox";
            Technical_Сondition_TextBox.Size = new Size(125, 27);
            Technical_Сondition_TextBox.TabIndex = 3;
            // 
            // Price_TextBox
            // 
            Price_TextBox.Location = new Point(577, 340);
            Price_TextBox.Name = "Price_TextBox";
            Price_TextBox.Size = new Size(125, 27);
            Price_TextBox.TabIndex = 4;
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(524, 397);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(178, 41);
            Save_Button.TabIndex = 5;
            Save_Button.Text = "Добавить";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.Location = new Point(322, 397);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(178, 41);
            Back_Button.TabIndex = 6;
            Back_Button.Text = "Отмена";
            Back_Button.UseVisualStyleBackColor = true;
            Back_Button.Click += Back_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 343);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 7;
            label1.Text = "Цена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 8;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 16);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 9;
            label3.Text = "Год выпуска";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 16);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 10;
            label4.Text = "Пробег";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 16);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 11;
            label5.Text = "Техническое состояние";
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back_Button);
            Controls.Add(Save_Button);
            Controls.Add(Price_TextBox);
            Controls.Add(Technical_Сondition_TextBox);
            Controls.Add(Mileage_TtextBox);
            Controls.Add(Years_TextBox);
            Controls.Add(Name_TextBox);
            Name = "AddCar";
            Text = "AddCar";
            Load += AddCar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name_TextBox;
        private TextBox Years_TextBox;
        private TextBox Mileage_TtextBox;
        private TextBox Technical_Сondition_TextBox;
        private TextBox Price_TextBox;
        private Button Save_Button;
        private Button Back_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}