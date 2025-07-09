namespace WindowsForms
{
    partial class Catalog
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            pictureBox1 = new PictureBox();
            Profile_Button = new Button();
            AboutCar_Button = new Button();
            Exit_Button = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(529, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(460, 484);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(12, 292);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(501, 204);
            listBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 254);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Profile_Button
            // 
            Profile_Button.Location = new Point(995, 12);
            Profile_Button.Name = "Profile_Button";
            Profile_Button.Size = new Size(174, 46);
            Profile_Button.TabIndex = 3;
            Profile_Button.Text = "Профиль";
            Profile_Button.UseVisualStyleBackColor = true;
            Profile_Button.Click += Profile_Button_Click_1;
            // 
            // AboutCar_Button
            // 
            AboutCar_Button.Location = new Point(995, 64);
            AboutCar_Button.Name = "AboutCar_Button";
            AboutCar_Button.Size = new Size(174, 75);
            AboutCar_Button.TabIndex = 5;
            AboutCar_Button.Text = "Детальная информация об авто";
            AboutCar_Button.UseVisualStyleBackColor = true;
            AboutCar_Button.Visible = false;
            AboutCar_Button.Click += AboutCar_Button_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(995, 446);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(174, 46);
            Exit_Button.TabIndex = 6;
            Exit_Button.Text = "Выход";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1191, 238);
            button3.Name = "button3";
            button3.Size = new Size(22, 29);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 504);
            Controls.Add(button3);
            Controls.Add(Exit_Button);
            Controls.Add(AboutCar_Button);
            Controls.Add(Profile_Button);
            Controls.Add(pictureBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Catalog";
            Text = "Catalog";
            Load += Catalog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private PictureBox pictureBox1;
        private Button Profile_Button;
        private Button AboutCar_Button;
        private Button Exit_Button;
        private Button button3;
    }
}