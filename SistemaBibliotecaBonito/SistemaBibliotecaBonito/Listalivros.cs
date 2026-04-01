using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Listadelivros : Form
    {
        public List<Livro> LivrosFiltrados { get; set; }

        public Listadelivros()
        {
            InitializeComponent();
        }

        private void Listadelivros_Load(object sender, EventArgs e)
        {
            ConfigurarColunasAcoes();
            CarregarLivrosNaTabela();
        }

        private void ConfigurarColunasAcoes()
        {
            if (!Dgvlivros.Columns.Contains("Excluir"))
            {
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.Name = "Excluir";
                btnExcluir.HeaderText = "Excluir";
                btnExcluir.Text = "X";
                btnExcluir.UseColumnTextForButtonValue = true;

                Dgvlivros.Columns.Add(btnExcluir);
            }

            if (!Dgvlivros.Columns.Contains("Alterar"))
            {
                DataGridViewButtonColumn btnAlterar = new DataGridViewButtonColumn();
                btnAlterar.Name = "Alterar";
                btnAlterar.HeaderText = "Alterar";
                btnAlterar.Text = "Editar";
                btnAlterar.UseColumnTextForButtonValue = true;

                Dgvlivros.Columns.Add(btnAlterar);
            }
        }

        private void CarregarLivrosNaTabela()
        {
            Dgvlivros.Rows.Clear();

            var listaParaMostrar = LivrosFiltrados ?? Banco.Livros;

            foreach (var livro in listaParaMostrar)
            {
                int index = Dgvlivros.Rows.Add(
                    livro.Nome,
                    livro.Autor,
                    livro.Ano,
                    livro.ISBN,
                    livro.Genero,
                    livro.Status
                );

                Dgvlivros.Rows[index].Tag = livro;
            }

            EstilizarStatus();
        }

        private void EstilizarStatus()
        {
            foreach (DataGridViewRow row in Dgvlivros.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[5].Value == null) continue;

                row.Cells[5].Style.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                row.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                int status = Convert.ToInt32(row.Cells[5].Value);

                row.Cells[5].Value = "●";

                if (status == 1)
                {
                    row.Cells[5].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells[5].Style.ForeColor = Color.Red;
                }
            }
        }

        private void Dgvlivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Livro livroSelecionado = Dgvlivros.Rows[e.RowIndex].Tag as Livro;

            if (livroSelecionado == null)
            {
                return;
            }

            if (Dgvlivros.Columns[e.ColumnIndex].Name == "Excluir")
            {
                bool livroEmprestado = Banco.Emprestimos.Any(emp =>
                    emp.Livro == livroSelecionado && emp.Devolvido == false);

                if (livroEmprestado)
                {
                    MessageBox.Show("Não é possível excluir este livro porque ele está emprestado.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "Deseja excluir este livro?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    Banco.Livros.Remove(livroSelecionado);

                    if (LivrosFiltrados != null)
                    {
                        LivrosFiltrados.Remove(livroSelecionado);
                    }

                    CarregarLivrosNaTabela();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Form1 menu)
                        {
                            menu.AtualizarTotais();
                        }
                    }

                    MessageBox.Show("Livro excluído com sucesso!");
                }

                return;
            }

            if (Dgvlivros.Columns[e.ColumnIndex].Name == "Alterar")
            {
                bool livroEmprestado = Banco.Emprestimos.Any(emp =>
                    emp.Livro == livroSelecionado && emp.Devolvido == false);

                if (livroEmprestado)
                {
                    MessageBox.Show("Não é possível alterar este livro porque ele está emprestado.");
                    return;
                }

                CadastroLivros tela = new CadastroLivros(livroSelecionado);
                tela.ShowDialog();

                CarregarLivrosNaTabela();

                foreach (Form form in Application.OpenForms)
                {
                    if (form is Form1 menu)
                    {
                        menu.AtualizarTotais();
                    }
                }
            }
        }
    }
}