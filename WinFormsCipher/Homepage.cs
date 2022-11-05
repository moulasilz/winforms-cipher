using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCipher
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.Text = footermenulabel.Text;
        }
        // Change color of function button when deactive childform
        private void ChangeColorDeactivated()
        {
            //this.BtnCaesar.BackColor = System.Drawing.Color.FromArgb(25, 113, 176);
            //this.BtnVigenere.BackColor = System.Drawing.Color.FromArgb(25, 113, 176);
            //this.BtnVigenere.BackColor = System.Drawing.Color.LightPink;
            //this.BtnCaesar.BackColor = System.Drawing.Color.LightPink;
           // this.BtnVigenere.BackColor = System.Drawing.Color.White;
            //this.BtnVigenere.ForeColor = System.Drawing.Color.Black;

            //this.BtnCaesar.BackColor = System.Drawing.Color.White;
           // this.BtnCaesar.ForeColor = System.Drawing.Color.Black;
            (this.BtnVigenere.Parent as Panel).BackColor = System.Drawing.Color.Transparent;
            (this.BtnCaesar.Parent as Panel).BackColor = System.Drawing.Color.Transparent;
            (this.BtnAffine.Parent as Panel).BackColor = System.Drawing.Color.Transparent;
            (this.BtnRailFence.Parent as Panel).BackColor = System.Drawing.Color.Transparent;
            (this.BtnPlayfair.Parent as Panel).BackColor = System.Drawing.Color.Transparent;
            (this.BtnColumnTrans.Parent as Panel).BackColor = System.Drawing.Color.Transparent;

        }

        // Change color of function button when active childform
        private void ChangeColorActivated(Button btn)
        {
            Panel pane = btn.Parent as Panel;
            //btn.BackColor = System.Drawing.Color.FromArgb(0, 185, 181);
            //btn.BackColor = System.Drawing.Color.FromArgb(255, 131, 150);
            //btn.ForeColor = System.Drawing.Color.White;
            pane.BackColor = System.Drawing.Color.FromArgb(255, 131, 150);
            //btn.ForeColor = System.Drawing.Color.FromArgb(255, 131, 150);

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        // Open Children Form inside panelMainContainer

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            Form temp = null;
            if (activeForm != null) temp = activeForm;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Add(childForm);
            panelMainContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if(temp != null) temp.Close();
            
        }
    
        private void BtnCaesar_Click(object sender, EventArgs e)
        {

            ChangeColorDeactivated();
            openChildFormInPanel(new CaesarCipher());
            ChangeColorActivated(BtnCaesar);
        }

        private void BtnVigenere_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            openChildFormInPanel(new VigenereCipher());
            ChangeColorActivated(BtnVigenere);
        }

        private void BtnAffine_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            openChildFormInPanel(new AffineCipher());
            ChangeColorActivated((Button)sender);
        }
        private void BtnRailFence_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            openChildFormInPanel(new RailFenceCipher());
            ChangeColorActivated((Button)sender);
        }
        private void BtnPlayfair_Click(object sender, EventArgs e)
        {
            /*ChangeColorDeactivated();
            openChildFormInPanel(new PlayfairCipher());
            ChangeColorActivated((Button)sender);*/
            MessageBox.Show("Chức năng đang trong quá trình phát triển!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnColumnTrans_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            openChildFormInPanel(new ColumnTransCipher());
            ChangeColorActivated((Button)sender);
        }
        private void timerlabel_Tick(object sender, EventArgs e)
        {

            timerlabel.Interval = 100;
            String s = footermenulabel.Text;
            footermenulabel.Text = s.Substring(s.Length - 1, 1) + s.Substring(0, s.Length - 1);
        }
            

        private void timerImage_Tick(object sender, EventArgs e)
        {
            timerImage.Interval = 1;
            pictureBoxMenu.Top++;
            pictureBoxMenu.Left--;
            if (pictureBoxMenu.Top > panel1.Height)
            {
                pictureBoxMenu.Top = -100;
                pictureBoxMenu.Left = pictureBoxMenu.Width /2 ;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
