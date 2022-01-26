using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        int deger, rastgelesayi;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SayiUret();
        }
        private void Btn_sorgula_Click(object sender, EventArgs e)
        {
            if ((deger = Convert.ToByte(hak_text.Text)) > 0)
            {
                KontrolEt();
                txtTahmin.Text = String.Empty;
            }
            else
            {
                if (MessageBox.Show("Kaybettiniz;\nYeni oyuna başlamak istermisiniz ?", "Hata..!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    YeniOyun();
                }
                else
                {
                    OyunKapat();
                }
            }
        }

        public void KontrolEt()
        {
            try
            {
                if (rndtxt.Text == txtTahmin.Text)
                {

                    sonuc_listesi.Items.Add("Tebrikler ==> Tahmininiz : " + txtTahmin.Text + " => [ Tahmininizi doğru ]");
                    deger--;
                    hak_text.Text = Convert.ToString(deger);
                    YeniOyun();
                }
                else
                {
                    if (int.Parse(txtTahmin.Text) > int.Parse(rndtxt.Text))
                    {
                        sonuc_listesi.Items.Add("Hatalı ==> Tahmininiz : " + txtTahmin.Text + " => [ Tahmininizi küçültün ]");
                        deger--;
                    }
                    else if (int.Parse(txtTahmin.Text) < int.Parse(rndtxt.Text))
                    {
                        sonuc_listesi.Items.Add("Hatalı ==> Tahmininiz : " + txtTahmin.Text + " => [ Tahmininizi büyültün ]");
                        deger--;
                    }
                    hak_text.Text = Convert.ToString(deger);
                    if (deger == 0)
                    {
                        Btn_sorgula.Text = "Tahmin = " + rndtxt.Text;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.", "Hata..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YeniOyun()
        {
            if (MessageBox.Show("Kazandınız;\nYeni oyuna başlamak istermisiniz ?", "Tebrikler..!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                hak_text.Text = "3";
                txtTahmin.Text = String.Empty;
                sonuc_listesi.Items.Clear();
                Btn_sorgula.Text = "Tahmini Sorgula";
                SayiUret();
            }
            else
            {
                OyunKapat();
            }
        }
        private void OyunKapat()
        {
            Application.Exit();
        }

        private void SayiUret()
        {
            Random rnd = new Random();
            rastgelesayi = rnd.Next(1, 11);
            rndtxt.Text = Convert.ToString(rastgelesayi);
        }
    }
}
