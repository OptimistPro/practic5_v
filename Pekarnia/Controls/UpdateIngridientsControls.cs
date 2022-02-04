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
	public partial class UpdateIngridientsControls : UserControl
	{
		int id = -1;
		public UpdateIngridientsControls(int ids)
		{
			InitializeComponent();
			id = ids;
			Global.add_list(this);
			Application.OpenForms[0].Text = "Пекарня - Ингредиенты - Изменить";
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

				Pekarnia.DataModel.ingridients provaders = db.ingridients.Where(b => b.idIngridients == id).First();
				names.Text = provaders.Name;
				kol.Value = System.Convert.ToInt32(provaders.Quantity);
				izmen.SelectedIndex = provaders.Unit - 1;
				price.Value = System.Convert.ToInt32(provaders.Price);
				valit.SelectedIndex = provaders.idUnitMoney - 1;
				provider.SelectedIndex = provaders.idProvider - 1;
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

		private void update_provider_Click(object sender, EventArgs e)
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.ingridients ing = db.ingridients.Where(b => b.idIngridients == id).First();

				ing.Name = names.Text;
				ing.Quantity = System.Convert.ToDouble(kol.Value);
				ing.Unit = izmen.SelectedIndex + 1;
				ing.Price = System.Convert.ToDecimal(price.Value);
				ing.idUnitMoney = valit.SelectedIndex + 1;
				ing.idProvider = provider.SelectedIndex + 1;

				db.SaveChanges();
				Global.open(new Point(0, 24), new IngridientsControls(), Global.get_start_control());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка");
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.ingridients provaders = db.ingridients.Where(b => b.idIngridients == id).First();
				db.ingridients.Remove(provaders);
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
