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
		DAOSelecoes daoSelecoes;
		public ExcluirSelecao()
		{
			InitializeComponent();
			daoSelecoes = new DAOSelecoes();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			menu = new Menu();
			menu.ShowDialog();
		}// botao de volta

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto pra digitar o codigo da selecao a ser excluida

		public void LimparCampos()
		{
			textBox1.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Preencha o Campo");
			}
			else
			{
				int codigo = Convert.ToInt32(textBox1.Text);

				string msg = this.daoSelecoes.DeletarSelecao(codigo);

				if (msg == "nada")
					MessageBox.Show("Nada foi deletado, confira as informações inseridas novamente");
				else if (msg == "foi")
					MessageBox.Show("Deletado com sucesso!");
				else
					MessageBox.Show(msg); // exibe o erro

				LimparCampos();
			}
		}
	}
}
