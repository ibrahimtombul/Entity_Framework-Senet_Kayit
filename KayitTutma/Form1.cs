using System;
using System.Linq;
using System.Windows.Forms;

namespace KayitTutma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			#region Gridleri Yenileme
			KayitDBEntities db = new KayitDBEntities();
			dataGridView1.DataSource = db.Senetler.ToList();
			//dataGridView2.DataSource = db.Vadeler.ToList();
			#endregion

		}

		private void button2_Click(object sender, EventArgs e)
		{
			#region Senet Kayıt
			KayitDBEntities db = new KayitDBEntities();
			Senetler st = new Senetler();
			st.Aciklama = txtAciklama.Text;
			st.Tarih = DateTime.Parse(dtTarih.Text);
			st.ToplamTutar = decimal.Parse(txtToplamTutar.Text);
			st.Vade = int.Parse(txtVade.Text);
			db.Senetler.Add(st);
			db.SaveChanges();
			vadeOlustur(st.id, st.Vade, st.ToplamTutar);
			MessageBox.Show("Yeni Senet Eklendi !");
			dataGridView1.DataSource = db.Senetler.ToList();
			txtAciklama.Clear();
			txtToplamTutar.Clear();
			txtVade.Clear();
			#endregion

		}
		public void vadeOlustur(int id,int vade,decimal tutar)
		{
			#region VadeOlusturma
			KayitDBEntities db = new KayitDBEntities();
			Vadeler vd = new Vadeler();
			decimal vadeTutar = tutar / vade;
			vadeTutar = Math.Ceiling(vadeTutar);
			for (int i = 0; i < vade-1; i++)
			{
				vd.senetID = id;
				vd.Tarih = DateTime.Parse(dtTarih.Text).AddMonths(i + 1);
				vd.Tutar = vadeTutar;
				vd.VadeNo = i + 1;
				db.Vadeler.Add(vd);
				db.SaveChanges();
			}
			
			vadeTutar = (vadeTutar * (vade - 1));
			decimal sonVade = tutar - vadeTutar;
			vd.senetID = id;
			vd.Tarih = DateTime.Parse(dtTarih.Text).AddMonths(vade);
			vd.VadeNo = vade;
			vd.Tutar = sonVade;
			db.Vadeler.Add(vd);
			db.SaveChanges();
			//dataGridView2.DataSource = db.Vadeler.ToList();
			#endregion

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			KayitDBEntities db = new KayitDBEntities();
			int selectedID;
			selectedID=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			dataGridView2.DataSource = db.Vadeler.Where(Vadeler => Vadeler.senetID == selectedID).ToList();
		}
		int vadeid=0,senetID=0;
		private void btnOde_Click(object sender, EventArgs e)
		{
			KayitDBEntities db = new KayitDBEntities();
			OdemeGecmisi og = new OdemeGecmisi();
			og.senetID = senetID;
			og.Vade = int.Parse(LabelSenetVadesi.Text);
			og.OdemeTarihi = System.DateTime.Now;
			db.OdemeGecmisi.Add(og);
			Vadeler vd = new Vadeler();
			if (vadeid == 0)
			{
				MessageBox.Show("Veri Bulunamadı !");
			}
			else if (vadeid == null)
			{
				MessageBox.Show("Vade seçilmedi");
				
			}
			else
			{
				db.Vadeler.Remove(db.Vadeler.Find(vadeid));
				MessageBox.Show(vadeid + " 'numaralı senet ödenerek silindi.");
				db.SaveChanges();
			}
			
			
			dataGridView2.DataSource = db.Vadeler.ToList();
		}

		private void btnOdemeGecmis_Click(object sender, EventArgs e)
		{
			Form2 ogForm = new Form2();
			ogForm.Show();
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			vadeid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
			senetID=int.Parse(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
			LabelSenetVadesi.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
			LabelSenetTutar.Text= dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
	}
}
