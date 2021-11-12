
namespace projeto_agpi.Views
{
    partial class frm_NewTriagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Temperatura = new System.Windows.Forms.TextBox();
            this.lbl_Temperatura = new System.Windows.Forms.Label();
            this.txt_Pressao = new System.Windows.Forms.TextBox();
            this.txt_NomePaciente = new System.Windows.Forms.TextBox();
            this.lbl_Pressão = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txt_PesquisaCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Observacoes = new System.Windows.Forms.TextBox();
            this.lbl_Observacoes = new System.Windows.Forms.Label();
            this.txt_Saturacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Temperatura
            // 
            this.txt_Temperatura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Temperatura.Location = new System.Drawing.Point(190, 151);
            this.txt_Temperatura.Name = "txt_Temperatura";
            this.txt_Temperatura.Size = new System.Drawing.Size(255, 26);
            this.txt_Temperatura.TabIndex = 78;
            // 
            // lbl_Temperatura
            // 
            this.lbl_Temperatura.AutoSize = true;
            this.lbl_Temperatura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temperatura.Location = new System.Drawing.Point(86, 154);
            this.lbl_Temperatura.Name = "lbl_Temperatura";
            this.lbl_Temperatura.Size = new System.Drawing.Size(99, 18);
            this.lbl_Temperatura.TabIndex = 77;
            this.lbl_Temperatura.Text = "Temperatura:";
            // 
            // txt_Pressao
            // 
            this.txt_Pressao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pressao.Location = new System.Drawing.Point(190, 113);
            this.txt_Pressao.Name = "txt_Pressao";
            this.txt_Pressao.Size = new System.Drawing.Size(255, 26);
            this.txt_Pressao.TabIndex = 76;
            // 
            // txt_NomePaciente
            // 
            this.txt_NomePaciente.Enabled = false;
            this.txt_NomePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomePaciente.Location = new System.Drawing.Point(190, 76);
            this.txt_NomePaciente.Name = "txt_NomePaciente";
            this.txt_NomePaciente.Size = new System.Drawing.Size(255, 26);
            this.txt_NomePaciente.TabIndex = 75;
            // 
            // lbl_Pressão
            // 
            this.lbl_Pressão.AutoSize = true;
            this.lbl_Pressão.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pressão.Location = new System.Drawing.Point(114, 116);
            this.lbl_Pressão.Name = "lbl_Pressão";
            this.lbl_Pressão.Size = new System.Drawing.Size(71, 18);
            this.lbl_Pressão.TabIndex = 74;
            this.lbl_Pressão.Text = "Pressão:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(43, 76);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(142, 18);
            this.lbl_Nome.TabIndex = 73;
            this.lbl_Nome.Text = "Nome do Paciente:";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.Location = new System.Drawing.Point(355, 359);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(90, 34);
            this.btn_Salvar.TabIndex = 85;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(355, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 34);
            this.btnPesquisar.TabIndex = 88;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txt_PesquisaCPF
            // 
            this.txt_PesquisaCPF.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaCPF.Location = new System.Drawing.Point(190, 41);
            this.txt_PesquisaCPF.Name = "txt_PesquisaCPF";
            this.txt_PesquisaCPF.Size = new System.Drawing.Size(144, 23);
            this.txt_PesquisaCPF.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "CPF Paciente:";
            // 
            // txt_Observacoes
            // 
            this.txt_Observacoes.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Observacoes.Location = new System.Drawing.Point(190, 228);
            this.txt_Observacoes.Multiline = true;
            this.txt_Observacoes.Name = "txt_Observacoes";
            this.txt_Observacoes.Size = new System.Drawing.Size(255, 98);
            this.txt_Observacoes.TabIndex = 90;
            // 
            // lbl_Observacoes
            // 
            this.lbl_Observacoes.AutoSize = true;
            this.lbl_Observacoes.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Observacoes.Location = new System.Drawing.Point(86, 228);
            this.lbl_Observacoes.Name = "lbl_Observacoes";
            this.lbl_Observacoes.Size = new System.Drawing.Size(99, 19);
            this.lbl_Observacoes.TabIndex = 89;
            this.lbl_Observacoes.Text = "Observações:";
            // 
            // txt_Saturacao
            // 
            this.txt_Saturacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Saturacao.Location = new System.Drawing.Point(190, 189);
            this.txt_Saturacao.Name = "txt_Saturacao";
            this.txt_Saturacao.Size = new System.Drawing.Size(255, 26);
            this.txt_Saturacao.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 91;
            this.label1.Text = "Saturação:";
            // 
            // frm_NewTriagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 423);
            this.Controls.Add(this.txt_Saturacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Observacoes);
            this.Controls.Add(this.lbl_Observacoes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txt_PesquisaCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Temperatura);
            this.Controls.Add(this.lbl_Temperatura);
            this.Controls.Add(this.txt_Pressao);
            this.Controls.Add(this.txt_NomePaciente);
            this.Controls.Add(this.lbl_Pressão);
            this.Controls.Add(this.lbl_Nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NewTriagem";
            this.Text = "Triagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Temperatura;
        private System.Windows.Forms.Label lbl_Temperatura;
        private System.Windows.Forms.TextBox txt_Pressao;
        private System.Windows.Forms.TextBox txt_NomePaciente;
        private System.Windows.Forms.Label lbl_Pressão;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txt_PesquisaCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Observacoes;
        private System.Windows.Forms.Label lbl_Observacoes;
        private System.Windows.Forms.TextBox txt_Saturacao;
        private System.Windows.Forms.Label label1;
    }
}