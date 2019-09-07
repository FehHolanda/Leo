namespace Leo.UI
{
	partial class Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btLogin = new System.Windows.Forms.Button();
			this.btCadastrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "User:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(137, 52);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(218, 22);
			this.txtUser.TabIndex = 2;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(138, 80);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(217, 22);
			this.txtSenha.TabIndex = 3;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// btLogin
			// 
			this.btLogin.Location = new System.Drawing.Point(138, 148);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(94, 30);
			this.btLogin.TabIndex = 4;
			this.btLogin.Text = "Login";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btCadastrar
			// 
			this.btCadastrar.Location = new System.Drawing.Point(250, 148);
			this.btCadastrar.Name = "btCadastrar";
			this.btCadastrar.Size = new System.Drawing.Size(87, 30);
			this.btCadastrar.TabIndex = 5;
			this.btCadastrar.Text = "Cadastrar";
			this.btCadastrar.UseVisualStyleBackColor = true;
			this.btCadastrar.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 213);
			this.Controls.Add(this.btCadastrar);
			this.Controls.Add(this.btLogin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.Button btCadastrar;
	}
}