using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Listaemprestimo : Form
    {
        // VARIÁVEL PARA SABER SE VAI FILTRAR ATRASADOS
        public bool MostrarApenasAtrasados = false;

        public Listaemprestimo()
        {
            InitializeComponent();
        }

        private void Dgvemprestimo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listaemprestimo_Load(object sender, EventArgs e)
        {
            DateTime inicio1 = DateTime.Now.AddDays(-5);
            DateTime fim1 = DateTime.Now.AddDays(-1); // atrasado

            DateTime inicio2 = DateTime.Now.AddDays(-2);
            DateTime fim2 = DateTime.Now.AddDays(5); // dentro do prazo

            Dgvemprestimo.Rows.Add("Pedro", "12312312312", "Dom Casmurro", "123456", "", inicio1, fim1);
            Dgvemprestimo.Rows.Add("Marcos", "12312312345", "1984", "789456", "", inicio2, fim2);


            foreach (DataGridViewRow row in Dgvemprestimo.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime dataInicio = Convert.ToDateTime(row.Cells[5].Value);
                DateTime dataFim = Convert.ToDateTime(row.Cells[6].Value);

                if (DateTime.Now > dataFim)
                {
                    row.Cells[4].Value = "🔴 Atrasado";
                    row.Cells[4].Style.ForeColor = Color.Red;
                    row.Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // pinta a linha inteira
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                }
                else
                {
                    row.Cells[4].Value = dataInicio.ToShortDateString() + " - " + dataFim.ToShortDateString();

                    // SE FOR PARA MOSTRAR APENAS ATRASADOS
                    if (MostrarApenasAtrasados)
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }
}