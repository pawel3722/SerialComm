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
            inputText = new TextBox();
            label6 = new Label();
            outputText = new TextBox();
            label7 = new Label();
            sendButton = new Button();
            transactionButton = new Button();
            pingButton = new Button();
            parityControlBox = new ComboBox();
            stopBitsBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            openButton = new Button();
            closeButton = new Button();
            connectionInfoLabel = new Label();
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
            portBox.Size = new Size(101, 23);
            portBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 13);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Szybkość:";
            // 
            // speedBox
            // 
            speedBox.FormattingEnabled = true;
            speedBox.Items.AddRange(new object[] { "150", "300", "600", "1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "31250", "38400", "56000", "57600", "76800", "115200" });
            speedBox.Location = new Point(132, 31);
            speedBox.Name = "speedBox";
            speedBox.Size = new Size(101, 23);
            speedBox.TabIndex = 3;
            speedBox.Text = "9600";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 13);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Format znaku:";
            // 
            // formatBox
            // 
            formatBox.FormattingEnabled = true;
            formatBox.Items.AddRange(new object[] { "7", "8" });
            formatBox.Location = new Point(244, 31);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(101, 23);
            formatBox.TabIndex = 5;
            formatBox.Text = "8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(580, 13);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Kontrola:";
            // 
            // controlBox
            // 
            controlBox.FormattingEnabled = true;
            controlBox.Location = new Point(580, 31);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(101, 23);
            controlBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(687, 13);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Terminator:";
            // 
            // terminatorBox
            // 
            terminatorBox.FormattingEnabled = true;
            terminatorBox.Location = new Point(687, 31);
            terminatorBox.Name = "terminatorBox";
            terminatorBox.Size = new Size(101, 23);
            terminatorBox.TabIndex = 9;
            // 
            // inputText
            // 
            inputText.Location = new Point(14, 85);
            inputText.Multiline = true;
            inputText.Name = "inputText";
            inputText.Size = new Size(774, 144);
            inputText.TabIndex = 10;
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
            // outputText
            // 
            outputText.Location = new Point(14, 294);
            outputText.Multiline = true;
            outputText.Name = "outputText";
            outputText.Size = new Size(774, 144);
            outputText.TabIndex = 12;
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
            sendButton.Location = new Point(551, 246);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 14;
            sendButton.Text = "Wyślij";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // transactionButton
            // 
            transactionButton.Location = new Point(632, 246);
            transactionButton.Name = "transactionButton";
            transactionButton.Size = new Size(75, 23);
            transactionButton.TabIndex = 16;
            transactionButton.Text = "Transakcja";
            transactionButton.UseVisualStyleBackColor = true;
            // 
            // pingButton
            // 
            pingButton.Location = new Point(713, 246);
            pingButton.Name = "pingButton";
            pingButton.Size = new Size(75, 23);
            pingButton.TabIndex = 17;
            pingButton.Text = "PING";
            pingButton.UseVisualStyleBackColor = true;
            // 
            // parityControlBox
            // 
            parityControlBox.FormattingEnabled = true;
            parityControlBox.Items.AddRange(new object[] { "Even", "Odd", "None" });
            parityControlBox.Location = new Point(351, 31);
            parityControlBox.Name = "parityControlBox";
            parityControlBox.Size = new Size(101, 23);
            parityControlBox.TabIndex = 18;
            parityControlBox.Text = "None";
            // 
            // stopBitsBox
            // 
            stopBitsBox.FormattingEnabled = true;
            stopBitsBox.Items.AddRange(new object[] { "1", "2" });
            stopBitsBox.Location = new Point(458, 31);
            stopBitsBox.Name = "stopBitsBox";
            stopBitsBox.Size = new Size(101, 23);
            stopBitsBox.TabIndex = 19;
            stopBitsBox.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(458, 13);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 20;
            label8.Text = "Bity stopu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(351, 13);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 21;
            label9.Text = "Kontrola";
            // 
            // openButton
            // 
            openButton.Location = new Point(14, 246);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 22;
            openButton.Text = "Otwórz";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(95, 246);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 23;
            closeButton.Text = "Zamknij";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // connectionInfoLabel
            // 
            connectionInfoLabel.AutoSize = true;
            connectionInfoLabel.ForeColor = Color.Red;
            connectionInfoLabel.Location = new Point(176, 250);
            connectionInfoLabel.Name = "connectionInfoLabel";
            connectionInfoLabel.Size = new Size(83, 15);
            connectionInfoLabel.TabIndex = 24;
            connectionInfoLabel.Text = "Nie połączono";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connectionInfoLabel);
            Controls.Add(closeButton);
            Controls.Add(openButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(stopBitsBox);
            Controls.Add(parityControlBox);
            Controls.Add(pingButton);
            Controls.Add(transactionButton);
            Controls.Add(sendButton);
            Controls.Add(label7);
            Controls.Add(outputText);
            Controls.Add(label6);
            Controls.Add(inputText);
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
        private TextBox inputText;
        private Label label6;
        private TextBox outputText;
        private Label label7;
        private Button sendButton;
        private Button transactionButton;
        private Button pingButton;
        private ComboBox parityControlBox;
        private ComboBox stopBitsBox;
        private Label label8;
        private Label label9;
        private Button openButton;
        private Button closeButton;
        private Label connectionInfoLabel;
    }
}