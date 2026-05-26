namespace ViewProject
{
    partial class FormFornecedor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            TxtCNPJ = new TextBox();
            BtnNovo = new Button();
            BtnGravar = new Button();
            BtnCancelar = new Button();
            BtnRemover = new Button();
            dgvFornecedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 70);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 103);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "CNPJ:";
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(106, 33);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(334, 23);
            TxtId.TabIndex = 1;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(106, 62);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(334, 23);
            TxtNome.TabIndex = 1;
            // 
            // TxtCNPJ
            // 
            TxtCNPJ.Location = new Point(106, 95);
            TxtCNPJ.Name = "TxtCNPJ";
            TxtCNPJ.Size = new Size(334, 23);
            TxtCNPJ.TabIndex = 1;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(28, 134);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(75, 23);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnGravar
            // 
            BtnGravar.Location = new Point(150, 134);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(75, 23);
            BtnGravar.TabIndex = 2;
            BtnGravar.Text = "Gravar";
            BtnGravar.UseVisualStyleBackColor = true;
            BtnGravar.Click += BtnGravar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(263, 134);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(377, 134);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(75, 23);
            BtnRemover.TabIndex = 2;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            BtnRemover.Click += BtnRemover_Click;
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AllowUserToAddRows = false;
            dgvFornecedores.AllowUserToDeleteRows = false;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(28, 163);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.ReadOnly = true;
            dgvFornecedores.Size = new Size(424, 175);
            dgvFornecedores.TabIndex = 3;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 350);
            Controls.Add(dgvFornecedores);
            Controls.Add(BtnRemover);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGravar);
            Controls.Add(BtnNovo);
            Controls.Add(TxtCNPJ);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFornecedor";
            Text = "FormFornecedor";
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtId;
        private TextBox TxtNome;
        private TextBox TxtCNPJ;
        private Button BtnNovo;
        private Button BtnGravar;
        private Button BtnCancelar;
        private Button BtnRemover;
        private DataGridView dgvFornecedores;
    }
}