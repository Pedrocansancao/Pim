using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Listaemprestimo : Form
    {
        public bool MostrarApenasAtrasados { get; set; } = false;

        public Listaemprestimo()
        {
            InitializeComponent();
        }

        private void Listaemprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
        }

        private void Dgvemprestimo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CarregarEmprestimos()
        {
            Dgvemprestimo.Rows.Clear();

            DateTime hoje = DateTime.Now.Date;

            foreach (var emp in Banco.Emprestimos)
            {
                if (emp.Devolvido)
                    continue;

                DateTime dataFim = DateTime.ParseExact(
                    emp.DataDevolucao,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture
                );

                int diasRestantes = (dataFim - hoje).Days;
                bool atrasado = hoje > dataFim;

                string tempoTexto;

                if (diasRestantes == 0)
                {
                    tempoTexto = "vence hoje";
                }
                else if (atrasado)
                {
                    tempoTexto = Math.Abs(diasRestantes) + " dia(s) atrasado";
                }
                else
                {
                    tempoTexto = diasRestantes + " dia(s) restante(s)";
                }

                int linha = Dgvemprestimo.Rows.Add(
                    emp.Usuario.Nome,
                    emp.Usuario.CPF,
                    emp.Livro.Nome,
                    emp.Livro.ISBN,
                    tempoTexto,
                    "●"
                );

                DataGridViewCell cellStatus = Dgvemprestimo.Rows[linha].Cells[Dgvemprestimo.Columns.Count - 1];

                cellStatus.Value = "●";
                cellStatus.Style.Font = new Font("Segoe UI Symbol", 18, FontStyle.Bold);
                cellStatus.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                cellStatus.Style.SelectionForeColor = atrasado ? Color.Red : Color.Green;
                cellStatus.Style.ForeColor = atrasado ? Color.Red : Color.Green;
            }
            }
        }
    }
