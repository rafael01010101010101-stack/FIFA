using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//importando a estrutura de tela
using MySql.Data.MySqlClient;//importando a estrutura de conexão com o banco de dados

namespace FIFA
{
	class DAOSelecoes
	{
		public MySqlConnection conexao;
		public string dados;
		public string comando;
		public int[] codigo;
		public string[] nome;
		public string[] localidade;
		public int[] totalCopas;
		public string[] grupo;
		public int i;
		public int contar;

		public DAOSelecoes()
		{
			conexao = new MySqlConnection("server=localhost;DataBase=fifa;Uid=root;Password=;Convert Zero DateTime=True");
			try
			{
				conexao.Open();//abrir a conexão
			}
			catch (Exception erro)
			{
				MessageBox.Show($"Algo deu errado!\n\n {erro}");
				conexao.Close();//fecha conexão com o banco de dados
			}//fim do try_catch
		}

		public void InserirSelecoes(string nome, string localidade, int totalCopas, string grupo)
		{
			try
			{
				this.dados = $"('', '{nome}', '{localidade}', {totalCopas}, '{grupo}')";
				this.comando = $"Insert into selecoes(codigo, nome, localidade, totalCopas, grupo) values{this.dados}";
				//Inserir comando
				MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
				string resultado = "" + sql.ExecuteNonQuery();
				MessageBox.Show($"Inserido com Sucesso! \n\n{resultado}");
			}
			catch (Exception erro)
			{
				MessageBox.Show($"Algo deu errado\n\n {erro}");
			}
		}//fim do inserir

		public void PreencherVetor()
		{
			string query = "select * from selecoes";//Buscando todos os dados da tabela autor
												 //Instanciar os vetores
			this.codigo = new int[100];
			this.nome = new string[100];
			this.localidade = new string[100];
			this.totalCopas = new int[100];
			this.grupo = new string[100];


			//Preencher os vetores com valores padrões
			for (i = 0; i < 100; i++)
			{
				this.codigo[i] = 0;
				this.nome[i] = "";
				this.localidade[i] = "";
				this.totalCopas[i] = 0;
				this.grupo[i] = "";


			}//fim do for

			//Executar o comando do SQL
			MySqlCommand coletar = new MySqlCommand(query, this.conexao);

			//Leitura do dado no banco
			MySqlDataReader leitura = coletar.ExecuteReader();//Percorre o banco e traz os dados

			//Zerar o contador
			i = 0;
			this.contar = 0;
			while (leitura.Read())
			{
				this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
				this.nome[i] = leitura["nome"] + "";
				this.localidade[i] = leitura["localidade"] + "";
				this.totalCopas[i] = Convert.ToInt32(leitura["totalCopas"]);
				this.grupo[i] = leitura["grupo"] + "";
				i++;
				this.contar++;
			}//fim do while
			leitura.Close();//Encerrando o processo de busca
		}//fim do método

		public string DeletarSelecao(int codigo)
		{
			try
			{
				string query = $"delete from selecoes where codigo = '{codigo}'";
				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				int resultado = sql.ExecuteNonQuery();

				if (resultado == 0)
					return "nada";
				else
					return "foi";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro}";
			}
		}

		public string AtualizarSelecao(int codigo, string campo, string novoDado)
		{
			try
			{
				string query = $"update selecoes set {campo} = '{novoDado}' where codigo = '{codigo}'";
				MySqlCommand sql = new MySqlCommand(query, this.conexao);
				int resultado = sql.ExecuteNonQuery();

				if (resultado == 0)
					return "nada";
				else
					return "sucesso";
			}
			catch (Exception erro)
			{
				return $"Algo deu errado\n\n{erro}";
			}
		}
	}
}
