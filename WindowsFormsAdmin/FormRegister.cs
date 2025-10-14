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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsAdmin
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Inicialização
            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string senha = tbxSenha.Text;

            ClassUser _user = new ClassUser(0, nome, email, senha);

            if (_user.Registrar())
            {
                MessageBox.Show("Sucesso");
            }
        }
    }
}
