namespace SistemaBibliotecaBonito
{
    partial class Listaemprestimo
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
            this.Dgvemprestimo = new System.Windows.Forms.DataGridView();
            this.Nomedousuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomedolivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempodeemprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvemprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvemprestimo
            // 
            this.Dgvemprestimo.AllowUserToAddRows = false;
            this.Dgvemprestimo.AllowUserToDeleteRows = false;
            this.Dgvemprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvemprestimo.BackgroundColor = System.Drawing.Color.White;
            this.Dgvemprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgvemprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvemprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomedousuarios,
            this.CPF,
            this.Nomedolivro,
            this.ISBN,
            this.Tempodeemprestimo,
            this.datainicio,
            this.datafim});
            this.Dgvemprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgvemprestimo.Location = new System.Drawing.Point(0, 0);
            this.Dgvemprestimo.Name = "Dgvemprestimo";
            this.Dgvemprestimo.ReadOnly = true;
            this.Dgvemprestimo.RowHeadersVisible = false;
            this.Dgvemprestimo.RowHeadersWidth = 51;
            this.Dgvemprestimo.RowTemplate.Height = 24;
            this.Dgvemprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvemprestimo.Size = new System.Drawing.Size(1262, 653);
            this.Dgvemprestimo.TabIndex = 0;
            this.Dgvemprestimo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvemprestimo_CellContentClick);
            // 
            // Nomedousuarios
            // 
            this.Nomedousuarios.HeaderText = "Nome do Usuário";
            this.Nomedousuarios.MinimumWidth = 6;
            this.Nomedousuarios.Name = "Nomedousuarios";
            this.Nomedousuarios.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Nomedolivro
            // 
            this.Nomedolivro.HeaderText = "Nome do Livro";
            this.Nomedolivro.MinimumWidth = 6;
            this.Nomedolivro.Name = "Nomedolivro";
            this.Nomedolivro.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Tempodeemprestimo
            // 
            this.Tempodeemprestimo.HeaderText = "Tempo de Empréstimo";
            this.Tempodeemprestimo.MinimumWidth = 6;
            this.Tempodeemprestimo.Name = "Tempodeemprestimo";
            this.Tempodeemprestimo.ReadOnly = true;
            // 
            // datainicio
            // 
            this.datainicio.HeaderText = "Data inicio";
            this.datainicio.MinimumWidth = 6;
            this.datainicio.Name = "datainicio";
            this.datainicio.ReadOnly = true;
            this.datainicio.Visible = false;
            // 
            // datafim
            // 
            this.datafim.HeaderText = "Data fim";
            this.datafim.MinimumWidth = 6;
            this.datafim.Name = "datafim";
            this.datafim.ReadOnly = true;
            this.datafim.Visible = false;
            // 
            // Listaemprestimo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.Dgvemprestimo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Listaemprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empréstimo";
            this.Load += new System.EventHandler(this.Listaemprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvemprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvemprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomedousuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomedolivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempodeemprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafim;
    }
}