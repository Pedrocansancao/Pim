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
    public partial class Listadelivros : Form
    {
        public Listadelivros()
        {
            InitializeComponent();
        }

        private void Dgvlivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listadelivros_Load(object sender, EventArgs e)
        {
            Dgvlivros.Rows.Add("Dom Casmurro", "Machado de Assis", "1899", "123456", "Romance", "1");

            Dgvlivros.Rows.Add("1984", "George Orwell", "1949", "789456", "Distopia", "0");

            Dgvlivros.Rows.Add("O Hobbit", "J.R.R Tolkien", "1937", "456123", "Fantasia", "0");

            foreach (DataGridViewRow row in Dgvlivros.Rows)
            {
                row.Cells[5].Style.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                row.Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (row.Cells[5].Value.ToString() == "1")
                {
                    row.Cells[5].Value = "●";
                    row.Cells[5].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells[5].Value = "●";
                    row.Cells[5].Style.ForeColor = Color.Red;
                }
            }
        }
    }
}