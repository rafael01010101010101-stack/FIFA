using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA
{
	public partial class AtualizarSelecao : Form
	{
		Menu menu;
		DAOSelecoes daoSelecoes;
		public AtualizarSelecao()
		{
			InitializeComponent();
			daoSelecoes = new DAOSelecoes();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto pro codigo

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto pro nome

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto da localidade

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto do total de copas

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto do grupo 

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Informe o código da sala!");
				return;
			}

			int codigo = Convert.ToInt32(textBox1.Text);
			string msg = "nada";

			if (textBox5.Text != "")
				msg = this.daoSelecoes.AtualizarSelecao(codigo, "nome", textBox5.Text);

			if (textBox2.Text != "")
				msg = this.daoSelecoes.AtualizarSelecao(codigo, "localidade", textBox2.Text);

			if (textBox3.Text != "")
				msg = this.daoSelecoes.AtualizarSelecao(codigo, "totalCopas", textBox3.Text);

			if (textBox4.Text != "")
				msg = this.daoSelecoes.AtualizarSelecao(codigo, "grupo", textBox4.Text);

			if (msg == "nada")
				MessageBox.Show("Nada foi atualizado, confira as informações inseridas novamente");
			else if (msg == "foi")
				MessageBox.Show("Atualizado com sucesso!");
			else
				MessageBox.Show(msg);

			LimparCampos();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			menu = new Menu();
			menu.ShowDialog();
		}// botao de voltar pro menu

		public void LimparCampos()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
		}
	}
}
