namespace WinFormsCipher
{
    partial class AffineCipher
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKeyA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttontextBoxInput = new System.Windows.Forms.Button();
            this.buttontextBoxResult = new System.Windows.Forms.Button();
            this.buttonsaveInput = new System.Windows.Forms.Button();
            this.buttonsaveOutput = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.textBoxKeyB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(357, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản Rõ";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.textBoxInput.Location = new System.Drawing.Point(132, 139);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(517, 38);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.textBoxResult.Location = new System.Drawing.Point(131, 361);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(517, 38);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResult_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(354, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bản Mã";
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.btnQuit.Location = new System.Drawing.Point(339, 446);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(109, 38);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Đóng";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Affine Cipher";
            // 
            // textBoxKeyA
            // 
            this.textBoxKeyA.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.textBoxKeyA.Location = new System.Drawing.Point(294, 258);
            this.textBoxKeyA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyA.Name = "textBoxKeyA";
            this.textBoxKeyA.Size = new System.Drawing.Size(90, 38);
            this.textBoxKeyA.TabIndex = 2;
            this.textBoxKeyA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyNum);
            this.textBoxKeyA.Leave += new System.EventHandler(this.textBoxKeyA_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(305, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khóa A";
            // 
            // buttontextBoxInput
            // 
            this.buttontextBoxInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttontextBoxInput.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttontextBoxInput.FlatAppearance.BorderSize = 0;
            this.buttontextBoxInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontextBoxInput.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.buttontextBoxInput.Location = new System.Drawing.Point(309, 186);
            this.buttontextBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.buttontextBoxInput.Name = "buttontextBoxInput";
            this.buttontextBoxInput.Size = new System.Drawing.Size(83, 30);
            this.buttontextBoxInput.TabIndex = 11;
            this.buttontextBoxInput.Text = "Mở file";
            this.buttontextBoxInput.UseVisualStyleBackColor = false;
            this.buttontextBoxInput.Click += new System.EventHandler(this.buttontextBoxInput_Click);
            // 
            // buttontextBoxResult
            // 
            this.buttontextBoxResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttontextBoxResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontextBoxResult.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.buttontextBoxResult.Location = new System.Drawing.Point(311, 408);
            this.buttontextBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttontextBoxResult.Name = "buttontextBoxResult";
            this.buttontextBoxResult.Size = new System.Drawing.Size(83, 30);
            this.buttontextBoxResult.TabIndex = 12;
            this.buttontextBoxResult.Text = "Mở file";
            this.buttontextBoxResult.UseVisualStyleBackColor = false;
            this.buttontextBoxResult.Click += new System.EventHandler(this.buttontextBoxResult_Click);
            // 
            // buttonsaveInput
            // 
            this.buttonsaveInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.buttonsaveInput.FlatAppearance.BorderSize = 0;
            this.buttonsaveInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsaveInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsaveInput.ForeColor = System.Drawing.Color.White;
            this.buttonsaveInput.Location = new System.Drawing.Point(400, 186);
            this.buttonsaveInput.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsaveInput.Name = "buttonsaveInput";
            this.buttonsaveInput.Size = new System.Drawing.Size(71, 30);
            this.buttonsaveInput.TabIndex = 13;
            this.buttonsaveInput.Text = "Save";
            this.buttonsaveInput.UseVisualStyleBackColor = false;
            this.buttonsaveInput.Click += new System.EventHandler(this.buttonsaveInput_Click);
            // 
            // buttonsaveOutput
            // 
            this.buttonsaveOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.buttonsaveOutput.FlatAppearance.BorderSize = 0;
            this.buttonsaveOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsaveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsaveOutput.ForeColor = System.Drawing.Color.White;
            this.buttonsaveOutput.Location = new System.Drawing.Point(401, 408);
            this.buttonsaveOutput.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsaveOutput.Name = "buttonsaveOutput";
            this.buttonsaveOutput.Size = new System.Drawing.Size(71, 30);
            this.buttonsaveOutput.TabIndex = 14;
            this.buttonsaveOutput.Text = "Save";
            this.buttonsaveOutput.UseVisualStyleBackColor = false;
            this.buttonsaveOutput.Click += new System.EventHandler(this.buttonsaveOutput_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.White;
            this.panelheader.Controls.Add(this.label3);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(840, 98);
            this.panelheader.TabIndex = 15;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.btnDecrypt.ForeColor = System.Drawing.Color.Plum;
            this.btnDecrypt.Image = global::WinFormsCipher.Properties.Resources.blue_neon_arrow_up;
            this.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.Location = new System.Drawing.Point(493, 258);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(155, 39);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "   Giải Mã";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEncrypt.Image = global::WinFormsCipher.Properties.Resources.blue_neon_arrow_down1;
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(131, 258);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(155, 39);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "   Mã Hóa";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // textBoxKeyB
            // 
            this.textBoxKeyB.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.textBoxKeyB.Location = new System.Drawing.Point(400, 258);
            this.textBoxKeyB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyB.Name = "textBoxKeyB";
            this.textBoxKeyB.Size = new System.Drawing.Size(83, 38);
            this.textBoxKeyB.TabIndex = 3;
            this.textBoxKeyB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyNum);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(397, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Khóa B";
            // 
            // AffineCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 603);
            this.Controls.Add(this.textBoxKeyB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.buttonsaveOutput);
            this.Controls.Add(this.buttonsaveInput);
            this.Controls.Add(this.buttontextBoxResult);
            this.Controls.Add(this.buttontextBoxInput);
            this.Controls.Add(this.textBoxKeyA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(840, 603);
            this.MinimumSize = new System.Drawing.Size(840, 603);
            this.Name = "AffineCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ mã hóa giải mã Vigenere Cipher ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKeyA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttontextBoxInput;
        private System.Windows.Forms.Button buttontextBoxResult;
        private System.Windows.Forms.Button buttonsaveInput;
        private System.Windows.Forms.Button buttonsaveOutput;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.TextBox textBoxKeyB;
        private System.Windows.Forms.Label label5;
    }
}

