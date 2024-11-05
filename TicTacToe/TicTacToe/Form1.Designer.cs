namespace TicTacToe
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
            Player2Name = new Label();
            Player1Name = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // Player2Name
            // 
            Player2Name.AutoSize = true;
            Player2Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Player2Name.ForeColor = Color.CornflowerBlue;
            Player2Name.Location = new Point(226, 21);
            Player2Name.Name = "Player2Name";
            Player2Name.Size = new Size(124, 28);
            Player2Name.TabIndex = 0;
            Player2Name.Text = "Player Wins:";
            // 
            // Player1Name
            // 
            Player1Name.AutoSize = true;
            Player1Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Player1Name.ForeColor = Color.LimeGreen;
            Player1Name.Location = new Point(12, 21);
            Player1Name.Name = "Player1Name";
            Player1Name.Size = new Size(124, 28);
            Player1Name.TabIndex = 0;
            Player1Name.Text = "Player Wins:";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(255, 99);
            button3.Name = "button3";
            button3.Size = new Size(107, 111);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(142, 99);
            button2.Name = "button2";
            button2.Size = new Size(107, 111);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(29, 99);
            button1.Name = "button1";
            button1.Size = new Size(107, 111);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(255, 216);
            button6.Name = "button6";
            button6.Size = new Size(107, 111);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(142, 216);
            button5.Name = "button5";
            button5.Size = new Size(107, 111);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(29, 216);
            button4.Name = "button4";
            button4.Size = new Size(107, 111);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Location = new Point(255, 333);
            button9.Name = "button9";
            button9.Size = new Size(107, 111);
            button9.TabIndex = 1;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Location = new Point(142, 333);
            button8.Name = "button8";
            button8.Size = new Size(107, 111);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(29, 333);
            button7.Name = "button7";
            button7.Size = new Size(107, 111);
            button7.TabIndex = 1;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 465);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(Player1Name);
            Controls.Add(Player2Name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Player2Name;
        private Label Player1Name;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
    }
}
