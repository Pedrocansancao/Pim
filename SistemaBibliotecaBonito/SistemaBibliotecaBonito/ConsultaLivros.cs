using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Consulta_de_Livroscs : Form
    {
        public Consulta_de_Livroscs()
        {
            InitializeComponent();
        }

        private void Consulta_de_Livroscs_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim().ToLower();
            string autor = textBox2.Text.Trim().ToLower();
            string isbn = maskedTextBox1.Text.Trim().Replace("-", "").Replace(" ", "");
            string genero = comboBox1.Text.Trim().ToLower();

            var livrosFiltrados = Banco.Livros.Where(livro =>
                (string.IsNullOrEmpty(nome) || livro.Nome.ToLower().Contains(nome)) &&
                (string.IsNullOrEmpty(autor) || livro.Autor.ToLower().Contains(autor)) &&
                (string.IsNullOrEmpty(isbn) || livro.ISBN.Replace("-", "").Replace(" ", "").Contains(isbn)) &&
                (string.IsNullOrEmpty(genero) || livro.Genero.ToLower().Contains(genero))
            ).ToList();

            if (livrosFiltrados.Count == 0)
            {
                MessageBox.Show("Nenhum livro encontrado.");
                return;
            }

            Listadelivros tela = new Listadelivros();
            tela.LivrosFiltrados = livrosFiltrados;
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listadelivros tela = new Listadelivros();
            tela.Show();
        }
    }
}