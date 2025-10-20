using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibraryUser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            

            //Instaciação da Classe
            ProductClass _product = new ProductClass(0, name, "", 0, true); 

            //Pesquisar na Tabela
            DataTable _dt = _product.ProductSearch(name);

            //Atualizar DataGridView
            dgvProduct.DataSource = _dt;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Inicialização e Preparação
            int id_product = 0;
            string name = "";
            string description = "";
            double price = 0.0;
            bool status = true;

            //Entrada de Dados

            id_product = Convert.ToInt16(lblID.Text);
            name = tbxSearch.Text;
            description = tbxDescription.Text;
            price = Convert.ToDouble(tbxPrice.Text);
            status = rbtnStored.Checked;

            //Processamento
            ProductClass _product = new ProductClass(id_product,name,
                description,price,status);

            if (_product.Atualizar()) 
            {
                MessageBox.Show("Sucesso"); //Saída
            }
            else
            {
                MessageBox.Show("Erro"); //Saída
            }
        
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Inicialização
            int id_product = 0;

            //Entrada de Dados
            id_product = Convert.ToInt16(lblID.Text);

            //Processamento
            ProductClass _product = new ProductClass(id_product, "","", 0.0, true);

            if (_product.Remover())
            {
                MessageBox.Show("Sucesso"); //Saída
            }
            else
            {
                MessageBox.Show("Erro"); //Saída
            }
        }

        private void dgvProduct_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var hit = dgvProduct.HitTest(e.X, e.Y);

            // Verifica se realmente clicou em uma célula válida
            if (hit.RowIndex >= 0)
            {
                dgvProduct.Rows[hit.RowIndex].Selected = true;

                lblID.Text = dgvProduct.Rows[hit.RowIndex].Cells["id_Product"].Value.ToString();
                tbxSearch.Text = dgvProduct.Rows[hit.RowIndex].Cells["Name"].Value.ToString();
                tbxDescription.Text = dgvProduct.Rows[hit.RowIndex].Cells["Description"].Value.ToString();
                tbxPrice.Text = dgvProduct.Rows[hit.RowIndex].Cells["Price"].Value.ToString();
                bool ativo = Convert.ToBoolean(dgvProduct.Rows[hit.RowIndex].Cells["Status"].Value);
                if (ativo)
                {
                    rbtnStored.Checked = ativo;
                }
                else { rbtnStored.Checked = !ativo; }

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProductClass _product = new ProductClass(0, tbxSearch.Text,tbxDescription.Text, Convert.ToDouble(tbxPrice.Text), true);
            if (_product.Registrar())
            {
                MessageBox.Show("Sucesso"); //Saída
            }
            else
            {
                MessageBox.Show("Erro"); //Saída
            }
        }
    }
}
