namespace prj_ParImpar
{
    partial class frm_ParImpar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ParImpar));
            this.lbl_Titulo1 = new System.Windows.Forms.Label();
            this.lbl_Titulo2 = new System.Windows.Forms.Label();
            this.lbl_Resposta = new System.Windows.Forms.Label();
            this.txtB_Numero = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Identificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo1
            // 
            this.lbl_Titulo1.AutoSize = true;
            this.lbl_Titulo1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Titulo1.Location = new System.Drawing.Point(10, 7);
            this.lbl_Titulo1.Name = "lbl_Titulo1";
            this.lbl_Titulo1.Size = new System.Drawing.Size(248, 25);
            this.lbl_Titulo1.TabIndex = 0;
            this.lbl_Titulo1.Text = "Digite um Número Inteiro:";
            // 
            // lbl_Titulo2
            // 
            this.lbl_Titulo2.AutoSize = true;
            this.lbl_Titulo2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Titulo2.Location = new System.Drawing.Point(10, 61);
            this.lbl_Titulo2.Name = "lbl_Titulo2";
            this.lbl_Titulo2.Size = new System.Drawing.Size(207, 25);
            this.lbl_Titulo2.TabIndex = 0;
            this.lbl_Titulo2.Text = "O Numero Digitado é:";
            // 
            // lbl_Resposta
            // 
            this.lbl_Resposta.AutoSize = true;
            this.lbl_Resposta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resposta.ForeColor = System.Drawing.Color.Red;
            this.lbl_Resposta.Location = new System.Drawing.Point(248, 52);
            this.lbl_Resposta.Name = "lbl_Resposta";
            this.lbl_Resposta.Size = new System.Drawing.Size(0, 37);
            this.lbl_Resposta.TabIndex = 0;
            // 
            // txtB_Numero
            // 
            this.txtB_Numero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB_Numero.Location = new System.Drawing.Point(295, 4);
            this.txtB_Numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB_Numero.Name = "txtB_Numero";
            this.txtB_Numero.Size = new System.Drawing.Size(110, 32);
            this.txtB_Numero.TabIndex = 1;
            this.txtB_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Limpar.ForeColor = System.Drawing.Color.Brown;
            this.btn_Limpar.Location = new System.Drawing.Point(75, 128);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(106, 35);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Identificar
            // 
            this.btn_Identificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Identificar.ForeColor = System.Drawing.Color.Brown;
            this.btn_Identificar.Location = new System.Drawing.Point(266, 128);
            this.btn_Identificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Identificar.Name = "btn_Identificar";
            this.btn_Identificar.Size = new System.Drawing.Size(126, 35);
            this.btn_Identificar.TabIndex = 2;
            this.btn_Identificar.Text = "IDENTIFICAR";
            this.btn_Identificar.UseVisualStyleBackColor = true;
            this.btn_Identificar.Click += new System.EventHandler(this.btn_Identificar_Click);
            // 
            // frm_ParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(475, 190);
            this.Controls.Add(this.btn_Identificar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txtB_Numero);
            this.Controls.Add(this.lbl_Resposta);
            this.Controls.Add(this.lbl_Titulo2);
            this.Controls.Add(this.lbl_Titulo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ParImpar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJETO - IDENTIFICA PAR OU ÍMPAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Titulo1;
        private Label lbl_Titulo2;
        private Label lbl_Resposta;
        private TextBox txtB_Numero;
        private Button btn_Limpar;
        private Button btn_Identificar;
    }
}