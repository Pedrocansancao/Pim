using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Emprestimopendentes : Form
    {
        public Emprestimopendentes()
        {
            InitializeComponent();
        }

        private void Emprestimopendentes_Load(object sender, EventArgs e)
        {
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text
                .Replace(".", "")
                .Replace("-", "")
                .Trim();

            string nomeLivro = textBox1.Text.Trim();

            string isbn = maskedTextBox2.Text
                .Replace(".", "")
                .Replace("-", "")
                .Trim();

            if (string.IsNullOrEmpty(cpf) &&
                string.IsNullOrEmpty(nomeLivro) &&
                string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Preencha pelo menos um campo!");
                return;
            }

            var lista = Banco.Emprestimos
                .Where(emp =>
                    emp.Devolvido == false &&
                    (string.IsNullOrEmpty(cpf) ||
                     emp.Usuario.CPF.Replace(".", "").Replace("-", "").Trim() == cpf) &&
                    (string.IsNullOrEmpty(nomeLivro) ||
                     emp.Livro.Nome.ToLower().Contains(nomeLivro.ToLower())) &&
                    (string.IsNullOrEmpty(isbn) ||
                     emp.Livro.ISBN.Replace(".", "").Replace("-", "").Trim() == isbn)
                )
                .ToList();

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum empréstimo encontrado!");
                return;
            }

            Listaemprestimo tela = new Listaemprestimo();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listaemprestimo tela = new Listaemprestimo();
            tela.Show();
        }

        private void Emprestimopendentes_Load_1(object sender, EventArgs e)
        {

        }
    }
}