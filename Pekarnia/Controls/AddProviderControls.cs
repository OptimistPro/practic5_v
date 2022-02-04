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
	public partial class AddProviderControls : UserControl
	{
		//Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
		public AddProviderControls()
		{
			InitializeComponent();
			Global.add_list(this);
			Application.OpenForms[0].Text = "Пекарня - Поставщики - Новый поставщик";
		}

		private void nazad_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new ProviderControls(), Global.get_start_control());
		}

		private void add_provider_Click(object sender, EventArgs e)
		{
			try
			{
				Pekarnia.DataModel.PekarnyaEntities db = new Pekarnia.DataModel.PekarnyaEntities();
				Pekarnia.DataModel.Provider provaders = new Pekarnia.DataModel.Provider();
				provaders.Name = names.Text;
				provaders.Email = emails.Text;
				provaders.Phone = phones.Text;
				db.Provider.Add(provaders);
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
