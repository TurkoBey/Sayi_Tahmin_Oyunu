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

		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_sorgula_Click(object sender, EventArgs e)
		{
			int deger = Convert.ToByte(hak_text.Text);
			if (deger > 0)
			{
				KontrolEt();
				txtTahmin.Text = "";
			}
			else
			{
				DialogResult kaybettiniz = new DialogResult();
				kaybettiniz = MessageBox.Show("Kaybettiniz;\nYeni oyuna başlamak istermisiniz ?", "Hata..!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if (kaybettiniz == DialogResult.Yes)
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

				int deger = Convert.ToInt32(hak_text.Text);
				int rastgelesayi = Convert.ToInt32(rndtxt.Text);
				int girilensayi = Convert.ToInt32(txtTahmin.Text);
				
				if (rastgelesayi == girilensayi)
				{
					
					sonuc_listesi.Items.Add("Tebrikler ==> Tahmininiz : " + girilensayi + " => [ Tahmininizi doğru ]");
					deger--;
					hak_text.Text = Convert.ToString(deger);
					YeniOyun();
				}
				else
				{
					if (girilensayi > rastgelesayi)
					{
						sonuc_listesi.Items.Add("Hatalı ==> Tahmininiz : " + girilensayi + " => [ Tahmininizi küçültün ]");
						deger--;
					}else if (girilensayi < rastgelesayi)
					{
						sonuc_listesi.Items.Add("Hatalı ==> Tahmininiz : " + girilensayi + " => [ Tahmininizi büyültün ]");
						deger--;
					}
					hak_text.Text = Convert.ToString(deger);
					if (deger == 0)
					{
						Btn_sorgula.Text = "Tahmin = " + Convert.ToString(rastgelesayi);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Lütfen sadece sayı giriniz.", "Hata..!",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		private void YeniOyun()
		{
			Random rnd = new Random();
			int rastgelesayi = rnd.Next(1, 10);
			rndtxt.Text = Convert.ToString(rastgelesayi);

			DialogResult snc = new DialogResult();
			snc = MessageBox.Show("Kazandınız;\nYeni oyuna başlamak istermisiniz ?", "Tebrikler..!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			if (snc == DialogResult.Yes)
			{
				hak_text.Text = "3";
				txtTahmin.Text = "";
				sonuc_listesi.Items.Clear();
				Btn_sorgula.Text = "Tahmini Sorgula";
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

		private void Form1_Load(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int rastgelesayi = rnd.Next(1, 10);
			rndtxt.Text = Convert.ToString(rastgelesayi);
		}
	}
}
