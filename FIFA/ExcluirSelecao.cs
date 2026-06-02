using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA
{
	public partial class ExcluirSelecao : Form
	{
		Menu menu;
		public ExcluirSelecao()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			menu = new Menu();
			menu.ShowDialog();
		}// botao de volta
	}
}
