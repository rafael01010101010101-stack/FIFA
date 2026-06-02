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
	public partial class ConsultarSelecoes : Form
	{
		DAOSelecoes daoSelecoes;
		Menu menu;
		public ConsultarSelecoes()
		{
			InitializeComponent();
			daoSelecoes = new DAOSelecoes();
		}

		public void ChamarMetodo(DataGridView datagrid)
		{
			ConfigurarDataGrid(datagrid);
			NomeColunas(datagrid);
			AdicionarDados(datagrid);
		}

		public void ConfigurarDataGrid(DataGridView dataGrid)
		{
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnCount = 5;
			dataGrid.AllowUserToAddRows = false;
			dataGrid.AllowUserToDeleteRows = false;
			dataGrid.AllowUserToResizeColumns = false;
			dataGrid.AllowUserToResizeRows = false;
			dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGrid.ColumnCount = 5;
		}

		public void NomeColunas(DataGridView dataGrid)
		{
			dataGrid.Columns[0].Name = "Codigo";
			dataGrid.Columns[1].Name = "Nome";
			dataGrid.Columns[2].Name = "Localidade";
			dataGrid.Columns[3].Name = "Total de Copas";
			dataGrid.Columns[4].Name = "Grupo";
		}

		public void AdicionarDados(DataGridView dataGrid)
		{
			this.daoSelecoes.PreencherVetor();
			for (int i = 0; i < this.daoSelecoes.codigo.Length; i++)
			{
				if (this.daoSelecoes.codigo[i] != 0)
				{
					string[] linha = new string[] { this.daoSelecoes.codigo[i].ToString(), this.daoSelecoes.nome[i], this.daoSelecoes.localidade[i], this.daoSelecoes.totalCopas[i].ToString(), this.daoSelecoes.grupo[i] };
					dataGrid.Rows.Add(linha);
				}
			}
		}



		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.Rows.Clear(); // limpa o grid
			this.daoSelecoes.PreencherVetor();

			for (int i = 0; i < this.daoSelecoes.contar; i++)
			{
				dataGridView1.Rows.Add(
					this.daoSelecoes.codigo[i],
					this.daoSelecoes.nome[i],
					this.daoSelecoes.localidade[i],
					this.daoSelecoes.totalCopas[i],
					this.daoSelecoes.grupo[i]
				);
			}
		}// tabela para mostrar as selecoes cadastradas

		private void ConsultarSelecoes_Load(object sender, EventArgs e)
		{
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnCount = 5;

			dataGridView1.Columns[0].Name = "Código";
			dataGridView1.Columns[1].Name = "Nome";
			dataGridView1.Columns[2].Name = "Localidade";
			dataGridView1.Columns[3].Name = "Total de Copas";
			dataGridView1.Columns[4].Name = "Grupo";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			menu = new Menu();
			menu.ShowDialog();
		}
	}
}
