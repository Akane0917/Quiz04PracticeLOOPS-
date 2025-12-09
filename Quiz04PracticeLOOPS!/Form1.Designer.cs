namespace Quiz04PracticeLOOPS_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            q1Button = new Button();
            q1OutputLabel = new Label();
            q2OutputLabel = new Label();
            q2Button = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            q3OutputLabel = new Label();
            q3Button = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            q3TextBox = new TextBox();
            label11 = new Label();
            q4QuestionButton = new Button();
            q4Button = new Button();
            q4OutputLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 23);
            label1.TabIndex = 0;
            label1.Text = "Q1 - Using a counted loop (for loop) ";
            // 
            // label2
            // 
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(358, 76);
            label2.TabIndex = 1;
            label2.Text = "When the user hits the button, the program will output “GO BEARS GO!” exactly five times.";
            // 
            // label3
            // 
            label3.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 116);
            label3.Name = "label3";
            label3.Size = new Size(358, 22);
            label3.TabIndex = 2;
            label3.Text = "------------------------------------------------------------------";
            // 
            // label4
            // 
            label4.BackColor = Color.Maroon;
            label4.Location = new Point(365, 0);
            label4.Name = "label4";
            label4.Size = new Size(10, 567);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(3, 92);
            label5.Name = "label5";
            label5.Size = new Size(358, 46);
            label5.TabIndex = 4;
            label5.Text = "Criteria:  Use a for loop (3 marks)";
            // 
            // q1Button
            // 
            q1Button.ForeColor = Color.Maroon;
            q1Button.Location = new Point(47, 141);
            q1Button.Name = "q1Button";
            q1Button.Size = new Size(254, 52);
            q1Button.TabIndex = 5;
            q1Button.Text = "Code Me!";
            q1Button.UseVisualStyleBackColor = true;
            q1Button.Click += q1Button_Click;
            // 
            // q1OutputLabel
            // 
            q1OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q1OutputLabel.Location = new Point(12, 196);
            q1OutputLabel.Name = "q1OutputLabel";
            q1OutputLabel.Size = new Size(324, 71);
            q1OutputLabel.TabIndex = 6;
            q1OutputLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // q2OutputLabel
            // 
            q2OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q2OutputLabel.Location = new Point(12, 481);
            q2OutputLabel.Name = "q2OutputLabel";
            q2OutputLabel.Size = new Size(324, 71);
            q2OutputLabel.TabIndex = 12;
            q2OutputLabel.TextAlign = ContentAlignment.TopCenter;
            q2OutputLabel.Click += q2OutputLabel_Click;
            // 
            // q2Button
            // 
            q2Button.ForeColor = Color.Maroon;
            q2Button.Location = new Point(56, 409);
            q2Button.Name = "q2Button";
            q2Button.Size = new Size(254, 52);
            q2Button.TabIndex = 11;
            q2Button.Text = "Code Me!";
            q2Button.UseVisualStyleBackColor = true;
            q2Button.Click += q2Button_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(12, 360);
            label7.Name = "label7";
            label7.Size = new Size(358, 24);
            label7.TabIndex = 10;
            label7.Text = "Criteria:  Use a while loop (3 marks)";
            // 
            // label8
            // 
            label8.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 384);
            label8.Name = "label8";
            label8.Size = new Size(358, 22);
            label8.TabIndex = 9;
            label8.Text = "------------------------------------------------------------------";
            // 
            // label9
            // 
            label9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 296);
            label9.Name = "label9";
            label9.Size = new Size(358, 92);
            label9.TabIndex = 8;
            label9.Text = "When the user hits the button, the program will output “GO BEARS GO!” exactly five times.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 277);
            label10.Name = "label10";
            label10.Size = new Size(428, 23);
            label10.TabIndex = 7;
            label10.Text = "Q2 - Using a counted loop (while loop)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(381, 9);
            label6.Name = "label6";
            label6.Size = new Size(373, 23);
            label6.TabIndex = 13;
            label6.Text = "Q3 - User Defined number of times";
            // 
            // q3OutputLabel
            // 
            q3OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q3OutputLabel.Location = new Point(381, 296);
            q3OutputLabel.Name = "q3OutputLabel";
            q3OutputLabel.Size = new Size(391, 62);
            q3OutputLabel.TabIndex = 18;
            q3OutputLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // q3Button
            // 
            q3Button.ForeColor = Color.Maroon;
            q3Button.Location = new Point(689, 240);
            q3Button.Name = "q3Button";
            q3Button.Size = new Size(83, 52);
            q3Button.TabIndex = 17;
            q3Button.Text = "Code Me!";
            q3Button.UseVisualStyleBackColor = true;
            q3Button.Click += q3Button_Click;
            // 
            // label12
            // 
            label12.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.LightGray;
            label12.Location = new Point(381, 196);
            label12.Name = "label12";
            label12.Size = new Size(391, 41);
            label12.TabIndex = 16;
            label12.Text = "Criteria:  Can be either for or while loop (4 marks)";
            // 
            // label13
            // 
            label13.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(381, 215);
            label13.Name = "label13";
            label13.Size = new Size(401, 22);
            label13.TabIndex = 15;
            label13.Text = "------------------------------------------------------------------";
            // 
            // label14
            // 
            label14.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(381, 32);
            label14.Name = "label14";
            label14.Size = new Size(475, 164);
            label14.TabIndex = 14;
            label14.Text = resources.GetString("label14.Text");
            // 
            // label15
            // 
            label15.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(381, 240);
            label15.Name = "label15";
            label15.Size = new Size(173, 40);
            label15.TabIndex = 19;
            label15.Text = "Enter the number of times";
            // 
            // q3TextBox
            // 
            q3TextBox.Location = new Point(560, 254);
            q3TextBox.Name = "q3TextBox";
            q3TextBox.Size = new Size(100, 31);
            q3TextBox.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(381, 365);
            label11.Name = "label11";
            label11.Size = new Size(329, 23);
            label11.TabIndex = 21;
            label11.Text = "Q4 - Nested Loop (ICS3U Only)";
            // 
            // q4QuestionButton
            // 
            q4QuestionButton.ForeColor = Color.Maroon;
            q4QuestionButton.Location = new Point(657, 367);
            q4QuestionButton.Name = "q4QuestionButton";
            q4QuestionButton.Size = new Size(115, 52);
            q4QuestionButton.TabIndex = 22;
            q4QuestionButton.Text = "Hit Me for Question";
            q4QuestionButton.UseVisualStyleBackColor = true;
            q4QuestionButton.Click += q4QuestionButton_Click;
            // 
            // q4Button
            // 
            q4Button.ForeColor = Color.Maroon;
            q4Button.Location = new Point(381, 387);
            q4Button.Name = "q4Button";
            q4Button.Size = new Size(83, 52);
            q4Button.TabIndex = 23;
            q4Button.Text = "Code Me!";
            q4Button.UseVisualStyleBackColor = true;
            // 
            // q4OutputLabel
            // 
            q4OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q4OutputLabel.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            q4OutputLabel.Location = new Point(381, 442);
            q4OutputLabel.Name = "q4OutputLabel";
            q4OutputLabel.Size = new Size(391, 110);
            q4OutputLabel.TabIndex = 24;
            q4OutputLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(852, 561);
            Controls.Add(q4OutputLabel);
            Controls.Add(q4Button);
            Controls.Add(q4QuestionButton);
            Controls.Add(label11);
            Controls.Add(q3TextBox);
            Controls.Add(label15);
            Controls.Add(q3OutputLabel);
            Controls.Add(q3Button);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label6);
            Controls.Add(q2OutputLabel);
            Controls.Add(q2Button);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(q1OutputLabel);
            Controls.Add(q1Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Practice Quiz 04 LOOP!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button q1Button;
        private Label q1OutputLabel;
        private Label q2OutputLabel;
        private Button q2Button;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label6;
        private Label q3OutputLabel;
        private Button q3Button;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox q3TextBox;
        private Label label11;
        private Button q4QuestionButton;
        private Button q4Button;
        private Label q4OutputLabel;
    }
}
