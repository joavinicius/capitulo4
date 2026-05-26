using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControllerProject;
using ModelProject;

namespace ViewProject
{
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller;
        public FormFornecedor(FornecedorController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                Id = (TxtId.Text != string.Empty ? Guid.NewGuid() : new Guid(TxtId.Text)),
                Nome = TxtNome.Text,
                CNPJ = TxtCNPJ.Text
            };
            fornecedor = (TxtId.Text == string.Empty ? this.controller.Insert(fornecedor) : this.controller.Update(fornecedor));
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }
        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            TxtId.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtCNPJ.Text = string.Empty;
            TxtNome.Focus();
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtId.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtCNPJ.Text = string.Empty;
            ClearControls();
        }
        private void DgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            TxtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            TxtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione um fornecedor para remover.");
            }
            else
            {
                this.controller.Remove(new Fornecedor()
                {
                    Id = (new Guid(TxtId.Text)),
                    Nome = TxtNome.Text,
                    CNPJ = TxtCNPJ.Text
                });
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = this.controller.GetAll();
                ClearControls();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
