namespace SistemaBibliotecaBonito
{
    partial class Listausuarios
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
            this.Dgvusuarios = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvusuarios
            // 
            this.Dgvusuarios.AllowUserToAddRows = false;
            this.Dgvusuarios.AllowUserToDeleteRows = false;
            this.Dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvusuarios.BackgroundColor = System.Drawing.Color.White;
            this.Dgvusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.CPF});
            this.Dgvusuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgvusuarios.Location = new System.Drawing.Point(0, 0);
            this.Dgvusuarios.Name = "Dgvusuarios";
            this.Dgvusuarios.ReadOnly = true;
            this.Dgvusuarios.RowHeadersVisible = false;
            this.Dgvusuarios.RowHeadersWidth = 51;
            this.Dgvusuarios.RowTemplate.Height = 24;
            this.Dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvusuarios.Size = new System.Drawing.Size(1262, 653);
            this.Dgvusuarios.TabIndex = 0;
            this.Dgvusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvusuarios_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Listausuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.Dgvusuarios);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Name = "Listausuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuários";
            this.Load += new System.EventHandler(this.Listausuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvusuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvusuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
    }
}