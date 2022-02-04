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
	public partial class AddIngridientControls : UserControl
	{
		public AddIngridientControls()
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

				List<Pekarnia.DataModel.Provider> unitsmp = db.Provider.ToList();
				foreach (Pekarnia.DataModel.Provider d in unitsmp)
				{
					provider.Items.Add(Convert.ToString(String.Format("{0}", d.Name)));

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(Convert.ToString(ex));
			}
		}

		private void nazad_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new IngridientsControls(), Global.get_start_control());
		}

		private void add_provider_Click(object sender, EventArgs e)
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.ingridients ing = new Pekarnia.DataModel.ingridients();
				ing.Name = names.Text;
				ing.Quantity = System.Convert.ToDouble(kol.Value);
				ing.Unit = izmen.SelectedIndex + 1;
				ing.Price = System.Convert.ToDecimal(price.Value);
				ing.idUnitMoney = valit.SelectedIndex + 1;
				ing.idProvider = provider.SelectedIndex + 1;

				db.ingridients.Add(ing);
				db.SaveChanges();
				Global.open(new Point(0, 24), new IngridientsControls(), Global.get_start_control());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка");
			}
		}
	}
}
