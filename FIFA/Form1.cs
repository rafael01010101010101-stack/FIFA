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
	public partial class Form1 : Form
	{
		Menu menu;
		public Form1()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			menu = new Menu();
			menu.ShowDialog();
		}// botao pra entrar no bagui
	}
}
