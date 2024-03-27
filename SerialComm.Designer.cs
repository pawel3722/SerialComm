namespace SerialComm
{
    partial class SerialComm
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
            pingButton = new Button();
            parityControlBox = new ComboBox();
            stopBitsBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            openButton = new Button();
            closeButton = new Button();
            connectionInfoLabel = new Label();
            clearButton = new Button();
            groupBox1 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            transactButton = new Button();
            transactInfoLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            label2.Location = new Point(121, 13);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Szybkość:";
            // 
            // speedBox
            // 
            speedBox.FormattingEnabled = true;
            speedBox.Items.AddRange(new object[] { "150", "300", "600", "1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "31250", "38400", "56000", "57600", "76800", "115200" });
            speedBox.Location = new Point(121, 31);
            speedBox.Name = "speedBox";
            speedBox.Size = new Size(101, 23);
            speedBox.TabIndex = 3;
            speedBox.Text = "9600";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 13);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Format znaku:";
            // 
            // formatBox
            // 
            formatBox.FormattingEnabled = true;
            formatBox.Items.AddRange(new object[] { "7", "8" });
            formatBox.Location = new Point(228, 31);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(101, 23);
            formatBox.TabIndex = 5;
            formatBox.Text = "8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 13);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Kontrola:";
            // 
            // controlBox
            // 
            controlBox.FormattingEnabled = true;
            controlBox.Items.AddRange(new object[] { "Brak", "RTS/CTS", "XON/XOFF" });
            controlBox.Location = new Point(549, 31);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(101, 23);
            controlBox.TabIndex = 7;
            controlBox.Text = "Brak";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 13);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Terminator:";
            // 
            // terminatorBox
            // 
            terminatorBox.FormattingEnabled = true;
            terminatorBox.Items.AddRange(new object[] { "Brak", "CR", "LF", "CR-LF", "Własny" });
            terminatorBox.Location = new Point(656, 31);
            terminatorBox.Name = "terminatorBox";
            terminatorBox.Size = new Size(101, 23);
            terminatorBox.TabIndex = 9;
            terminatorBox.Text = "Brak";
            // 
            // inputText
            // 
            inputText.Location = new Point(12, 143);
            inputText.Multiline = true;
            inputText.Name = "inputText";
            inputText.ScrollBars = ScrollBars.Vertical;
            inputText.Size = new Size(745, 144);
            inputText.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 125);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 11;
            label6.Text = "Tekst do wysłania:";
            // 
            // outputText
            // 
            outputText.BackColor = Color.Black;
            outputText.Enabled = true;
            outputText.ReadOnly = true;
            outputText.ForeColor = Color.White;
            outputText.Location = new Point(12, 347);
            outputText.Multiline = true;
            outputText.Name = "outputText";
            outputText.ScrollBars = ScrollBars.Vertical;
            outputText.Size = new Size(745, 144);
            outputText.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 329);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 13;
            label7.Text = "Odebrany tekst:";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(12, 293);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 14;
            sendButton.Text = "Wyślij";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // pingButton
            // 
            pingButton.Location = new Point(93, 293);
            pingButton.Name = "pingButton";
            pingButton.Size = new Size(75, 23);
            pingButton.TabIndex = 17;
            pingButton.Text = "PING";
            pingButton.UseVisualStyleBackColor = true;
            pingButton.Click += pingButton_Click;
            // 
            // parityControlBox
            // 
            parityControlBox.FormattingEnabled = true;
            parityControlBox.Items.AddRange(new object[] { "Even", "Odd", "None" });
            parityControlBox.Location = new Point(335, 31);
            parityControlBox.Name = "parityControlBox";
            parityControlBox.Size = new Size(101, 23);
            parityControlBox.TabIndex = 18;
            parityControlBox.Text = "None";
            // 
            // stopBitsBox
            // 
            stopBitsBox.FormattingEnabled = true;
            stopBitsBox.Items.AddRange(new object[] { "1", "2" });
            stopBitsBox.Location = new Point(442, 31);
            stopBitsBox.Name = "stopBitsBox";
            stopBitsBox.Size = new Size(101, 23);
            stopBitsBox.TabIndex = 19;
            stopBitsBox.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 13);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 20;
            label8.Text = "Bity stopu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 13);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 21;
            label9.Text = "Parzystość:";
            // 
            // openButton
            // 
            openButton.Location = new Point(12, 69);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 22;
            openButton.Text = "Otwórz";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(93, 69);
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
            connectionInfoLabel.Location = new Point(174, 73);
            connectionInfoLabel.Name = "connectionInfoLabel";
            connectionInfoLabel.Size = new Size(83, 15);
            connectionInfoLabel.TabIndex = 24;
            connectionInfoLabel.Text = "Nie połączono";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(14, 497);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 25;
            clearButton.Text = "Wyczyść";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(658, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(99, 80);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Własny (ASCII)";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(52, 46);
            numericUpDown2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(40, 23);
            numericUpDown2.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 46);
            numericUpDown1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(52, 21);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // transactButton
            // 
            transactButton.Location = new Point(174, 293);
            transactButton.Name = "transactButton";
            transactButton.Size = new Size(75, 23);
            transactButton.TabIndex = 27;
            transactButton.Text = "Transakcje";
            transactButton.UseVisualStyleBackColor = true;
            transactButton.Click += transactButton_Click;
            // 
            // transactInfoLabel
            // 
            transactInfoLabel.AutoSize = true;
            transactInfoLabel.ForeColor = Color.Red;
            transactInfoLabel.Location = new Point(255, 297);
            transactInfoLabel.Name = "transactInfoLabel";
            transactInfoLabel.Size = new Size(64, 15);
            transactInfoLabel.TabIndex = 28;
            transactInfoLabel.Text = "Wyłączone";
            // 
            // SerialComm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 532);
            Controls.Add(transactInfoLabel);
            Controls.Add(transactButton);
            Controls.Add(groupBox1);
            Controls.Add(clearButton);
            Controls.Add(connectionInfoLabel);
            Controls.Add(closeButton);
            Controls.Add(openButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(stopBitsBox);
            Controls.Add(parityControlBox);
            Controls.Add(pingButton);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SerialComm";
            Text = "SerialComm";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button pingButton;
        private ComboBox parityControlBox;
        private ComboBox stopBitsBox;
        private Label label8;
        private Label label9;
        private Button openButton;
        private Button closeButton;
        private Label connectionInfoLabel;
        private Button clearButton;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButton2;
        private Button transactButton;
        private Label transactInfoLabel;
    }
}