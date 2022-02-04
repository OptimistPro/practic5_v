using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pekarnia.Controls
{
	public partial class ProviderControls : UserControl
	{

		Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
		public ProviderControls()
		{
			InitializeComponent();
			Global.add_list(this);
			Application.OpenForms[0].Text = "Пекарня - Поставщики";
			db_read();
		}

		void db_read()
		{
			try
			{
				List<Pekarnia.DataModel.Provider> provaders = db.Provider.ToList();
				int j = 0;
				table.Rows.Clear();
				foreach (Pekarnia.DataModel.Provider d in provaders)
				{
					
					table.Rows.Add();
					table.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", d.idProvider));
					table.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", d.Name));
					table.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", d.Email));
					table.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", d.Phone));
					j++;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(Convert.ToString(ex));
			}
		}


		private void Close_controls_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 0), null, Global.get_start_control());
			Application.OpenForms[0].Text = "Пекарня";
		}

		private void new_provider_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new AddProviderControls(), Global.get_start_control());
		}

		private void table_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);
				Global.open(new Point(0, 24), new UbdateProviderControls(id), Global.get_start_control());
			}
			catch { }
		}
	}
}
