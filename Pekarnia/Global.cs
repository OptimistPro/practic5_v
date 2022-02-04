using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace Pekarnia
{
	static class Global
	{
		private static List<UserControl> list = new List<UserControl>();
		private static UserControl StartControl = null;

		public static UserControl get_start_control()
		{
			return StartControl;
		}

		private static string text = "";
		public static void ads(string texts)
		{
			text = texts;
		}
		public static string gets()
		{
			return text;
		}
		public static void add_list(UserControl New)
		{
			list.Add(New);
		}
		public static bool open(Point Position,UserControl New = null, UserControl Real = null, UserControl Parent = null)
		{
			
			if (Real != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] == Real)
					{
						list.RemoveAt(i);
						Real.Parent.Controls.Remove(Real);
						if (Parent == null)
						{
							StartControl = null;
						}
							//Application.OpenForms[0].Controls.Remove(Real);
						break;
					}
				}
			}
			if (New != null)
			{
				if (Parent == null)
				{
					New.Location = Position;
					StartControl = New;
					Application.OpenForms[0].Controls.Add(New);
					Application.OpenForms[0].Controls.Find(New.Name, true);
					size_new(Application.OpenForms[0].Size);
				}
				else
				{
					New.Location = Position;
					Control list2 = Application.OpenForms[0].Controls.Find(Parent.Name, true)[0];
					list2.Controls.Add(New);
					//Application.OpenForms[0].Controls.Add(New);
					//Application.OpenForms[0].Controls.Find(New.Name, true);
				}
			}
			return true;
		}

		public static bool size_new(Size size)
		{
			for (int i = 0; i < list.Count; i++)
			{
				Size ty = size - new Size(20, 30);
				list[i].Size = ty;
			}
			return true;
		}

	}
}
