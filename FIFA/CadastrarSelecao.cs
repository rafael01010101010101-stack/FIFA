using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIFA
{
	public partial class CadastrarSelecao : Form
	{
		DAOSelecoes daoSelecoes;
		Menu menu;
		public CadastrarSelecao()
		{
			InitializeComponent();
			daoSelecoes = new DAOSelecoes();
		}

		private void CadastrarSelecao_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			menu = new Menu();
			menu.ShowDialog();
		}// BOTAO DE VOLTA PRO MENU	

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto do nome

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto da localidade

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto de total de copas

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}// caixa de texto do grupo da seleção na copa

		private void button1_Click(object sender, EventArgs e)
		{
			if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
			{
				MessageBox.Show("Preencha os Campos");
			}
			else
			{
				string nome = textBox1.Text;
				string localidade = textBox2.Text;
				int totalCopas = Convert.ToInt32(textBox3.Text);
				string grupo = textBox4.Text;

				// INSERIR DENTRO DO BANCO
				this.daoSelecoes.InserirSelecoes(nome,localidade, totalCopas, grupo);
				// limpar os campos
				LimparCampos();
			}
		}// botao de cadastrar

		public void LimparCampos()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
		}
	}
}
