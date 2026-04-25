namespace prac4oop_examp
{
    partial class Form1
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
            NameBox = new TextBox();
            AgeBox = new TextBox();
            ProfessionBox = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TextBox = new TextBox();
            StartButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(92, 15);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 1;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(92, 44);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(100, 23);
            AgeBox.TabIndex = 2;
            // 
            // ProfessionBox
            // 
            ProfessionBox.Location = new Point(92, 73);
            ProfessionBox.Name = "ProfessionBox";
            ProfessionBox.Size = new Size(100, 23);
            ProfessionBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ProfessionBox);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(AgeBox);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 102);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 76);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Професія";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 47);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 5;
            label2.Text = "Вік";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 18);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Ім'я";
            // 
            // TextBox
            // 
            TextBox.Location = new Point(229, 56);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(232, 242);
            TextBox.TabIndex = 6;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(22, 164);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(182, 24);
            StartButton.TabIndex = 7;
            StartButton.Text = "Додати";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 310);
            Controls.Add(StartButton);
            Controls.Add(TextBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Список";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameBox;
        private TextBox AgeBox;
        private TextBox ProfessionBox;
        private GroupBox groupBox1;
        private TextBox TextBox;
        private Button StartButton;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
