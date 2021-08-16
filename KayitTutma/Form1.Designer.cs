
namespace KayitTutma
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOde = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtToplamTutar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtVade = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtTarih = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LabelSenetTutar = new System.Windows.Forms.Label();
			this.LabelSenetVadesi = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnOdemeGecmis = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOde
			// 
			this.btnOde.BackColor = System.Drawing.Color.LimeGreen;
			this.btnOde.Location = new System.Drawing.Point(611, 410);
			this.btnOde.Name = "btnOde";
			this.btnOde.Size = new System.Drawing.Size(102, 36);
			this.btnOde.TabIndex = 1;
			this.btnOde.Text = "ÖDE";
			this.btnOde.UseVisualStyleBackColor = false;
			this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(14, 248);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 36);
			this.button2.TabIndex = 2;
			this.button2.Text = "SENET EKLE";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(109, 24);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(100, 20);
			this.txtAciklama.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Senet Açıklama :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Toplam Tutar :";
			// 
			// txtToplamTutar
			// 
			this.txtToplamTutar.Location = new System.Drawing.Point(109, 61);
			this.txtToplamTutar.Name = "txtToplamTutar";
			this.txtToplamTutar.Size = new System.Drawing.Size(100, 20);
			this.txtToplamTutar.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Vade :";
			// 
			// txtVade
			// 
			this.txtVade.Location = new System.Drawing.Point(109, 97);
			this.txtVade.Name = "txtVade";
			this.txtVade.Size = new System.Drawing.Size(100, 20);
			this.txtVade.TabIndex = 7;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(416, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(626, 289);
			this.panel1.TabIndex = 10;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(3, 148);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(618, 136);
			this.dataGridView2.TabIndex = 1;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(618, 139);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.dtTarih);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.txtAciklama);
			this.panel2.Controls.Add(this.txtToplamTutar);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtVade);
			this.panel2.Location = new System.Drawing.Point(34, 52);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(337, 289);
			this.panel2.TabIndex = 11;
			// 
			// dtTarih
			// 
			this.dtTarih.Location = new System.Drawing.Point(109, 132);
			this.dtTarih.Name = "dtTarih";
			this.dtTarih.Size = new System.Drawing.Size(100, 20);
			this.dtTarih.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Tarih :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LabelSenetTutar);
			this.groupBox1.Controls.Add(this.LabelSenetVadesi);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(732, 371);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 76);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Seçilen Senet :";
			// 
			// LabelSenetTutar
			// 
			this.LabelSenetTutar.AutoSize = true;
			this.LabelSenetTutar.Location = new System.Drawing.Point(131, 51);
			this.LabelSenetTutar.Name = "LabelSenetTutar";
			this.LabelSenetTutar.Size = new System.Drawing.Size(40, 13);
			this.LabelSenetTutar.TabIndex = 3;
			this.LabelSenetTutar.Text = "000,00";
			// 
			// LabelSenetVadesi
			// 
			this.LabelSenetVadesi.AutoSize = true;
			this.LabelSenetVadesi.Location = new System.Drawing.Point(131, 24);
			this.LabelSenetVadesi.Name = "LabelSenetVadesi";
			this.LabelSenetVadesi.Size = new System.Drawing.Size(19, 13);
			this.LabelSenetVadesi.TabIndex = 2;
			this.LabelSenetVadesi.Text = "00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Senet Tutarı :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Senet Vadesi :";
			// 
			// btnOdemeGecmis
			// 
			this.btnOdemeGecmis.Location = new System.Drawing.Point(49, 410);
			this.btnOdemeGecmis.Name = "btnOdemeGecmis";
			this.btnOdemeGecmis.Size = new System.Drawing.Size(102, 36);
			this.btnOdemeGecmis.TabIndex = 14;
			this.btnOdemeGecmis.Text = "Ödeme Geçmişi";
			this.btnOdemeGecmis.UseVisualStyleBackColor = true;
			this.btnOdemeGecmis.Click += new System.EventHandler(this.btnOdemeGecmis_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 458);
			this.Controls.Add(this.btnOdemeGecmis);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnOde);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Senet Takip Programı";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnOde;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtToplamTutar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVade;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtTarih;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label LabelSenetTutar;
		private System.Windows.Forms.Label LabelSenetVadesi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnOdemeGecmis;
	}
}

