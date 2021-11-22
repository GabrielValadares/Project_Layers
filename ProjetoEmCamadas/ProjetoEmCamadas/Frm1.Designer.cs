
namespace _3B2GABRIELLEONARDO17
{
	partial class FrmLogin
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
			this.label4 = new System.Windows.Forms.Label();
			this.btn_Cadastrar = new System.Windows.Forms.Button();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.grpBox_Menu = new System.Windows.Forms.GroupBox();
			this.btn_telaLogin = new System.Windows.Forms.Button();
			this.btn_sair = new System.Windows.Forms.Button();
			this.btn_comChave = new System.Windows.Forms.Button();
			this.btn_semChave = new System.Windows.Forms.Button();
			this.grpBox_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(188, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 30;
			this.label4.Text = "Senha";
			// 
			// btn_Cadastrar
			// 
			this.btn_Cadastrar.Location = new System.Drawing.Point(12, 183);
			this.btn_Cadastrar.Name = "btn_Cadastrar";
			this.btn_Cadastrar.Size = new System.Drawing.Size(835, 25);
			this.btn_Cadastrar.TabIndex = 29;
			this.btn_Cadastrar.Text = "Cadastrar";
			this.btn_Cadastrar.UseVisualStyleBackColor = true;
			this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(12, 123);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(170, 23);
			this.txt_email.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 15);
			this.label3.TabIndex = 25;
			this.label3.Text = "Email";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(188, 123);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.Size = new System.Drawing.Size(170, 23);
			this.txt_senha.TabIndex = 22;
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(12, 152);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(835, 25);
			this.btn_login.TabIndex = 21;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
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
			this.grpBox_Menu.TabIndex = 31;
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
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 234);
			this.Controls.Add(this.grpBox_Menu);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Cadastrar);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_senha);
			this.Controls.Add(this.btn_login);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela de Login";
			this.grpBox_Menu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_Cadastrar;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.GroupBox grpBox_Menu;
		private System.Windows.Forms.Button btn_telaLogin;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button btn_comChave;
		private System.Windows.Forms.Button btn_semChave;
	}
}

