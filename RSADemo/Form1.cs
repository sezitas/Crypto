using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSADemo
{
    public partial class RSAWindow : Form
    {
        private  const int ALPHABET_LENGHT = 27;

        private PrimeGenerator primeGenertor = new PrimeGenerator();
        private int m_k;
        private int m_l;
        private BigInteger N;
        private BigInteger E;
        private BigInteger D;
        private String plainText;
        private String encryptedText;
        private String decryptedText;
        private const String ALPHABET = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public RSAWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Error(String error)
        {
            MessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            System.Numerics.BigInteger p, q, n, phi;
            System.Numerics.BigInteger kp, lp;


            if (kTextBox.Text.Length == 0 || lTextBox.Text.Length == 0)
            {
                Error("Insert K and L!");
                return;
            }

            GeneratingLBL.Visible = true;

            m_k = Int32.Parse(kTextBox.Text.ToString());
            m_l = Int32.Parse(lTextBox.Text.ToString());

            kp = primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, m_k);
            lp = primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, m_l);

            //int k, l;

            //k = m_k * 5;
            //l = m_l * 5;
            //l = l / 8;

            int l = lp.ToByteArray().Length;

            q = primeGenertor.GeneratePrime((l / 2));
            p = primeGenertor.GeneratePrime((l / 2));

            System.Numerics.BigInteger prod = p * q;

            while (kp > prod || prod > lp)
            {
                q = primeGenertor.GeneratePrime((l / 2));
                p = primeGenertor.GeneratePrime((l / 2));
                prod = p * q;
            }


            pTextBox.Text = p.ToString();

            qTextBox.Text = q.ToString();

            n = prod;
            phi = (p - 1) * (q - 1);

            nRichTextBox.Text = n.ToString();
            N = n;
            rphiRichTextBox.Text = phi.ToString();
            E = FindE(phi);
            eRichTextBox.Text = E.ToString();
            D = FindD(phi, E);
            dRichTextBox.Text = D.ToString();

            GeneratingLBL.Visible = false;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            BigInteger.TryParse(eRichTextBox.Text, out E);
            BigInteger.TryParse(nRichTextBox.Text, out N);
            BigInteger.TryParse(dRichTextBox.Text, out D);

            if (IsValidText(PlainRichTextBox.Text))
            {
                PadText();
                Encrypt();
            } else {
                Error("Not all chars are in the alphabet!");
                return;
            }
        }

        private void Encrypt()
        {
            encryptedText = "";
            int power = m_k - 1;
            int index = 0;
            System.Numerics.BigInteger encryptedValue = 0;

            while (index < plainText.Length)
            {
                encryptedValue += primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, power) * ALPHABET.IndexOf(plainText[index]);
                power--;

                if (power % m_k == 0)
                {
                    if (index == (plainText.Length - 1))
                    {
                        EncryptValue(encryptedValue);
                        break;
                    }
                    index++;
                    encryptedValue += primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, power) * ALPHABET.IndexOf(plainText[index]);
                    EncryptValue(encryptedValue);
                    encryptedValue = 0;
                    power = m_k - 1;
 
                }

                index++;
            }

            EncryptedRichTextBox.Text = encryptedText;
        }

        private void EncryptValue(BigInteger encryptedValue)
        {
            BigInteger c = primeGenertor.RepeatedSquaringExp(encryptedValue, E, N);

            int pow = m_l - 1;
            int crypted;

            while (pow != 0)
            {
                BigInteger p = primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, pow);
                BigInteger x = c / p;

                crypted = Int32.Parse(x.ToString());

                encryptedText += ALPHABET[crypted];
                pow--;

                c = c - p * x;
            }

            crypted = Int32.Parse(c.ToString());

            encryptedText += ALPHABET[crypted];

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (IsValidText(EncryptedRichTextBox.Text))
            {
                //PadText();
                Decrypt();
            }
            else
            {
                Error("Not all chars are in the alphabet!");
                return;
            }
        }

        private void Decrypt()
        {
            decryptedText = "";
            int power = m_l - 1;
            int index = 0;
            System.Numerics.BigInteger decryptedValue = 0;

            while (index < encryptedText.Length)
            {
                decryptedValue += primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, power) * ALPHABET.IndexOf(encryptedText[index]);
                power--;

                if (power % m_l == 0)
                {
                    if (index == (encryptedText.Length - 1))
                    {
                        EncryptValue(decryptedValue);
                        break;
                    }
                    index++;
                    decryptedValue += primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, power) * ALPHABET.IndexOf(encryptedText[index]);
                    DecryptValue(decryptedValue);
                    decryptedValue = 0;
                    power = m_l - 1;

                }

                index++;
            }

            DecryptedRichTextBox.Text = decryptedText;
        }

        private void DecryptValue(BigInteger encryptedValue)
        {
            BigInteger c = primeGenertor.RepeatedSquaringExp(encryptedValue, D, N);

            int pow = m_k - 1;
            int crypted;

            while (pow != 0)
            {
                BigInteger p = primeGenertor.RepeatedSquaringExp(ALPHABET_LENGHT, pow);
                BigInteger x = c / p;

                crypted = Int32.Parse(x.ToString());

                decryptedText += ALPHABET[crypted];
                pow--;

                c = c - p * x;
            }

            crypted = Int32.Parse(c.ToString());

            decryptedText += ALPHABET[crypted];

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            pTextBox.Text = "";
            qTextBox.Text = "";
            nRichTextBox.Text = "";
            rphiRichTextBox.Text = "";
            eRichTextBox.Text = "";
            dRichTextBox.Text = "";
            PlainRichTextBox.Text = "";
            EncryptedRichTextBox.Text = "";
            DecryptedRichTextBox.Text = "";

        }

        private bool IsValidText(String text)
        {
            foreach(char c in text)
            {
                if (ALPHABET.IndexOf(c) == -1)
                    return false;
            }
            return true;
        }

        private void PadText()
        {
            plainText = PlainRichTextBox.Text;

            while (plainText.Length % m_k != 0)
            {
                plainText += " ";
            }

        }

        private System.Numerics.BigInteger FindE(System.Numerics.BigInteger Phi)
        {
            System.Numerics.BigInteger e = Phi - 3;

            while (1 != primeGenertor.GCD(e, Phi))
            {
                e--;
            }

            return e;
        }

        private System.Numerics.BigInteger FindD(System.Numerics.BigInteger Phi, System.Numerics.BigInteger E)
        {
            System.Numerics.BigInteger m0 = Phi, t, q;
            System.Numerics.BigInteger x0 = 0, x1 = 1;

            if (Phi == 1)
                return 0;

            while (E > 1)
            {
                q = E / Phi;

                t = Phi;

                Phi = E % Phi;
                E = t;

                t = x0;

                x0 = x1 - q * x0;

                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }
    }
}
