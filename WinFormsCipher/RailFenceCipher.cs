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
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsCipher
{
    public partial class RailFenceCipher : Form
    {
        string Plaintext, Ciphertext;
        int key;

        public RailFenceCipher()
        {
            InitializeComponent();
            label3.Text = label3.Text.ToUpper();
        }
        private void KeyPressOnlyNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public string Encipher(string text, int key)
        {
            char[,] rail = new char[key, text.Length];

            for (int i = 0; i < key; i++)
                for (int j = 0; j < text.Length; j++)
                    rail[i,j] = '0';

            bool dir_down = false;
            int row = 0;
            int col = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (row == 0 || row == key - 1)
                    dir_down = !dir_down;
                rail[row,col++] = text[i];
                if (dir_down) row++; else row--;
            }

            string result = "";
            for (int i = 0; i < key; i++)
                for (int j = 0; j < text.Length; j++)
                    if (rail[i,j] != '0')
                        result += rail[i,j];

            return result;
        }

        public string Decipher(string cipher, int key)
        {
            char[,] rail = new char[key, cipher.Length];

            for (int i = 0; i < key; i++)
                for (int j = 0; j < cipher.Length; j++)
                    rail[i,j] = '\n';

            bool dir_down = false;
            int row = 0;
            int col = 0;

            for (int i = 0; i < cipher.Length; i++)
            {
                if (row == 0 || row == key - 1)
                    dir_down = !dir_down;

                rail[row,col++] = '*';
                if (dir_down) row++; else row--;
            }

            int index = 0;
            for (int i = 0; i < key; i++)
                for (int j = 0; j < cipher.Length; j++)
                    if (rail[i,j] == '*' && index < cipher.Length)
                        rail[i,j] = cipher[index++];


            string result = "";
            row = 0;
            col = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                if (row == 0) dir_down = true;
                if (row == key - 1) dir_down = false;

                if (rail[row,col] != '*')
                    result += rail[row,col++];

                if (dir_down) row++; else row--;
            }
            return result;
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
            key = Int32.Parse(textBoxKey.Text);
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
            key = Int32.Parse(textBoxKey.Text);
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
