using System;
using MySql.Data.MySqlClient;//Biblioteca de métodos MySQL

namespace prj_Agenda
{

    public partial class frm_Agenda : Form
    {
        //Variável que irá receber o caminho da Conexão
        MySqlConnection conexao;
        public frm_Agenda()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar conexão com o MySQL
                //Declarar variável que conterá o caminho para chegar no MySQL "Workbench"
                string origem_dados = "datasource=localhost; username = root; password=123456; database=db_agenda";

                //Instanciar o Objeto que fará EFETIVAMENTE a CONEXÃO
                conexao = new MySqlConnection(origem_dados);

                //Declaração da Variável que conterá o código SQL para INSERIR OS DADOS NO BANCO
                string inserir_dados = "INSERT INTO contato (nome, telefone, email) VALUES ('" + txtB_Nome.Text + "', '" + txtB_Tel.Text + "', '" + txtB_Email.Text + "')";
            
                //Conexão do MySQL e o código SQL que insere os dados no banco
                MySqlCommand comandoSQL = new MySqlCommand(inserir_dados, conexao);

                //Abrindo a conexão 
                conexao.Open();

                //Executando o Comando para inserir os Dados NO bd
                comandoSQL.ExecuteReader();

                //Mensagem de Dado Inseridos com SUCESSO
                MessageBox.Show("Dados inseridos com sucesso");



            }
            catch (Exception ex)
            {
                //Mostra Mensagem para o Usuário caso ERRO       
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}