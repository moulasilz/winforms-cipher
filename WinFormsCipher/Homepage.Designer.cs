namespace WinFormsCipher
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnAffine = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnColumnTrans = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnRailFence = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnPlayfair = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnVigenere = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCaesar = new System.Windows.Forms.Button();
            this.footermenulabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.timerlabel = new System.Windows.Forms.Timer(this.components);
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMenu.Controls.Add(this.panel7);
            this.PanelMenu.Controls.Add(this.panel6);
            this.PanelMenu.Controls.Add(this.panel5);
            this.PanelMenu.Controls.Add(this.panel4);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.footermenulabel);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.Black;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(192, 603);
            this.PanelMenu.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BtnAffine);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 361);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 50);
            this.panel7.TabIndex = 8;
            // 
            // BtnAffine
            // 
            this.BtnAffine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAffine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAffine.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAffine.FlatAppearance.BorderSize = 0;
            this.BtnAffine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.BtnAffine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BtnAffine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAffine.Location = new System.Drawing.Point(8, 0);
            this.BtnAffine.Name = "BtnAffine";
            this.BtnAffine.Size = new System.Drawing.Size(184, 50);
            this.BtnAffine.TabIndex = 2;
            this.BtnAffine.Text = "Mã hóa Affine";
            this.BtnAffine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAffine.UseVisualStyleBackColor = false;
            this.BtnAffine.Click += new System.EventHandler(this.BtnAffine_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnColumnTrans);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 311);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 50);
            this.panel6.TabIndex = 7;
            // 
            // BtnColumnTrans
            // 
            this.BtnColumnTrans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnColumnTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColumnTrans.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnColumnTrans.FlatAppearance.BorderSize = 0;
            this.BtnColumnTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.BtnColumnTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BtnColumnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColumnTrans.Location = new System.Drawing.Point(8, 0);
            this.BtnColumnTrans.Name = "BtnColumnTrans";
            this.BtnColumnTrans.Size = new System.Drawing.Size(184, 50);
            this.BtnColumnTrans.TabIndex = 2;
            this.BtnColumnTrans.Text = "Mã hóa Hàng";
            this.BtnColumnTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnColumnTrans.UseVisualStyleBackColor = false;
            this.BtnColumnTrans.Click += new System.EventHandler(this.BtnColumnTrans_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnRailFence);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 261);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 50);
            this.panel5.TabIndex = 6;
            // 
            // BtnRailFence
            // 
            this.BtnRailFence.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRailFence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRailFence.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRailFence.FlatAppearance.BorderSize = 0;
            this.BtnRailFence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.BtnRailFence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BtnRailFence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRailFence.Location = new System.Drawing.Point(8, 0);
            this.BtnRailFence.Name = "BtnRailFence";
            this.BtnRailFence.Size = new System.Drawing.Size(184, 50);
            this.BtnRailFence.TabIndex = 2;
            this.BtnRailFence.Text = "Mã hóa RailFence";
            this.BtnRailFence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRailFence.UseVisualStyleBackColor = false;
            this.BtnRailFence.Click += new System.EventHandler(this.BtnRailFence_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnPlayfair);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 50);
            this.panel4.TabIndex = 5;
            // 
            // BtnPlayfair
            // 
            this.BtnPlayfair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPlayfair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlayfair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPlayfair.FlatAppearance.BorderSize = 0;
            this.BtnPlayfair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.BtnPlayfair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BtnPlayfair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayfair.Location = new System.Drawing.Point(8, 0);
            this.BtnPlayfair.Name = "BtnPlayfair";
            this.BtnPlayfair.Size = new System.Drawing.Size(184, 50);
            this.BtnPlayfair.TabIndex = 2;
            this.BtnPlayfair.Text = "Mã hóa Playfair";
            this.BtnPlayfair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlayfair.UseVisualStyleBackColor = false;
            this.BtnPlayfair.Click += new System.EventHandler(this.BtnPlayfair_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnVigenere);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 50);
            this.panel3.TabIndex = 4;
            // 
            // BtnVigenere
            // 
            this.BtnVigenere.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVigenere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVigenere.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnVigenere.FlatAppearance.BorderSize = 0;
            this.BtnVigenere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.BtnVigenere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BtnVigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVigenere.Location = new System.Drawing.Point(8, 0);
            this.BtnVigenere.Name = "BtnVigenere";
            this.BtnVigenere.Size = new System.Drawing.Size(184, 50);
            this.BtnVigenere.TabIndex = 2;
            this.BtnVigenere.Text = "Mã hóa Vigenère";
            this.BtnVigenere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVigenere.UseVisualStyleBackColor = false;
            this.BtnVigenere.Click += new System.EventHandler(this.BtnVigenere_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCaesar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 50);
            this.panel2.TabIndex = 3;
            // 
            // BtnCaesar
            // 
            this.BtnCaesar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCaesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCaesar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCaesar.FlatAppearance.BorderSize = 0;
            this.BtnCaesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(150)))));
            this.BtnCaesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BtnCaesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaesar.Location = new System.Drawing.Point(8, 0);
            this.BtnCaesar.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.BtnCaesar.Name = "BtnCaesar";
            this.BtnCaesar.Size = new System.Drawing.Size(184, 50);
            this.BtnCaesar.TabIndex = 1;
            this.BtnCaesar.Text = "Mã hóa Caesar";
            this.BtnCaesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCaesar.UseVisualStyleBackColor = false;
            this.BtnCaesar.Click += new System.EventHandler(this.BtnCaesar_Click);
            // 
            // footermenulabel
            // 
            this.footermenulabel.AutoSize = true;
            this.footermenulabel.BackColor = System.Drawing.Color.Transparent;
            this.footermenulabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.footermenulabel.ForeColor = System.Drawing.Color.DeepPink;
            this.footermenulabel.Location = new System.Drawing.Point(4, 582);
            this.footermenulabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.footermenulabel.Name = "footermenulabel";
            this.footermenulabel.Size = new System.Drawing.Size(209, 23);
            this.footermenulabel.TabIndex = 0;
            this.footermenulabel.Text = "Bộ công cụ mã hóa ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBoxMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 111);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMenu.Image = global::WinFormsCipher.Properties.Resources.transparent;
            this.pictureBoxMenu.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(190, 104);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            // 
            // timerlabel
            // 
            this.timerlabel.Tick += new System.EventHandler(this.timerlabel_Tick);
            // 
            // timerImage
            // 
            this.timerImage.Enabled = true;
            this.timerImage.Interval = 1;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackgroundImage = global::WinFormsCipher.Properties.Resources.bg;
            this.panelMainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(192, 0);
            this.panelMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(890, 603);
            this.panelMainContainer.TabIndex = 1;
            // 
            // Homepage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ công cụ mã hóa ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label footermenulabel;
        private System.Windows.Forms.Button BtnVigenere;
        private System.Windows.Forms.Button BtnCaesar;
        private System.Windows.Forms.Timer timerlabel;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnAffine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnRailFence;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnPlayfair;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnColumnTrans;
    }
}