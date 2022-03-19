﻿namespace SisTDS06
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.btnCep = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLimpaCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaCampos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpaCampos.Location = new System.Drawing.Point(672, 109);
            this.btnLimpaCampos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(88, 23);
            this.btnLimpaCampos.TabIndex = 68;
            this.btnLimpaCampos.Text = "Limpar";
            this.btnLimpaCampos.UseVisualStyleBackColor = false;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // btnCep
            // 
            this.btnCep.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCep.Location = new System.Drawing.Point(213, 109);
            this.btnCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(88, 23);
            this.btnCep.TabIndex = 67;
            this.btnCep.Text = "CEP";
            this.btnCep.UseVisualStyleBackColor = false;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(672, 138);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 23);
            this.btnSair.TabIndex = 66;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(672, 80);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 23);
            this.btnExcluir.TabIndex = 65;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(672, 51);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 23);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(672, 22);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 23);
            this.btnCadastrar.TabIndex = 63;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 235);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(522, 20);
            this.txtEmail.TabIndex = 62;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 219);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 61;
            this.lblEmail.Text = "E-mail";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 153);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(236, 20);
            this.txtCidade.TabIndex = 58;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 137);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 57;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(257, 153);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(278, 20);
            this.txtBairro.TabIndex = 56;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(257, 135);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 55;
            this.lblBairro.Text = "Bairrro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(312, 114);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(343, 20);
            this.txtEndereco.TabIndex = 54;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(312, 96);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 53;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(13, 112);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(192, 20);
            this.txtCep.TabIndex = 52;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(13, 94);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 51;
            this.lblCep.Text = "CEP";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(257, 180);
            this.lblDtNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(122, 13);
            this.lblDtNascimento.TabIndex = 48;
            this.lblDtNascimento.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 66);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(440, 20);
            this.txtNome.TabIndex = 41;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 48);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Nome";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(14, 261);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(746, 174);
            this.dgvCliente.TabIndex = 39;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(14, 24);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(139, 20);
            this.txtCpf.TabIndex = 38;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(14, 6);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 37;
            this.lblCpf.Text = "CPF";
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascimento.Location = new System.Drawing.Point(257, 196);
            this.dtpDtNascimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(233, 20);
            this.dtpDtNascimento.TabIndex = 36;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Location = new System.Drawing.Point(161, 22);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(88, 23);
            this.btnLocalizar.TabIndex = 35;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(14, 196);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(192, 20);
            this.txtCelular.TabIndex = 70;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(14, 178);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 69;
            this.lblCelular.Text = "Celular";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisTDS06.Properties.Resources.clientes1;
            this.pictureBox1.Location = new System.Drawing.Point(461, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 443);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.btnLimpaCampos);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.dtpDtNascimento);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}