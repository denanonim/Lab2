namespace Lab2
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
            labelIp = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBoxIP = new TextBox();
            textBoxNik = new TextBox();
            labelNik = new Label();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            SuspendLayout();
            // 
            // labelIp
            // 
            labelIp.AutoSize = true;
            labelIp.Location = new Point(574, 75);
            labelIp.Name = "labelIp";
            labelIp.Size = new Size(82, 20);
            labelIp.TabIndex = 0;
            labelIp.Text = "IP сервера";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 352);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(353, 352);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(441, 319);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(554, 98);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(125, 27);
            textBoxIP.TabIndex = 4;
            // 
            // textBoxNik
            // 
            textBoxNik.Location = new Point(554, 177);
            textBoxNik.Name = "textBoxNik";
            textBoxNik.Size = new Size(125, 27);
            textBoxNik.TabIndex = 6;
            // 
            // labelNik
            // 
            labelNik.AutoSize = true;
            labelNik.Location = new Point(574, 154);
            labelNik.Name = "labelNik";
            labelNik.Size = new Size(36, 20);
            labelNik.TabIndex = 5;
            labelNik.Text = "Ник";
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(554, 248);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(141, 40);
            buttonConnect.TabIndex = 7;
            buttonConnect.Text = "подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(552, 309);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(143, 40);
            buttonDisconnect.TabIndex = 8;
            buttonDisconnect.Text = "отключиться";
            buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxNik);
            Controls.Add(labelNik);
            Controls.Add(textBoxIP);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(labelIp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIp;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBoxIP;
        private TextBox textBoxNik;
        private Label labelNik;
        private Button buttonConnect;
        private Button buttonDisconnect;
    }
}
