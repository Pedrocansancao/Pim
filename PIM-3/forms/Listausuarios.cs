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
    public partial class Listausuarios : Form
    {
        public Listausuarios()
        {
            InitializeComponent();
        }

        private void Dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Listausuarios_Load(object sender, EventArgs e)
        {
            Dgvusuarios.Rows.Add("Pedro", "12324@gmail.com", "12312312312");

            Dgvusuarios.Rows.Add("Marcos", "3445@gmail.com", "123.123.123.46");

            Dgvusuarios.Rows.Add("Roberto", "4372487@gmail.com", "32132132132");
        }
    }
}
