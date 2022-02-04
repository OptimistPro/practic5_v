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
	public partial class UbdateProviderControls : UserControl
	{
		int id = -1;
		public UbdateProviderControls(int ids)
		{
			InitializeComponent();
			id = ids;
			Global.add_list(this);
			Application.OpenForms[0].Text = "Пекарня - Поставщики - Изменить";
			db_read();
		}

		void db_read()
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.Provider provaders = db.Provider.Where(b => b.idProvider==id).First();
				names.Text = provaders.Name;
				emails.Text = provaders.Email;
				phones.Text = provaders.Phone;
			}
			catch (Exception ex)
			{
				MessageBox.Show(Convert.ToString(ex));
			}
		}

		private void nazad_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new ProviderControls(), Global.get_start_control());
		}

		private void ubdates_provider_Click(object sender, EventArgs e)
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.Provider provaders = db.Provider.Where(b => b.idProvider == id).First();
				provaders.Name= names.Text;
				provaders.Email= emails.Text;
				provaders.Phone= phones.Text;
				db.SaveChanges();
				Global.open(new Point(0, 24), new ProviderControls(), Global.get_start_control());
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
				Pekarnia.DataModel.Provider provaders = db.Provider.Where(b => b.idProvider == id).First();
				db.Provider.Remove(provaders);
				db.SaveChanges();
				Global.open(new Point(0, 24), new ProviderControls(), Global.get_start_control());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка");
			}
		}
	}
}
