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
	public partial class Menu : Form
	{
		CadastrarSelecao cadastrarSelecao;
		AtualizarSelecao atualizarSelecao;
		ExcluirSelecao excluirSelecao;
		ConsultarSelecoes consultarSelecoes;
		public Menu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cadastrarSelecao = new CadastrarSelecao();
			cadastrarSelecao.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			atualizarSelecao = new AtualizarSelecao();
			atualizarSelecao.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			excluirSelecao = new ExcluirSelecao();
			excluirSelecao.ShowDialog();
		}// botao de ir pra tela de exluir selecao

		private void button4_Click(object sender, EventArgs e)
		{
			consultarSelecoes = new ConsultarSelecoes();
			consultarSelecoes.ShowDialog();
		}// botao de ir pra tela de consultar selecao
	}
}
