
namespace CryptoDesktop_2
{
    partial class MainForm
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
            this.sequenceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sequencePanel = new System.Windows.Forms.Panel();
            this.sequenceLabel = new System.Windows.Forms.Label();
            this.sequenceLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testsOutputLabel = new System.Windows.Forms.Label();
            this.testsButton = new System.Windows.Forms.Button();
            this.testsOutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptionLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.encryptionTestsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sequencePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceLengthNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequenceRichTextBox
            // 
            this.sequenceRichTextBox.Location = new System.Drawing.Point(3, 25);
            this.sequenceRichTextBox.Name = "sequenceRichTextBox";
            this.sequenceRichTextBox.Size = new System.Drawing.Size(372, 260);
            this.sequenceRichTextBox.TabIndex = 0;
            this.sequenceRichTextBox.Text = "";
            // 
            // sequencePanel
            // 
            this.sequencePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.sequencePanel.Controls.Add(this.comboBox1);
            this.sequencePanel.Controls.Add(this.sequenceLabel);
            this.sequencePanel.Controls.Add(this.sequenceLengthNumericUpDown);
            this.sequencePanel.Controls.Add(this.settingsLabel);
            this.sequencePanel.Controls.Add(this.getButton);
            this.sequencePanel.Controls.Add(this.sequenceRichTextBox);
            this.sequencePanel.Location = new System.Drawing.Point(12, 12);
            this.sequencePanel.Name = "sequencePanel";
            this.sequencePanel.Size = new System.Drawing.Size(378, 361);
            this.sequencePanel.TabIndex = 1;
            // 
            // sequenceLabel
            // 
            this.sequenceLabel.AutoSize = true;
            this.sequenceLabel.Location = new System.Drawing.Point(3, 3);
            this.sequenceLabel.Name = "sequenceLabel";
            this.sequenceLabel.Size = new System.Drawing.Size(73, 20);
            this.sequenceLabel.TabIndex = 4;
            this.sequenceLabel.Text = "Sequence";
            // 
            // sequenceLengthNumericUpDown
            // 
            this.sequenceLengthNumericUpDown.Location = new System.Drawing.Point(180, 298);
            this.sequenceLengthNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.sequenceLengthNumericUpDown.Name = "sequenceLengthNumericUpDown";
            this.sequenceLengthNumericUpDown.Size = new System.Drawing.Size(85, 27);
            this.sequenceLengthNumericUpDown.TabIndex = 3;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(3, 300);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(176, 20);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "L = 103, sequence length:";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(271, 296);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(104, 29);
            this.getButton.TabIndex = 2;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.testsOutputLabel);
            this.panel1.Controls.Add(this.testsButton);
            this.panel1.Controls.Add(this.testsOutputRichTextBox);
            this.panel1.Location = new System.Drawing.Point(404, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 361);
            this.panel1.TabIndex = 2;
            // 
            // testsOutputLabel
            // 
            this.testsOutputLabel.AutoSize = true;
            this.testsOutputLabel.Location = new System.Drawing.Point(3, 1);
            this.testsOutputLabel.Name = "testsOutputLabel";
            this.testsOutputLabel.Size = new System.Drawing.Size(91, 20);
            this.testsOutputLabel.TabIndex = 3;
            this.testsOutputLabel.Text = "Tests Output";
            // 
            // testsButton
            // 
            this.testsButton.Location = new System.Drawing.Point(3, 294);
            this.testsButton.Name = "testsButton";
            this.testsButton.Size = new System.Drawing.Size(104, 29);
            this.testsButton.TabIndex = 2;
            this.testsButton.Text = "Tests";
            this.testsButton.UseVisualStyleBackColor = true;
            this.testsButton.Click += new System.EventHandler(this.testsButton_Click);
            // 
            // testsOutputRichTextBox
            // 
            this.testsOutputRichTextBox.Location = new System.Drawing.Point(3, 23);
            this.testsOutputRichTextBox.Name = "testsOutputRichTextBox";
            this.testsOutputRichTextBox.Size = new System.Drawing.Size(372, 262);
            this.testsOutputRichTextBox.TabIndex = 0;
            this.testsOutputRichTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.decryptButton);
            this.panel2.Controls.Add(this.encryptionLabel);
            this.panel2.Controls.Add(this.encryptButton);
            this.panel2.Controls.Add(this.encryptionTestsRichTextBox);
            this.panel2.Location = new System.Drawing.Point(797, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 361);
            this.panel2.TabIndex = 3;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(204, 294);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(171, 29);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptionLabel
            // 
            this.encryptionLabel.AutoSize = true;
            this.encryptionLabel.Location = new System.Drawing.Point(3, 1);
            this.encryptionLabel.Name = "encryptionLabel";
            this.encryptionLabel.Size = new System.Drawing.Size(79, 20);
            this.encryptionLabel.TabIndex = 3;
            this.encryptionLabel.Text = "Encryption";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(3, 294);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(195, 29);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // encryptionTestsRichTextBox
            // 
            this.encryptionTestsRichTextBox.Location = new System.Drawing.Point(3, 23);
            this.encryptionTestsRichTextBox.Name = "encryptionTestsRichTextBox";
            this.encryptionTestsRichTextBox.Size = new System.Drawing.Size(372, 262);
            this.encryptionTestsRichTextBox.TabIndex = 0;
            this.encryptionTestsRichTextBox.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Random",
            "From file"});
            this.comboBox1.Location = new System.Drawing.Point(3, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sequencePanel);
            this.Name = "MainForm";
            this.Text = "MSequence";
            this.sequencePanel.ResumeLayout(false);
            this.sequencePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceLengthNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox sequenceRichTextBox;
        private System.Windows.Forms.Panel sequencePanel;
        private System.Windows.Forms.NumericUpDown sequenceLengthNumericUpDown;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label sequenceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label testsOutputLabel;
        private System.Windows.Forms.Button testsButton;
        private System.Windows.Forms.RichTextBox testsOutputRichTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label encryptionLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.RichTextBox encryptionTestsRichTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

