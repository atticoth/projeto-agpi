using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agpi.Views
{
    public partial class frm_NewFuncionario : Form
    {
        public int Perfil;
        public bool Inativo;
        public int inativoCheck;
        int codFunc;
        public frm_NewFuncionario(int ID)
        {
            codFunc = ID;
            InitializeComponent();
        }

        public void LoadButtonUpdate()
        {
            btn_Salvar.Enabled = true;
            btn_Salvar.Visible = false;
        }

        public void LoadButtonSave()
        {
            btn_Atualizar.Enabled = true;
            btn_Atualizar.Visible = false;
        }

        public void InativoCheck()
        {
            if(Inativo == true)
            {
                cbx_Inativo.Checked = true;
            }
        }

        public void LoadFuncionario()
        {
            if (codFunc != 0)
            {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        using (SqlConnection sqlConnection = frm_Main.Connection())
                        {
                            sqlConnection.Open();
                            using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                            {
                                sqlComando.CommandText = "DEFAULT_SELECT_FUNCIONARIOS_UPDATE";
                                sqlComando.CommandType = CommandType.StoredProcedure;
                                sqlComando.Parameters.Add(new SqlParameter("@CodFunc", codFunc));
                                var reader = sqlComando.ExecuteReader();


                                dataTable.Load(reader);
                            }
                        }
                        txt_Nome.Text = dataTable.Rows[0].ItemArray[1].ToString();
                        txt_Senha.Text = dataTable.Rows[0].ItemArray[2].ToString();
                        txt_CPF.Text = dataTable.Rows[0].ItemArray[3].ToString();
                        txt_Cargo.Text = dataTable.Rows[0].ItemArray[4].ToString();
                        txt_Telefone.Text = dataTable.Rows[0].ItemArray[5].ToString();
                        txt_Email.Text = dataTable.Rows[0].ItemArray[6].ToString();
                        Perfil = int.Parse(dataTable.Rows[0].ItemArray[7].ToString());
                        Inativo = bool.Parse(dataTable.Rows[0].ItemArray[8].ToString());

                        if (Perfil == 1)
                        {
                            rdbtn_Master.Checked = true;
                            rdbtn_Administrativo.Checked = false;
                            rdbtn_Medico.Checked = false;
                        }
                        if (Perfil == 2)
                        {
                            rdbtn_Master.Checked = false;
                            rdbtn_Administrativo.Checked = true;
                            rdbtn_Medico.Checked = false;
                        }
                        if (Perfil == 3)
                        {
                            rdbtn_Master.Checked = false;
                            rdbtn_Administrativo.Checked = false;
                            rdbtn_Medico.Checked = true;
                        }

                        LoadButtonUpdate();
                        InativoCheck();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }
            else
            {
                LoadButtonSave();
            }
        }

        public void CadastrarFuncionario(string nome, string senha, string cpf, string cargo, string telefone, string email)
        {
            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_INSERT_NEW_FUNCIONARIO";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@Nome", nome));
                        sqlComando.Parameters.Add(new SqlParameter("@Password", senha));
                        sqlComando.Parameters.Add(new SqlParameter("@CPF", cpf));
                        sqlComando.Parameters.Add(new SqlParameter("@Cargo", cargo));
                        sqlComando.Parameters.Add(new SqlParameter("@Telefone", telefone));
                        sqlComando.Parameters.Add(new SqlParameter("@Email", email));
                        sqlComando.Parameters.Add(new SqlParameter("@CodPerfil", Perfil));
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                MessageBox.Show("Usuário cadastrado com sucesso", "Aviso!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void AtualizarFuncionario(string nome, string senha, string cpf, string cargo, string telefone, string email)
        {
            try
            {
                using (SqlConnection sqlConnection = frm_Main.Connection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlComando = sqlConnection.CreateCommand())
                    {
                        sqlComando.CommandText = "DEFAULT_UPDATE_FUNCIONARIOS";
                        sqlComando.CommandType = CommandType.StoredProcedure;
                        sqlComando.Parameters.Add(new SqlParameter("@CodFunc", codFunc));
                        sqlComando.Parameters.Add(new SqlParameter("@Nome", nome));
                        sqlComando.Parameters.Add(new SqlParameter("@Password", senha));
                        sqlComando.Parameters.Add(new SqlParameter("@CPF", cpf));
                        sqlComando.Parameters.Add(new SqlParameter("@Cargo", cargo));
                        sqlComando.Parameters.Add(new SqlParameter("@Telefone", telefone));
                        sqlComando.Parameters.Add(new SqlParameter("@Email", email));
                        sqlComando.Parameters.Add(new SqlParameter("@CodPerfil", Perfil));
                        sqlComando.Parameters.Add(new SqlParameter("@Inativo", inativoCheck));
                        sqlComando.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                MessageBox.Show("Usuário atualizado com sucesso", "Aviso!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frm_NewFuncionario_Load(object sender, EventArgs e)
        {
            LoadFuncionario();
        }

        private void btn_Salvar_Click_1(object sender, EventArgs e)
        {
            if (txt_Senha.Text == txt_ConfirmSenha.Text)
            {
                string nome = txt_Nome.Text;
                string senha = txt_Senha.Text;
                string cpf = txt_CPF.Text;
                string cargo = txt_Cargo.Text;
                string telefone = txt_Telefone.Text;
                string email = txt_Email.Text;

                if (rdbtn_Master.Checked)
                {
                    Perfil = 1;
                }

                if (rdbtn_Administrativo.Checked)
                {
                    Perfil = 2;
                }

                if (rdbtn_Medico.Checked)
                {
                    Perfil = 3;
                }


                CadastrarFuncionario(nome, senha, cpf, cargo, telefone, email);
            }
            else
            {
                MessageBox.Show("Senha inválida!", "Aviso!", MessageBoxButtons.OK);
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (txt_Senha.Text == txt_ConfirmSenha.Text)
            {
                string nome = txt_Nome.Text;
                string senha = txt_Senha.Text;
                string cpf = txt_CPF.Text;
                string cargo = txt_Cargo.Text;
                string telefone = txt_Telefone.Text;
                string email = txt_Email.Text;
                int inativo;

                if (rdbtn_Master.Checked)
                {
                    Perfil = 1;
                }

                if (rdbtn_Administrativo.Checked)
                {
                    Perfil = 2;
                }

                if (rdbtn_Medico.Checked)
                {
                    Perfil = 3;
                }

                if (cbx_Inativo.Checked)
                {
                    inativoCheck = 1;
                }
                else
                {
                    inativoCheck = 0;
                }

                AtualizarFuncionario(nome, senha, cpf, cargo, telefone, email);
            }
            else
            {
                MessageBox.Show("Senha inválida!", "Aviso!", MessageBoxButtons.OK);
            }
        }
    }
}
