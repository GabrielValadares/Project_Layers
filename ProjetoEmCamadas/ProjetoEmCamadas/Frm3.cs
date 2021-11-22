using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3B2GABRIELLEONARDO17
{
	public partial class FrmComChave : Form
	{

		Main objMain = new Main();

		public FrmComChave()
		{
			InitializeComponent();
		}

		private void LimparTurma()
		{
			txt_serieTurma.Clear();
			txt_unidadeId.Clear();
		}

		private void LimparProfessor()
		{
			txt_nomeProfessor.Clear();
			txt_turmaId.Clear();
		}

		private void LimparSalario()
		{
			txt_valorSalario.Clear();
			txt_professorId.Clear();
		}

		private void btn_CadastrarTurma_Click(object sender, EventArgs e)
		{

			if(txt_serieTurma.Text != "" && txt_unidadeId.Text != "")
			{
				objMain.serie_turma = txt_serieTurma.Text;
				objMain.unidade_id = int.Parse(txt_unidadeId.Text);

				objMain.CadastrarTurma();
				MessageBox.Show("sucesso");

				LimparTurma();
			}
			else
			{
				MessageBox.Show("Porfavor preencha todos os campos!");
			}

			
		}

		private void btn_cadastrarProfessor_Click(object sender, EventArgs e)
		{
			if (txt_nomeProfessor.Text != "" && txt_turmaId.Text != "")
			{
				objMain.nome_professor = txt_nomeProfessor.Text;
				objMain.turma_id = int.Parse(txt_turmaId.Text);

				objMain.CadastrarProfessor();
				MessageBox.Show("sucesso");

				LimparProfessor();
			}
			else
			{
				MessageBox.Show("Porfavor preencha todos os campos!");
			}
		}

		private void btn_cadastrarSalario_Click(object sender, EventArgs e)
		{
			if (txt_valorSalario.Text != "" && txt_professorId.Text != "")
			{
				objMain.valor_salario = double.Parse(txt_valorSalario.Text);
				objMain.professor_id = int.Parse(txt_professorId.Text);

				objMain.CadastrarSalario();
				MessageBox.Show("sucesso");

				LimparSalario();
			}
			else
			{
				MessageBox.Show("Porfavor preencha todos os campos!");
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
