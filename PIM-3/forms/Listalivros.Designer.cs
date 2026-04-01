namespace SistemaBibliotecaBonito
{
    partial class Listadelivros
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
            this.Dgvlivros = new System.Windows.Forms.DataGridView();
            this.Nome_do_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GÊNERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlivros)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvlivros
            // 
            this.Dgvlivros.AllowUserToAddRows = false;
            this.Dgvlivros.AllowUserToDeleteRows = false;
            this.Dgvlivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvlivros.BackgroundColor = System.Drawing.Color.White;
            this.Dgvlivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgvlivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvlivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_do_livro,
            this.Autor,
            this.ano,
            this.ISBN,
            this.GÊNERO,
            this.Disponivel});
            this.Dgvlivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgvlivros.Location = new System.Drawing.Point(0, 0);
            this.Dgvlivros.Name = "Dgvlivros";
            this.Dgvlivros.ReadOnly = true;
            this.Dgvlivros.RowHeadersVisible = false;
            this.Dgvlivros.RowHeadersWidth = 51;
            this.Dgvlivros.RowTemplate.Height = 24;
            this.Dgvlivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvlivros.Size = new System.Drawing.Size(1262, 653);
            this.Dgvlivros.TabIndex = 0;
            this.Dgvlivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvlivros_CellContentClick);
            // 
            // Nome_do_livro
            // 
            this.Nome_do_livro.HeaderText = "Nome do livro";
            this.Nome_do_livro.MinimumWidth = 6;
            this.Nome_do_livro.Name = "Nome_do_livro";
            this.Nome_do_livro.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.MinimumWidth = 6;
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // GÊNERO
            // 
            this.GÊNERO.HeaderText = "Gênero";
            this.GÊNERO.MinimumWidth = 6;
            this.GÊNERO.Name = "GÊNERO";
            this.GÊNERO.ReadOnly = true;
            // 
            // Disponivel
            // 
            this.Disponivel.HeaderText = "Disponível";
            this.Disponivel.MinimumWidth = 6;
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.ReadOnly = true;
            // 
            // Listadelivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.Dgvlivros);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Listadelivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listadelivros";
            this.Load += new System.EventHandler(this.Listadelivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvlivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_do_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GÊNERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponivel;
    }
}