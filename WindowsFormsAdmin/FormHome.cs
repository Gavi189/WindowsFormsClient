using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;

namespace WindowsFormsAdmin
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }



        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            //Inicialização e Preparação
            string name = tbxSearch.Text;
            string description = tbxDescription.Text;

            //Instaciação da Classe
            ProductClass _product = new ProductClass(0, name, description, 0, true); 

            //Pesquisar na Tabela
            DataTable _dt = _product.ProductSearch(name, description);

            //Atualizar DataGridView
            dgvProduct.DataSource = _dt;
            
        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {
            //Inicialização e Preparação
            string name = tbxSearch.Text;
            string description = tbxDescription.Text;

            //Instaciação da Classe
            ProductClass _product = new ProductClass(0, name, description, 0, true);

            //Pesquisar na Tabela
            DataTable _dt = _product.ProductSearch(name, description);

            //Atualizar DataGridView
            dgvProduct.DataSource = _dt;
        }
    }
}
