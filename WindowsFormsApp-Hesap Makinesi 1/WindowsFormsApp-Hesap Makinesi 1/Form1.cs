using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Hesap_Makinesi_1
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlensinmi;
        private int _ilksayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HOŞ GELDİNİZ...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = ""; // işlemlerden herhangi birine bastıktan sonra, işlemden önce yazdıgımız sayıyı siler ama arka planda hafızada tutar.(ikinci sayıyı yazmak için siler yani)
            {
                _ekrantemizlensinmi = false; // ekranı temizler ama her tusa bastıgında , bunun olmaması için yazdık. işleme bastıktan sonra ikinci ikinci rakamını girerken siler yoğsam
            }
            if (label1.Text == "0") label1.Text = ""; // eğer ekranda 0 yazıyorsa onu sil. boş kalsın
            label1.Text += "1"; // += yaptık çünkü her basışımızda eklemesi için.(sadece = kullansaydık yalnızca 1 kez 1 yazacaktı)


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            label1.Text += 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlensinmi) label1.Text = "";
            {
                _ekrantemizlensinmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlensinmi = true;
            _ilksayı = Convert.ToInt32(label1.Text);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlensinmi = true;
            _ilksayı= Convert.ToInt32(label1.Text);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlensinmi= true;
            _ilksayı=Convert.ToInt32(label1.Text);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            _islem= '/';
            _ekrantemizlensinmi = true;
            _ilksayı = Convert.ToInt32(label1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ikincisayı = Convert.ToInt32(label1.Text);
            int sonuc=0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayı + ikincisayı;
                    break;
                case '-':
                    sonuc = _ilksayı - ikincisayı;
                    break;
                case '*':
                    sonuc = _ilksayı * ikincisayı;
                    break;
                case '/':
                    sonuc = _ilksayı / ikincisayı;
                    break;
            }
            label1.Text = Convert.ToString(sonuc);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text= "0";
        }

        
    }
}
