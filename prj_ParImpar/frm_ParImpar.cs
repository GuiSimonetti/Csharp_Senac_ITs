namespace prj_ParImpar
{
    public partial class frm_ParImpar : Form
    {
        public frm_ParImpar()
        {
            InitializeComponent();
        }

        private void btn_Identificar_Click(object sender, EventArgs e)
        {
            int NUM = Convert.ToInt32(txtB_Numero.Text);

            if (NUM % 2 == 0)
            {
                lbl_Resposta.Text = "PAR";          
            }
            else
            {
                lbl_Resposta.Text = "ÍMPAR";
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtB_Numero.Clear();
            lbl_Resposta.Text = "";

            //Método que coloca o cursor dentro do campo
            txtB_Numero.Focus(); 
           
        }
    }
}