using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsCipher
{
    public partial class ColumnTransCipher : Form
    {
        string Plaintext, Ciphertext, key;

        public ColumnTransCipher()
        {
            InitializeComponent();
            label3.Text = label3.Text.ToUpper();
        }

        private string Cipher(string input, string key, bool isEncrypt)
        {
            string output = "";
            
            return output;
        }

        public string Encipher(string input, string key)
        {
            return Cipher(input, key, true);
        }

        public string Decipher(string input, string key)
        {
            return Cipher(input, key, false);
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập bản rõ!");
                textBoxInput.Focus();
                return;
            }
            if (textBoxKey.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập khóa!");
                textBoxKey.Focus();
                return;
            }
            Plaintext = textBoxInput.Text;
            key = textBoxKey.Text;
            textBoxResult.Text = Encipher(Plaintext, key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập bản mã!");
                textBoxInput.Focus();
                return;
            }
            if (textBoxKey.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập khóa!");
                textBoxKey.Focus();
                return;
            }
            Ciphertext = textBoxResult.Text;
            key = textBoxKey.Text;
            textBoxInput.Text = Decipher(Ciphertext, key);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttontextBoxInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Mở file bản rõ";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void buttontextBoxResult_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Mở file bản mã";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxResult.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEncrypt_Click(sender, e);
            }
        }

        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDecrypt_Click(sender, e);
            }
        }


        private void buttonsaveInput_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() == "") return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Lưu bản rõ";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = false;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxInput.Text);
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void buttonsaveOutput_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Trim() == "") return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Lưu bản mã";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = false;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxResult.Text);
                MessageBox.Show("Lưu thành công!");
            }
        }

    }
}
