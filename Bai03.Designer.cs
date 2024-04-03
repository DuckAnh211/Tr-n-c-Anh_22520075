namespace _22520075_Lab2
{
    partial class Bai03
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(97, 93);
            button1.Name = "button1";
            button1.Size = new Size(241, 123);
            button1.TabIndex = 0;
            button1.Text = "Đọc và Ghi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(425, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(925, 602);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(97, 539);
            button4.Name = "button4";
            button4.Size = new Size(241, 102);
            button4.TabIndex = 4;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 742);
            Controls.Add(button4);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button4;
    }
}