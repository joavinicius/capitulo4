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
        private FornecedorController controller = new FornecedorController();
        //Codigo omitido    
        public FormFornecedor()
        {
            InitializeComponent();
        }


    }
}
