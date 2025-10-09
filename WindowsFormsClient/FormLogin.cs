﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;
using System.Data.SqlClient;

namespace WindowsFormsClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private ClassUser _user = new ClassUser(0, "", "", "");
        private ConnClass _conn = new ConnClass();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();//Fecha todos os Forms
            //this.Close(); Fecha apenas o Form atual
        }

        private void pbxSenha_MouseDown(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '\0';
        }

        private void pbxSenha_MouseUp(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Inicialização
            string email = "";
            string password = "";

            //Entrada de dados
            email = tbxEmail.Text;
            password = tbxSenha.Text;

            //Processamento
            string mensagem = _user.Entrar(email, password);
            MessageBox.Show(mensagem, "Login"); //Saída

            if (mensagem == "Login feito com sucesso.")
            { 
                FormHome _formHome = new FormHome();
                _formHome.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//Tentar executar
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    MessageBox.Show(cn.ToString(),"Banco de Dados");
                }
            }
            catch(Exception erro)//Pegar um erro 
            {
                MessageBox.Show(erro.ToString(),"Erro no BD");
            }
            //finally{} //Executar mesmo que try falha
        }
    }
}
