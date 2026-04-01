using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Registrardevolucao : Form
    {
        public Registrardevolucao()
        {
            InitializeComponent();
        }

        private void Registrardevolucao_Load(object sender, EventArgs e)
        {
        }

        private void labelTITULO_Click(object sender, EventArgs e)
        {
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear(); // CPF
            textBox1.Clear();       // Nome do Livro
            maskedTextBox2.Clear(); // ISBN
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "")
                .Trim();

            string nomeLivro = textBox1.Text.Trim();

            string isbn = maskedTextBox2.Text
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "")
                .Trim();

            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Digite o CPF completo!");
                return;
            }

            if (string.IsNullOrWhiteSpace(nomeLivro))
            {
                MessageBox.Show("Digite o nome do livro!");
                return;
            }

            if (!maskedTextBox2.MaskCompleted)
            {
                MessageBox.Show("Digite o ISBN completo!");
                return;
            }

            Usuario usuario = Banco.Usuarios.FirstOrDefault(u =>
                u.CPF != null &&
                u.CPF.Replace(".", "").Replace("-", "").Replace(" ", "").Trim() == cpf);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

            Livro livro = Banco.Livros.FirstOrDefault(l =>
                l.Nome != null &&
                l.ISBN != null &&
                l.Nome.Trim().Equals(nomeLivro, StringComparison.OrdinalIgnoreCase) &&
                l.ISBN.Replace(".", "").Replace("-", "").Replace(" ", "").Trim() == isbn);

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado!");
                return;
            }

            Emprestimo emprestimo = Banco.Emprestimos.FirstOrDefault(emp =>
                emp.Usuario == usuario &&
                emp.Livro == livro &&
                emp.Devolvido == false);

            if (emprestimo == null)
            {
                MessageBox.Show("Nenhum empréstimo pendente encontrado para esse usuário e livro.");
                return;
            }

            emprestimo.Devolvido = true;
            livro.Status = 1;

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1 menu)
                {
                    menu.AtualizarTotais();
                }
            }

            MessageBox.Show("Devolução registrada com sucesso!");

            buttonLIMPAR_Click(null, null);
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            string isbn = maskedTextBox2.Text
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "")
                .Trim();

            var livro = Banco.Livros.FirstOrDefault(l =>
                l.ISBN != null &&
                l.ISBN.Replace(".", "").Replace("-", "").Replace(" ", "").Trim() == isbn
            );

            if (livro != null)
            {
                textBox1.Text = livro.Nome;
            }
            else
            {
                MessageBox.Show("Livro não encontrado!");
                textBox1.Clear();
            }
        }

        private void Registrardevolucao_Load_1(object sender, EventArgs e)
        {
        }
    }
}