using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Brute_Force_Attack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTeknika_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTeknika.SelectedItem.ToString() == "Ciphertext only")
            {
                txtPlaintext.Hide();
                txtKey.Hide();
                lblKey.Hide();
                lblPlaintext.Hide();
                btnEncrypt.Hide();
                pnlFrequency.Hide();
            }
            else if (cmbTeknika.SelectedItem.ToString() == "Known plaintext")
            {
                txtPlaintext.Show();
                txtKey.Show();
                lblKey.Show();
                lblPlaintext.Show();
                btnEncrypt.Show();
                pnlFrequency.Hide();

            }
            
            else if (cmbTeknika.SelectedItem.ToString() == "Frequency analysis")
            {
                txtPlaintext.Hide();
                txtKey.Hide();
                lblKey.Hide();
                lblPlaintext.Hide();
                btnEncrypt.Hide();
                pnlFrequency.Show();
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbTeknika.SelectedItem.ToString() == "Known plaintext")
            {
                string plaintext = txtPlaintext.Text;
                string key = txtKey.Text;
                string ciphertext = "";
                int keyy = int.Parse(key);

                for (int i = 0; i < plaintext.Length; i++)
                {
                    ciphertext += (char)(plaintext[i] + keyy);
                }
                txtCiphertext.Text = ciphertext;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (cmbTeknika.SelectedItem.ToString() == "Ciphertext only")
            {
                string ciphertext = txtCiphertext.Text;
                ciphertext = ciphertext.ToUpper();               //kthimi ne shkronja te medha
                ciphertext = ciphertext.Replace(" ", "");          //eliminimi i hapesirave

                String result = "";
                int c = 0;
                string a = "";
                string b = "";
                while (c < 26)
                {
                    string plaintext = "";
                    for (int i = 0; i < ciphertext.Length; i++)
                    {
                        plaintext += (char)(ciphertext[i] - c);
                        a = plaintext;
                        b = "Key " + c + " : " + a;

                    }

                    result = result + b + "\r\n";
                   
                    
                    c++;
                }

                txtResult.Text = result;
            }
            else if (cmbTeknika.SelectedItem.ToString() == "Frequency analysis")
            {
                try
                {
                    string ciphertext = txtCiphertext.Text;

                    Dictionary<char, double> frequencies = AnalyseFrequency(ciphertext);
                    double maxFreq = frequencies.Values.Max();
                    char maxChar = frequencies.Keys.Where(c => frequencies[c] == maxFreq).FirstOrDefault();
                    
                    String result = "";

                    int key = (maxChar - 'e' + 'A') % 65;

                    maxFreq = Math.Round(maxFreq, 2, MidpointRounding.ToEven);

                    result += "Most used character is probably: " + maxChar + " with probability: " + maxFreq + "\r\n";
                    result += "Key would be: " + key + "\r\n";

                    string a = "";
                    string plaintext = "";
                    for (int i = 0; i < ciphertext.Length; i++)
                    {
                        plaintext += (char)(ciphertext[i] - key);
                        a = plaintext;
                    }
                    result += "Plain text would be: " + a;
                    txtResult.Text = result;
                }catch(Exception)
                {
                    MessageBox.Show("Please fill up the fields!", "Error");
                }

            }

            else if (cmbTeknika.SelectedItem.ToString() == "Known plaintext")
            {
                string ciphertext = txtCiphertext.Text;
                int key =int.Parse(txtKey.Text);
                string a = "";
                string plaintext = "";
                    for (int i = 0; i < ciphertext.Length; i++)
                    {
                        plaintext += (char)(ciphertext[i] - key);
                        a = plaintext;
                    }
              txtResult.Text = "Rezultati:\r\n"+a;
            }
        }
        private void txtPlaintext_TextChanged(object sender, EventArgs e)
        {
            if (cmbTeknika.SelectedItem.ToString() == "Known plaintext")
            {
                txtPlaintext.PasswordChar = '*';
                txtKey.PasswordChar = '*';
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<char, double> AnalyseFrequency(string text)
        {
            if (text == null)
                return null;

            Dictionary<char, double> frequencies = new Dictionary<char, double>();
            int textLength = text.Length;

            for (int i = 0; i < textLength; i++)
            {
                char c = text[i];
                char key = '#';

                //largimi i karaktereve qe nuk jane shkronja
                if ((c >= 'a' && c <= 'z'))
                    key = c;
                if (c >= 'A' && c <= 'Z')
                    key = (char)(c + 'a' - 'A');

                if (frequencies.Keys.Contains(key))
                    frequencies[key] = frequencies[key] + 1;
                else
                    frequencies[key] = 1;
            }
            //cannot enumerate throught the dictionnay keys directly.
            List<char> keys = frequencies.Keys.ToList();

            foreach (char c in keys)
            {
                frequencies[c] /= textLength;
            }

            return frequencies;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTeknika.SelectedItem ="Frequency analysis";
        }

        private void txtCiphertext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
