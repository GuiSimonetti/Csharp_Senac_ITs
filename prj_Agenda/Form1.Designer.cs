namespace prj_Agenda
{
    partial class frm_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Agenda));
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txtB_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.txtB_Tel = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtB_Email = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(12, 20);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(61, 21);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txtB_Nome
            // 
            this.txtB_Nome.Location = new System.Drawing.Point(12, 44);
            this.txtB_Nome.Name = "txtB_Nome";
            this.txtB_Nome.Size = new System.Drawing.Size(286, 23);
            this.txtB_Nome.TabIndex = 1;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tel.Location = new System.Drawing.Point(12, 81);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(80, 21);
            this.lbl_Tel.TabIndex = 0;
            this.lbl_Tel.Text = "Telefone:";
            // 
            // txtB_Tel
            // 
            this.txtB_Tel.Location = new System.Drawing.Point(12, 105);
            this.txtB_Tel.Name = "txtB_Tel";
            this.txtB_Tel.Size = new System.Drawing.Size(286, 23);
            this.txtB_Tel.TabIndex = 2;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(12, 140);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(63, 21);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txtB_Email
            // 
            this.txtB_Email.Location = new System.Drawing.Point(12, 164);
            this.txtB_Email.Name = "txtB_Email";
            this.txtB_Email.Size = new System.Drawing.Size(286, 23);
            this.txtB_Email.TabIndex = 3;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salvar.Location = new System.Drawing.Point(223, 206);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // frm_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 243);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txtB_Email);
            this.Controls.Add(this.txtB_Tel);
            this.Controls.Add(this.txtB_Nome);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private TextBox txtB_Nome;
        private Label lbl_Tel;
        private TextBox txtB_Tel;
        private Label lbl_Email;
        private TextBox txtB_Email;
        private Button btn_Salvar;
    }
}