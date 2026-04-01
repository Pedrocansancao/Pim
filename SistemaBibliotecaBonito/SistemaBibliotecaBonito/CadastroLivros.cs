using System;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class CadastroLivros : Form
    {
        private Livro livroEditando = null;

        public CadastroLivros()
        {
            InitializeComponent();
        }

        public CadastroLivros(Livro livro)
        {
            InitializeComponent();

            livroEditando = livro;

            textBox1.Text = livro.Nome;
            textBox2.Text = livro.Autor;
            maskedTextBox1.Text = livro.ISBN;
            comboBox1.Text = livro.Genero;
            dateTimePicker1.Value = new DateTime(Convert.ToInt32(livro.Ano), 1, 1);
        }

        private void CadastroLivros_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Digite o nome do livro!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Digite o autor!");
                return;
            }

            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Digite o ISBN completo!");
                return;
            }

            if (comboBox1.SelectedIndex == -1 && string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Selecione um gênero!");
                return;
            }

            if (livroEditando != null)
            {
                livroEditando.Nome = textBox1.Text.Trim();
                livroEditando.Autor = textBox2.Text.Trim();
                livroEditando.ISBN = maskedTextBox1.Text;
                livroEditando.Genero = comboBox1.Text;
                livroEditando.Ano = dateTimePicker1.Value.Year.ToString();

                MessageBox.Show("Livro alterado com sucesso!");
                this.Close();
                return;
            }

            Livro novoLivro = new Livro();
            novoLivro.Nome = textBox1.Text.Trim();
            novoLivro.Autor = textBox2.Text.Trim();
            novoLivro.ISBN = maskedTextBox1.Text;
            novoLivro.Genero = comboBox1.Text;
            novoLivro.Ano = dateTimePicker1.Value.Year.ToString();
            novoLivro.Status = 1;

            Banco.Livros.Add(novoLivro);

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1 menu)
                {
                    menu.AtualizarTotais();
                }
            }

            MessageBox.Show("Livro cadastrado com sucesso!");
            buttonLIMPAR_Click(null, null);
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textNomeLivro_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelautor_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void LabelAutor_Click_1(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void labelANO_Click(object sender, EventArgs e)
        {
        }

        private void labelTITULO_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelGENERO_Click(object sender, EventArgs e)
        {
        }

        private void labelISBN_Click(object sender, EventArgs e)
        {
        }

        private void labelNOME_Click(object sender, EventArgs e)
        {
        }
    }
}