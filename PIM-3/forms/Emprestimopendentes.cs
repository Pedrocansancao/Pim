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
    public partial class Emprestimopendentes : Form
    {
        public Emprestimopendentes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listaemprestimo tela = new Listaemprestimo();
            tela.ShowDialog();

        }
    }
}
