using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3B2GABRIELLEONARDO17
{
	public partial class FrmSemChave : Form
	{
		public FrmSemChave()
		{
			InitializeComponent();
		}

		Main objMain = new Main();

		private void Limpar()
		{
			txt_bairro.Clear();
			txt_cidade.Clear();
			txt_nome.Clear();
		}


		private void btn_Cadastrar_Click(object sender, EventArgs e)
		{
			if (txt_bairro.Text == "" || txt_cidade.Text == "" || txt_nome.Text == "")
			{
				MessageBox.Show("Por favor preencha todos os campos!");
			}
			else
			{
				objMain.bairro_unidade = txt_bairro.Text;
				objMain.cidade_unidade = txt_cidade.Text;
				objMain.nome_unidade = txt_nome.Text;

				objMain.CadastrarUnidade();
				MessageBox.Show("sucesso");

				Limpar();
			}
		}

		private void btn_telaLogin_Click(object sender, EventArgs e)
		{
			objMain.TelaLogin();
		}

		private void btn_semChave_Click(object sender, EventArgs e)
		{
			objMain.TelaSemChave();
		}

		private void btn_comChave_Click(object sender, EventArgs e)
		{
			objMain.TelaComChave();
		}

		private void btn_sair_Click(object sender, EventArgs e)
		{
			objMain.FecharApp();
		}
	}
}
