using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOT_HESAPLAMA
{
    public partial class mainPage : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public int _hesapla;
        public int _sayac;
        public string _gectimi;

        public mainPage()
        {
            InitializeComponent();
        }

        //navBarPanel İşlemleri ST

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniMazeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void navarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isMouseDown)
            {
               
                this.Location = new Point(
                    (this.Left - mouseOffset.X) + e.X,
                    (this.Top - mouseOffset.Y) + e.Y);
            }
        }

        private void navarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            
            isMouseDown = false;
        }

        //navbar panel islemleri STP

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hspBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int sınavNot1 = Convert.ToInt32(sNot1.Text); //STRİNG İfadeleri İnt e Cevirme
                int sınavNot2 = Convert.ToInt32(sNot2.Text);

                int sozlu1 = Convert.ToInt32(sozN1.Text);
                int sozlu2 = Convert.ToInt32(sozN2.Text);//STRİNG İfadeleri İnt e Cevirme
                _hesapla = (sınavNot1 + sınavNot2 + sozlu1 + sozlu2) / 4; //ortalama hesaplama

                //List Box a İtems Atama
                sncListBX.Items.Add($"1. Sınav: {sınavNot1.ToString()}");
                sncListBX.Items.Add($"2.Sözlü: {sozlu1.ToString()}");
                sncListBX.Items.Add($"------------------");
                sncListBX.Items.Add($"2. Sınav: {sınavNot2.ToString()}");
                sncListBX.Items.Add($"2. Sözlü: {sozlu2.ToString()}");
                sncListBX.Items.Add($"------------------");
                sncListBX.Items.Add($"ORTALAMA: {_hesapla.ToString()}");
                if(_hesapla == 0) //Kaldı Geçti Koşuları :)
                {
                    _gectimi = "Sence Geçtinmi -- KALDI";
                }else if(_hesapla <= 49)
                {
                    _gectimi = "YAPACAK BİŞEY YOK -- KALDI";
                }else if ( _hesapla >= 50)
                {
                    _gectimi = "GEÇTİN";
                }else if(_hesapla > 101)
                {
                    _gectimi = "Geçerli Not Girin";
                }
                else
                {
                    _gectimi = "Bende Bilmiyomi";
                }
                sncListBX.Items.Add($"{_gectimi}");
            }
            catch (FormatException) //Eğer Bir Format Hatası Olursa Mesaj Olarak Hatayı Bildirir Ve Programın Çökmesini Engeler
            {
                MessageBox.Show("Format Hatısı Lütfen Sayı Girin");
            }

            _sayac++; //her buttona basıldığında sayac değişkenini bir artırır

            //Eğer Hesaplama Limiti 3ü Geçerse Eski Hesaplamaları Siler
            if(_sayac > 3)
            {
                sncListBX.Items.Clear();
                sncListBX.Items.Add("Limit Doldu Eski Hesaplamalar Silindi..");
                _sayac = 0; //Eski Hesaplar Silindikten Sonra Sayacın Değerini Sıfıra Atar
            }
        }
    }
}


//Bugra Akdemir
//Kastamonu/ Taşköprü