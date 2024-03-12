namespace SerialComm
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
            label1 = new Label();
            portBox = new ComboBox();
            label2 = new Label();
            speedBox = new ComboBox();
            label3 = new Label();
            formatBox = new ComboBox();
            label4 = new Label();
            controlBox = new ComboBox();
            label5 = new Label();
            terminatorBox = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            sendButton = new Button();
            receiveButton = new Button();
            transactionButton = new Button();
            pingButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Port:";
            // 
            // portBox
            // 
            portBox.FormattingEnabled = true;
            portBox.Location = new Point(14, 31);
            portBox.Name = "portBox";
            portBox.Size = new Size(121, 23);
            portBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 13);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Szybkość:";
            // 
            // speedBox
            // 
            speedBox.FormattingEnabled = true;
            speedBox.Location = new Point(175, 31);
            speedBox.Name = "speedBox";
            speedBox.Size = new Size(121, 23);
            speedBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 13);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Format znaku:";
            // 
            // formatBox
            // 
            formatBox.FormattingEnabled = true;
            formatBox.Location = new Point(339, 31);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(121, 23);
            formatBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 13);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 6;
            label4.Text = "Kontrola przepływu:";
            // 
            // controlBox
            // 
            controlBox.FormattingEnabled = true;
            controlBox.Location = new Point(503, 31);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(121, 23);
            controlBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(667, 13);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Terminator:";
            // 
            // terminatorBox
            // 
            terminatorBox.FormattingEnabled = true;
            terminatorBox.Location = new Point(667, 31);
            terminatorBox.Name = "terminatorBox";
            terminatorBox.Size = new Size(121, 23);
            terminatorBox.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(774, 144);
            textBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 67);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 11;
            label6.Text = "Tekst do wysłania:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 294);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(774, 144);
            textBox2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 276);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 13;
            label7.Text = "Odebrany tekst:";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(158, 246);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 14;
            sendButton.Text = "Wyślij";
            sendButton.UseVisualStyleBackColor = true;
            // 
            // receiveButton
            // 
            receiveButton.Location = new Point(287, 246);
            receiveButton.Name = "receiveButton";
            receiveButton.Size = new Size(75, 23);
            receiveButton.TabIndex = 15;
            receiveButton.Text = "Odbierz";
            receiveButton.UseVisualStyleBackColor = true;
            // 
            // transactionButton
            // 
            transactionButton.Location = new Point(412, 246);
            transactionButton.Name = "transactionButton";
            transactionButton.Size = new Size(75, 23);
            transactionButton.TabIndex = 16;
            transactionButton.Text = "Transakcja";
            transactionButton.UseVisualStyleBackColor = true;
            // 
            // pingButton
            // 
            pingButton.Location = new Point(540, 246);
            pingButton.Name = "pingButton";
            pingButton.Size = new Size(75, 23);
            pingButton.TabIndex = 17;
            pingButton.Text = "PING";
            pingButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pingButton);
            Controls.Add(transactionButton);
            Controls.Add(receiveButton);
            Controls.Add(sendButton);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(terminatorBox);
            Controls.Add(label5);
            Controls.Add(controlBox);
            Controls.Add(label4);
            Controls.Add(formatBox);
            Controls.Add(label3);
            Controls.Add(speedBox);
            Controls.Add(label2);
            Controls.Add(portBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox portBox;
        private Label label2;
        private ComboBox speedBox;
        private Label label3;
        private ComboBox formatBox;
        private Label label4;
        private ComboBox controlBox;
        private Label label5;
        private ComboBox terminatorBox;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Button sendButton;
        private Button receiveButton;
        private Button transactionButton;
        private Button pingButton;
    }
}