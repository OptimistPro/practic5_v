using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekarnia.Controls
{
	public partial class GoodsControls : UserControl
	{
		Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
		public GoodsControls()
		{
			InitializeComponent();
			Global.add_list(this);
			Application.OpenForms[0].Text = "Пекарня - Продукты";
			db_read();
		}

		void db_read()
		{
			try
			{
				List<Pekarnia.DataModel.Goods> goods = db.Goods.ToList();
				int j = 0;
				table.Rows.Clear();
				foreach (Pekarnia.DataModel.Goods d in goods)
				{

					table.Rows.Add();
					table.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", d.idGoods));
					table.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", d.Name));
					table.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", d.Quantity));
					table.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", d.Units.Name));
					table.Rows[j].Cells[4].Value = Convert.ToString(String.Format("{0}", d.Price));
					table.Rows[j].Cells[5].Value = Convert.ToString(String.Format("{0}", d.UnitMoney.Name));
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

		private void goods_new_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new AddGoodsControls(), Global.get_start_control());
		}

		private void table_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);
				Global.open(new Point(0, 24), new UpdateGoodsControls(id), Global.get_start_control());
			}
			catch { }
		}
	}
}
