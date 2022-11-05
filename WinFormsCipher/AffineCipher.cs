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
    public partial class AffineCipher : Form
    {
        string Plaintext, Ciphertext;
        int keyA, keyB;

        public AffineCipher()
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

        private int gcd(int a, int b)
        {
            int A = a, B = b, t;
            while (B != 0)
            {
                t = A;
                A = B;
                B = t % B;
            }
            return A;
        }
        private bool relativelyPrime(int a, int b)
        {
            return gcd(a, b) == 1;
        }

        String encryptMessage(char[] msg)
        {
            String cipher = "";
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] != ' ' && char.IsLetter(msg[i]))
                {
                    if (char.IsUpper(msg[i]))
                    {
                        cipher += (char)((((keyA * (msg[i] - 'A')) + keyB) % 26) + 'A');
                    }
                    else
                    {
                        cipher += (char)((((keyA * (msg[i] - 'a')) + keyB) % 26) + 'a');
                    }
                }
                else
                {
                    cipher += msg[i];
                }
            }
            return cipher;
        }

        String decryptCipher(String cipher)
        {
            String msg = "";
            int aInverse = 0;
            int flag = 0;

            for (int i = 0; i < 26; i++)
            {
                flag = (keyA * i) % 26;

                if (flag == 1)
                {
                    aInverse = i;
                }
            }
            for (int i = 0; i < cipher.Length; i++)
            {
                if (cipher[i] != ' ' && char.IsLetter(cipher[i]))
                {
                    if (!char.IsLower(cipher[i]))
                    {
                        msg += (char)(((aInverse * ((cipher[i] + 'A' - keyB)) % 26)) + 'A');
                    }
                    else
                    {
                        //msg += (char)(((aInverse * (cipher[i] - 'a' - keyB)) % 26) + 'a'); -- sai nè 

                        msg += Convert.ToChar((aInverse * (cipher[i] - 'a' - keyB) % 26 + 26) % 26 + 'a');

                        /*int todec = cipher[i] - 'a';
                        int cmapping = (a_inv * (todec - keyB));
                        int mod = (cmapping % 26 + 26) % 26;
                        Console.WriteLine(aInverse +" "+ todec +" "+ keyB+ " " +cmapping +" "+ mod);
                        char c = (char)(mod + 'a');
                        msg += c;*/
                    }
                }
                else
                {
                    msg += cipher[i];
                }
            }

            return msg;
        }

        private void textBoxKeyA_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                return;
            }
            if (!relativelyPrime(Int32.Parse(((TextBox)sender).Text), 26))
            {
                MessageBox.Show("Vui lòng nhập số nguyên tố cùng nhau với 26!");
                ((TextBox)sender).Focus();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập bản rõ!");
                textBoxInput.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxKeyA.Text) || String.IsNullOrWhiteSpace(textBoxKeyB.Text))
            {
                MessageBox.Show("Vui lòng nhập khóa!");
                if (String.IsNullOrWhiteSpace(textBoxKeyA.Text))
                {
                    textBoxKeyA.Focus();
                }
                else
                {
                    textBoxKeyB.Focus();
                }
                return;
            }
            Plaintext = textBoxInput.Text;
            keyA = Int32.Parse(textBoxKeyA.Text);
            keyB = Int32.Parse(textBoxKeyB.Text);
            textBoxResult.Text = encryptMessage(Plaintext.ToCharArray());
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập bản mã!");
                textBoxInput.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(textBoxKeyA.Text) || String.IsNullOrWhiteSpace(textBoxKeyB.Text))
            {
                MessageBox.Show("Vui lòng nhập khóa!");
                if (String.IsNullOrWhiteSpace(textBoxKeyA.Text))
                {
                    textBoxKeyA.Focus();
                }
                else
                {
                    textBoxKeyB.Focus();
                }
                return;
            }
            Ciphertext = textBoxResult.Text;
            keyA = Int32.Parse(textBoxKeyA.Text);
            keyB = Int32.Parse(textBoxKeyB.Text);
            textBoxInput.Text = decryptCipher(Ciphertext);
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
