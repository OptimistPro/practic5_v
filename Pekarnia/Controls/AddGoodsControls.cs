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
	public partial class AddGoodsControls : UserControl
	{
		public AddGoodsControls()
		{
			InitializeComponent();
			Global.add_list(this);
			Application.OpenForms[0].Text = "Пекарня - Продукты - Новый продукт";
			db_read();
		}

		void db_read()
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				List<Pekarnia.DataModel.Units> units = db.Units.ToList();
				foreach (Pekarnia.DataModel.Units d in units)
				{
					izmen.Items.Add(Convert.ToString(String.Format("{0}", d.Name)));

				}

				List<Pekarnia.DataModel.UnitMoney> unitsm = db.UnitMoney.ToList();
				foreach (Pekarnia.DataModel.UnitMoney d in unitsm)
				{
					valit.Items.Add(Convert.ToString(String.Format("{0}", d.Name)));

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(Convert.ToString(ex));
			}
		}

		private void nazad_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new GoodsControls(), Global.get_start_control());
		}

		private void add_provider_Click(object sender, EventArgs e)
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.Goods goods = new Pekarnia.DataModel.Goods();
				goods.Name = names.Text;
				goods.Quantity = System.Convert.ToDouble(kol.Value);
				goods.idUnit = izmen.SelectedIndex+1;
				goods.Price = System.Convert.ToDecimal(price.Value);
				goods.idUnitMoney = valit.SelectedIndex+1;

				db.Goods.Add(goods);
				db.SaveChanges();
				Global.open(new Point(0, 24), new GoodsControls(), Global.get_start_control());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка");
			}
		}
	}
}
