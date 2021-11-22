using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace _3B2GABRIELLEONARDO17
{
	class Main
	{

        public int turma_id, professor_id, salario_id, unidade_id;
        public double valor_salario;
        public string email_usuario, senha_usuario, nome_professor, serie_turma,
            bairro_unidade,cidade_unidade, nome_unidade;
        
        public string tbl_professor = "professor";
        public string tbl_salario = "salario";
        public string tbl_turma = "turma";
        public string tbl_unidade = "unidade";
        public string tbl_usuarios = "usuario";



        Conexao objConexao = new Conexao();

        public DataTable Login()
        {
            string login = $@"select email, senha from {tbl_usuarios} where email = '{email_usuario}' and senha = '{senha_usuario}';";
            return objConexao.ExecutarConsulta(login);
        }

        public void CadastrarUsuario()
        {
            string cadastrar = $@"insert into {tbl_usuarios} values (NULL, '{email_usuario}', '{senha_usuario}');";
            objConexao.ExecutarComando(cadastrar);
        }

        public void CadastrarUnidade()
        {
            string cadastrar = $@"insert into {tbl_unidade} values (NULL, '{bairro_unidade}', '{cidade_unidade}', '{nome_unidade}');";
            objConexao.ExecutarComando(cadastrar);
        }

        public void CadastrarTurma()
        {
            string cadastrar = $@"insert into {tbl_turma} values (NULL, '{serie_turma}', '{unidade_id}');";
            objConexao.ExecutarComando(cadastrar);
        }

        public void CadastrarProfessor()
        {
            string cadastrar = $@"insert into {tbl_professor} values (NULL, '{nome_professor}', '{turma_id}');";
            objConexao.ExecutarComando(cadastrar);
        }

        public void CadastrarSalario()
        {
            string cadastrar = $@"insert into {tbl_salario} values (NULL, '{valor_salario}', '{professor_id}');";
            objConexao.ExecutarComando(cadastrar);
        }


        public void TelaLogin()
		{
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        public void TelaSemChave()
        {
            FrmSemChave frmSemChave = new FrmSemChave();
            frmSemChave.ShowDialog();
        }

        public void TelaComChave()
        {
            FrmComChave FrmComChave = new FrmComChave();
            FrmComChave.ShowDialog();
        }

        public void FecharApp()
        {
            System.Windows.Forms.Application.Exit();
        }



    }
}
