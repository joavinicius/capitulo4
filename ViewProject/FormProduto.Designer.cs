namespace ViewProject
{
    partial class FormProduto
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
            dataGridView1 = new DataGridView();
            BtnNovo = new Button();
            BtnGravar = new Button();
            BtnCancelar = new Button();
            BtnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "CNPJ:";
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(118, 6);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(128, 23);
            TxtId.TabIndex = 3;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(118, 57);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(317, 23);
            TxtNome.TabIndex = 4;
            // 
            // TxtCNPJ
            // 
            TxtCNPJ.Location = new Point(118, 108);
            TxtCNPJ.Name = "TxtCNPJ";
            TxtCNPJ.Size = new Size(142, 23);
            TxtCNPJ.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(479, 135);
            dataGridView1.TabIndex = 6;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(12, 149);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(75, 23);
            BtnNovo.TabIndex = 7;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnGravar
            // 
            BtnGravar.Location = new Point(148, 149);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(75, 23);
            BtnGravar.TabIndex = 8;
            BtnGravar.Text = "Gravar";
            BtnGravar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(287, 149);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(416, 149);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(75, 23);
            BtnRemover.TabIndex = 10;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 315);
            Controls.Add(BtnRemover);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGravar);
            Controls.Add(BtnNovo);
            Controls.Add(dataGridView1);
            Controls.Add(TxtCNPJ);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduto";
            Text = "FormProduto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button BtnNovo;
        private Button BtnGravar;
        private Button BtnCancelar;
        private Button BtnRemover;
    }
}