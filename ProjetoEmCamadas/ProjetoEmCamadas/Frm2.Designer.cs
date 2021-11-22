
namespace _3B2GABRIELLEONARDO17
{
	partial class FrmSemChave
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
			this.btn_semChave = new System.Windows.Forms.Button();
			this.btn_comChave = new System.Windows.Forms.Button();
			this.grpBox_Menu = new System.Windows.Forms.GroupBox();
			this.btn_telaLogin = new System.Windows.Forms.Button();
			this.btn_sair = new System.Windows.Forms.Button();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_cidade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_bairro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Cadastrar = new System.Windows.Forms.Button();
			this.grpBox_unidade = new System.Windows.Forms.GroupBox();
			this.grpBox_Menu.SuspendLayout();
			this.grpBox_unidade.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_semChave
			// 
			this.btn_semChave.Location = new System.Drawing.Point(212, 22);
			this.btn_semChave.Name = "btn_semChave";
			this.btn_semChave.Size = new System.Drawing.Size(200, 25);
			this.btn_semChave.TabIndex = 16;
			this.btn_semChave.Text = "Cadastro sem chave estrangeira";
			this.btn_semChave.UseVisualStyleBackColor = true;
			this.btn_semChave.Click += new System.EventHandler(this.btn_semChave_Click);
			// 
			// btn_comChave
			// 
			this.btn_comChave.Location = new System.Drawing.Point(418, 22);
			this.btn_comChave.Name = "btn_comChave";
			this.btn_comChave.Size = new System.Drawing.Size(200, 25);
			this.btn_comChave.TabIndex = 19;
			this.btn_comChave.Text = "Cadastro com chave estrangeira";
			this.btn_comChave.UseVisualStyleBackColor = true;
			this.btn_comChave.Click += new System.EventHandler(this.btn_comChave_Click);
			// 
			// grpBox_Menu
			// 
			this.grpBox_Menu.Controls.Add(this.btn_telaLogin);
			this.grpBox_Menu.Controls.Add(this.btn_sair);
			this.grpBox_Menu.Controls.Add(this.btn_comChave);
			this.grpBox_Menu.Controls.Add(this.btn_semChave);
			this.grpBox_Menu.Location = new System.Drawing.Point(12, 12);
			this.grpBox_Menu.Name = "grpBox_Menu";
			this.grpBox_Menu.Size = new System.Drawing.Size(834, 60);
			this.grpBox_Menu.TabIndex = 20;
			this.grpBox_Menu.TabStop = false;
			this.grpBox_Menu.Text = "Menu";
			// 
			// btn_telaLogin
			// 
			this.btn_telaLogin.Location = new System.Drawing.Point(6, 22);
			this.btn_telaLogin.Name = "btn_telaLogin";
			this.btn_telaLogin.Size = new System.Drawing.Size(200, 25);
			this.btn_telaLogin.TabIndex = 21;
			this.btn_telaLogin.Text = "Tela de login";
			this.btn_telaLogin.UseVisualStyleBackColor = true;
			this.btn_telaLogin.Click += new System.EventHandler(this.btn_telaLogin_Click);
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(624, 22);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(200, 25);
			this.btn_sair.TabIndex = 20;
			this.btn_sair.Text = "Sair da aplicação";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(6, 49);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(200, 23);
			this.txt_nome.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 15);
			this.label3.TabIndex = 44;
			this.label3.Text = "nome";
			// 
			// txt_cidade
			// 
			this.txt_cidade.Location = new System.Drawing.Point(212, 49);
			this.txt_cidade.Name = "txt_cidade";
			this.txt_cidade.Size = new System.Drawing.Size(200, 23);
			this.txt_cidade.TabIndex = 43;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(212, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 15);
			this.label2.TabIndex = 42;
			this.label2.Text = "cidade";
			// 
			// txt_bairro
			// 
			this.txt_bairro.Location = new System.Drawing.Point(418, 49);
			this.txt_bairro.Name = "txt_bairro";
			this.txt_bairro.Size = new System.Drawing.Size(200, 23);
			this.txt_bairro.TabIndex = 41;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(418, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 40;
			this.label1.Text = "bairro";
			// 
			// btn_Cadastrar
			// 
			this.btn_Cadastrar.Location = new System.Drawing.Point(6, 78);
			this.btn_Cadastrar.Name = "btn_Cadastrar";
			this.btn_Cadastrar.Size = new System.Drawing.Size(819, 25);
			this.btn_Cadastrar.TabIndex = 46;
			this.btn_Cadastrar.Text = "Cadastrar";
			this.btn_Cadastrar.UseVisualStyleBackColor = true;
			this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
			// 
			// grpBox_unidade
			// 
			this.grpBox_unidade.Controls.Add(this.label3);
			this.grpBox_unidade.Controls.Add(this.btn_Cadastrar);
			this.grpBox_unidade.Controls.Add(this.label1);
			this.grpBox_unidade.Controls.Add(this.txt_nome);
			this.grpBox_unidade.Controls.Add(this.txt_bairro);
			this.grpBox_unidade.Controls.Add(this.label2);
			this.grpBox_unidade.Controls.Add(this.txt_cidade);
			this.grpBox_unidade.Location = new System.Drawing.Point(12, 95);
			this.grpBox_unidade.Name = "grpBox_unidade";
			this.grpBox_unidade.Size = new System.Drawing.Size(831, 125);
			this.grpBox_unidade.TabIndex = 47;
			this.grpBox_unidade.TabStop = false;
			this.grpBox_unidade.Text = "Unidade";
			// 
			// FrmSemChave
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 236);
			this.Controls.Add(this.grpBox_unidade);
			this.Controls.Add(this.grpBox_Menu);
			this.Name = "FrmSemChave";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Escolha";
			this.grpBox_Menu.ResumeLayout(false);
			this.grpBox_unidade.ResumeLayout(false);
			this.grpBox_unidade.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_semChave;
		private System.Windows.Forms.Button btn_comChave;
		private System.Windows.Forms.GroupBox grpBox_Menu;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button btn_telaLogin;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_cidade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_bairro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Cadastrar;
		private System.Windows.Forms.GroupBox grpBox_unidade;
	}
}