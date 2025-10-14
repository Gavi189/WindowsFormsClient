using ClassLibraryUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdmin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private ClassUser _user = new ClassUser(0, "", "", "");

        private void llblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister _formRegister = new FormRegister();
            _formRegister.Show();
            this.Hide();
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
            DataTable dt = _user.Entrar(email, password);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Sucesso");
                    FormHome _formHome = new FormHome();
                    _formHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sem Sucesso");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
