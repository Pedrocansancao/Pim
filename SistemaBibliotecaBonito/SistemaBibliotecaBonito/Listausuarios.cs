using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Listausuarios : Form
    {
        public List<Usuario> UsuariosFiltrados { get; set; }

        public Listausuarios()
        {
            InitializeComponent();
        }

        private void Listausuarios_Load(object sender, EventArgs e)
        {
            ConfigurarColunasAcoes();
            CarregarUsuariosNaTabela();
        }

        private void ConfigurarColunasAcoes()
        {
            if (!Dgvusuarios.Columns.Contains("Excluir"))
            {
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.Name = "Excluir";
                btnExcluir.HeaderText = "Excluir";
                btnExcluir.Text = "X";
                btnExcluir.UseColumnTextForButtonValue = true;

                Dgvusuarios.Columns.Add(btnExcluir);
            }

            if (!Dgvusuarios.Columns.Contains("Alterar"))
            {
                DataGridViewButtonColumn btnAlterar = new DataGridViewButtonColumn();
                btnAlterar.Name = "Alterar";
                btnAlterar.HeaderText = "Alterar";
                btnAlterar.Text = "Editar";
                btnAlterar.UseColumnTextForButtonValue = true;

                Dgvusuarios.Columns.Add(btnAlterar);
            }
        }

        private void CarregarUsuariosNaTabela()
        {
            Dgvusuarios.Rows.Clear();

            var listaParaMostrar = UsuariosFiltrados ?? Banco.Usuarios;

            foreach (var usuario in listaParaMostrar)
            {
                int index = Dgvusuarios.Rows.Add(
                    usuario.Nome,
                    usuario.Email,
                    usuario.CPF
                );

                Dgvusuarios.Rows[index].Tag = usuario;
            }
        }

        private void Dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Usuario usuarioSelecionado = Dgvusuarios.Rows[e.RowIndex].Tag as Usuario;

            if (usuarioSelecionado == null)
            {
                return;
            }

            // EXCLUIR
            if (Dgvusuarios.Columns[e.ColumnIndex].Name == "Excluir")
            {
                bool usuarioComEmprestimo = Banco.Emprestimos.Any(emp =>
                    emp.Usuario == usuarioSelecionado && emp.Devolvido == false);

                if (usuarioComEmprestimo)
                {
                    MessageBox.Show("Não é possível excluir este usuário porque ele possui empréstimo pendente.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "Deseja excluir este usuário?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    Banco.Usuarios.Remove(usuarioSelecionado);

                    if (UsuariosFiltrados != null)
                    {
                        UsuariosFiltrados.Remove(usuarioSelecionado);
                    }

                    CarregarUsuariosNaTabela();

                    MessageBox.Show("Usuário excluído com sucesso!");
                }

                return;
            }

            // ALTERAR
            if (Dgvusuarios.Columns[e.ColumnIndex].Name == "Alterar")
            {
                bool usuarioComEmprestimo = Banco.Emprestimos.Any(emp =>
                    emp.Usuario == usuarioSelecionado && emp.Devolvido == false);

                if (usuarioComEmprestimo)
                {
                    MessageBox.Show("Não é possível alterar este usuário porque ele possui empréstimo pendente.");
                    return;
                }

                Adicionarusuários tela = new Adicionarusuários(usuarioSelecionado);
                tela.ShowDialog();

                CarregarUsuariosNaTabela();
            }
        }
    }
}