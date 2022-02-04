using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pekarnia
{
	public partial class pekarnia_form : Form
	{
		public pekarnia_form()
		{
			InitializeComponent();
		}
		private void provider_buttom_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0,24),new Pekarnia.Controls.ProviderControls(), Global.get_start_control());
		}

		private void goods_buttom_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new Pekarnia.Controls.GoodsControls(), Global.get_start_control());
		}

		private void pekarnia_form_SizeChanged(object sender, EventArgs e)
		{
			Global.size_new(Size);
		}

		private void ingridients_buttom_Click(object sender, EventArgs e)
		{
			Global.open(new Point(0, 24), new Pekarnia.Controls.IngridientsControls(), Global.get_start_control());
		}
	}
}
