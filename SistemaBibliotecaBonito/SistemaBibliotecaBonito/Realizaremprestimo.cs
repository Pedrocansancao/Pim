using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Realizaremprestimo : Form
    {
        public Realizaremprestimo()
        {
            InitializeComponent();
        }

        private void Realizaremprestimo_Load(object sender, EventArgs e)
        {
        }

        private void labelISBN_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "")
                .Trim();

            // CAMPOS INVERTIDOS NO FORM
            string nomeLivro = textBox2.Text.Trim();
            string autor = textBox1.Text.Trim();

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

            if (string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Digite o autor!");
                return;
            }

            if (!maskedTextBox2.MaskCompleted)
            {
                MessageBox.Show("Digite o ISBN completo!");
                return;
            }

            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("A data de devolução não pode ser menor que hoje!");
                return;
            }

            Usuario usuario = Banco.Usuarios.FirstOrDefault(u =>
                u.CPF != null &&
                u.CPF.Replace(".", "").Replace("-", "").Replace(" ", "").Trim() == cpf
            );

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!");
                return;
            }

            Livro livro = Banco.Livros.FirstOrDefault(l =>
                l.Nome != null &&
                l.Autor != null &&
                l.ISBN != null &&
                l.Nome.Trim().Equals(nomeLivro, StringComparison.OrdinalIgnoreCase) &&
                l.Autor.Trim().Equals(autor, StringComparison.OrdinalIgnoreCase) &&
                l.ISBN.Replace(".", "").Replace("-", "").Replace(" ", "").Trim() == isbn
            );

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado!");
                return;
            }

            if (livro.Status != 1)
            {
                MessageBox.Show("Livro indisponível!");
                return;
            }

            Emprestimo novoEmprestimo = new Emprestimo();
            novoEmprestimo.Usuario = usuario;
            novoEmprestimo.Livro = livro;
            novoEmprestimo.DataDevolucao = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            novoEmprestimo.Devolvido = false;

            Banco.Emprestimos.Add(novoEmprestimo);

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1 menu)
                {
                    menu.AtualizarTotais();
                }
            }

            livro.Status = 0;

            MessageBox.Show("Empréstimo realizado com sucesso!");

            buttonLIMPAR_Click_1(null, null);
        }

        private void buttonLIMPAR_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
        }

        private void maskedTextBox2_Leave_1(object sender, EventArgs e)
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
                // CAMPOS INVERTIDOS NO FORM
                textBox2.Text = livro.Nome;   // Nome do Livro
                textBox1.Text = livro.Autor;  // Autor
            }
            else
            {
                MessageBox.Show("Livro não encontrado!");
                textBox2.Clear();
                textBox1.Clear();
            }
        }
    }
}