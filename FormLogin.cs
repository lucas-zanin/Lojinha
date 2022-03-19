﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisTDS06
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Thread.Sleep(4000);
            splash.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = ClassConecta.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario WHERE login=@login AND senha=@senha";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtLogin.Text.Trim();
                cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = txtSenha.Text.Trim();
                SqlDataReader usuario = cmd.ExecuteReader();
                if (usuario.HasRows)
                {
                    this.Hide();
                    FormPrincipal pri = new FormPrincipal();
                    pri.Show();
                    ClassConecta.FecharConexao();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválido! Por favor, tente novamente!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtLogin.Focus();
                    ClassConecta.FecharConexao();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
