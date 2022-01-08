using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dark_calculator
{
    public partial class Form1 : Form
    {
        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0) 
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);   // ← Butonunun Tek Tek Sayı Silme Kodu !
            }

            if (textBox1.Text.Length == 0)      // TextBox Uzunluğu 0 İse TextBox Yazısını 0 Yap Demektir !
            {
                textBox1.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);    // + Buton'unu (Toplama İşlemi Butonu) Çalıştıran Kodlar !
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")   // Toplama İşleminin Sonucunu Çıkartır !
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }

            if (islem == "-")   // Çıkarma İşleminin Sonucunu Çıkartır !
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }

            if (islem == "*")   // Çarpma İşleminin Sonucunu Çıkartır !
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }

            if (islem == "/")   // Bölme İşleminin Sonucunu Çıkartır !
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }

            if (islem=="mod")   // Mod İşleminin Sonucunu Çıkartır !
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = ""; 
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);    // - Buton'unu (Çıkarma İşlemi Butonu) Çalıştıran Kodlar !
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);    // * Buton'unu (Çarpma İşlemi Butonu) Çalıştıran Kodlar !
            islem = "*";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);    // / Buton'unu (Bölme İşlemi Butonu) Çalıştıran Kodlar !
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);  // x² Buton'unu (Karesini Alma İşlemi Butonu) Çalıştıran Kodlar !
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);  // √ Buton'unu (Karekök İşlemi Butonu) Çalıştıran Kodlar !
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(textBox1.Text);  // 1/x Buton'unu (1'e Bölününce Kalan Sonucunu Gösteren İşlemi Butonu) Çalıştıran Kodlar !
            bolumx = 1 / (bolumx);
            textBox1.Text = Convert.ToString(bolumx);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";    // C Buton'unun (Yazıları Sıfıralayan Buton) Çalıştıran Kodlar !
            label1.Text = "0";
        }
    }
}
