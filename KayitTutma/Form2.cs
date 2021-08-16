using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitTutma
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			KayitDBEntities db = new KayitDBEntities();
			dataGridView1.DataSource = db.OdemeGecmisi.ToList();
		}
	}
}
