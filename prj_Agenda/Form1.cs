using System;
using MySql.Data.MySqlClient;//Biblioteca de m�todos MySQL

namespace prj_Agenda
{

    public partial class frm_Agenda : Form
    {
        //Vari�vel que ir� receber o caminho da Conex�o
        MySqlConnection conexao;
        public frm_Agenda()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar conex�o com o MySQL
                //Declarar vari�vel que conter� o caminho para chegar no MySQL "Workbench"
                string origem_dados = "datasource=localhost; username = root; password=123456; database=db_agenda";

                //Instanciar o Objeto que far� EFETIVAMENTE a CONEX�O
                conexao = new MySqlConnection(origem_dados);

                //Declara��o da Vari�vel que conter� o c�digo SQL para INSERIR OS DADOS NO BANCO
                string inserir_dados = "INSERT INTO contato (nome, telefone, email) VALUES ('" + txtB_Nome.Text + "', '" + txtB_Tel.Text + "', '" + txtB_Email.Text + "')";
            
                //Conex�o do MySQL e o c�digo SQL que insere os dados no banco
                MySqlCommand comandoSQL = new MySqlCommand(inserir_dados, conexao);

                //Abrindo a conex�o 
                conexao.Open();

                //Executando o Comando para inserir os Dados NO bd
                comandoSQL.ExecuteReader();

                //Mensagem de Dado Inseridos com SUCESSO
                MessageBox.Show("Dados inseridos com sucesso");



            }
            catch (Exception ex)
            {
                //Mostra Mensagem para o Usu�rio caso ERRO       
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}