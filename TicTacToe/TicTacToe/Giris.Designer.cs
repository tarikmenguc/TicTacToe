namespace TicTacToe
{
    partial class Giris
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            plyr1nametxt = new TextBox();
            plyr2nametxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(169, 38);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 0;
            label1.Text = "Tic Tac Toe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 173);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 1;
            label2.Text = "Player2 Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(22, 115);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 1;
            label3.Text = "Player1 Name:";
            // 
            // plyr1nametxt
            // 
            plyr1nametxt.Location = new Point(169, 119);
            plyr1nametxt.Name = "plyr1nametxt";
            plyr1nametxt.Size = new Size(221, 27);
            plyr1nametxt.TabIndex = 2;
            plyr1nametxt.TextChanged += plyr1nametxt_TextChanged;
            // 
            // plyr2nametxt
            // 
            plyr2nametxt.Location = new Point(169, 177);
            plyr2nametxt.Name = "plyr2nametxt";
            plyr2nametxt.Size = new Size(221, 27);
            plyr2nametxt.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.LimeGreen;
            button1.Location = new Point(169, 219);
            button1.Name = "button1";
            button1.Size = new Size(221, 36);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 335);
            Controls.Add(button1);
            Controls.Add(plyr2nametxt);
            Controls.Add(plyr1nametxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox plyr1nametxt;
        private TextBox plyr2nametxt;
        private Button button1;
    }
}