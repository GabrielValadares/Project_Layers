using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3B2GABRIELLEONARDO17
{
	public partial class FrmLogin : Form
	{

		Main objMain = new Main();

		public FrmLogin()
		{
			InitializeComponent();
		}

		private void Limpar()
		{
			txt_email.Clear();
			txt_senha.Clear();
		}

		private void MudarDeTela()
		{
			FrmSemChave frmSemChave = new FrmSemChave();
			frmSemChave.ShowDialog();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			if (txt_email.Text == "" || txt_senha.Text == "")
			{
				MessageBox.Show("Por favor preencha os campos de login e senha!");

				Limpar();
			}
			else
			{
				objMain.email_usuario = txt_email.Text;
				objMain.senha_usuario = txt_senha.Text;

				string email = "";
				string senha = "";

				foreach (DataRow row in objMain.Login().Rows)
				{
					email = row["email"].ToString();
					senha = row["senha"].ToString();
				}

				if (email == txt_email.Text && senha == txt_senha.Text)
				{
					MessageBox.Show("sucesso");

					Limpar();

					MudarDeTela();
				}
				else
				{
					MessageBox.Show("usuario nao existe");

					Limpar();
				}


			}
		}

		private void btn_Cadastrar_Click(object sender, EventArgs e)
		{
			if (txt_email.Text == "" || txt_senha.Text == "")
			{
				MessageBox.Show("Por favor preencha todos os campos!");
			}
			else
			{
				objMain.email_usuario = txt_email.Text;
				objMain.senha_usuario = txt_senha.Text;

				objMain.CadastrarUsuario();
				MessageBox.Show("sucesso");

				Limpar();

				MudarDeTela();
			}
		}

		private void btn_telaLogin_Click(object sender, EventArgs e)
		{
			objMain.TelaLogin();
		}

		private void btn_semChave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Porfavor efetue o login");
		}

		private void btn_comChave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Porfavor efetue o login");
		}

		private void btn_sair_Click(object sender, EventArgs e)
		{
			objMain.FecharApp();
		}
	}
}
