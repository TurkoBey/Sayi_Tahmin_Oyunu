
namespace Sayi_Tahmin_Oyunu
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.hak_text = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Btn_sorgula = new System.Windows.Forms.Button();
			this.txtTahmin = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.sonuc_listesi = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rndtxt = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "1 ile 10 arasındaki tahmini sayıyı bulun.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.hak_text);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Btn_sorgula);
			this.groupBox1.Controls.Add(this.txtTahmin);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(365, 261);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// hak_text
			// 
			this.hak_text.AutoSize = true;
			this.hak_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hak_text.Location = new System.Drawing.Point(123, 178);
			this.hak_text.Name = "hak_text";
			this.hak_text.Size = new System.Drawing.Size(15, 16);
			this.hak_text.TabIndex = 7;
			this.hak_text.Text = "3";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Tahmin hakkınız  : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(70, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(226, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Sayı tahmin oyununa hosgeldiniz";
			// 
			// Btn_sorgula
			// 
			this.Btn_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_sorgula.Location = new System.Drawing.Point(15, 206);
			this.Btn_sorgula.Name = "Btn_sorgula";
			this.Btn_sorgula.Size = new System.Drawing.Size(337, 29);
			this.Btn_sorgula.TabIndex = 4;
			this.Btn_sorgula.Text = "Tahmini Sorgula";
			this.Btn_sorgula.UseVisualStyleBackColor = true;
			this.Btn_sorgula.Click += new System.EventHandler(this.Btn_sorgula_Click);
			// 
			// txtTahmin
			// 
			this.txtTahmin.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTahmin.Location = new System.Drawing.Point(15, 137);
			this.txtTahmin.Name = "txtTahmin";
			this.txtTahmin.Size = new System.Drawing.Size(337, 22);
			this.txtTahmin.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sayıyı girin : ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(15, 44);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(337, 61);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(68, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Aklınızdan 1 ile 10 arasında bir sayı tutunuz.";
			// 
			// sonuc_listesi
			// 
			this.sonuc_listesi.BackColor = System.Drawing.SystemColors.Control;
			this.sonuc_listesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sonuc_listesi.FormattingEnabled = true;
			this.sonuc_listesi.ItemHeight = 15;
			this.sonuc_listesi.Location = new System.Drawing.Point(11, 30);
			this.sonuc_listesi.Name = "sonuc_listesi";
			this.sonuc_listesi.Size = new System.Drawing.Size(306, 214);
			this.sonuc_listesi.TabIndex = 2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.sonuc_listesi);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(383, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(327, 261);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sonuç";
			// 
			// rndtxt
			// 
			this.rndtxt.AutoSize = true;
			this.rndtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rndtxt.Location = new System.Drawing.Point(701, 264);
			this.rndtxt.Name = "rndtxt";
			this.rndtxt.Size = new System.Drawing.Size(0, 13);
			this.rndtxt.TabIndex = 8;
			this.rndtxt.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 285);
			this.Controls.Add(this.rndtxt);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sayi Tahmin Oyunu v.1.1.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTahmin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Btn_sorgula;
		private System.Windows.Forms.ListBox sonuc_listesi;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label hak_text;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label rndtxt;
	}
}

