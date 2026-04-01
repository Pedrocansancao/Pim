using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Consultadeusuarios : Form
    {
        public Consultadeusuarios()
        {
            InitializeComponent();
        }

        private void Consultadeusuarios_Load(object sender, EventArgs e)
        {
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();       // Nome
            textBox2.Clear();       // Email
            maskedTextBox1.Clear(); // CPF
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim().ToLower();
            string email = textBox2.Text.Trim().ToLower();
            string cpf = maskedTextBox1.Text.Trim().Replace("-", "").Replace(".", "").Replace(" ", "");

            var usuariosFiltrados = Banco.Usuarios.Where(usuario =>
                (string.IsNullOrEmpty(nome) || usuario.Nome.ToLower().Contains(nome)) &&
                (string.IsNullOrEmpty(email) || usuario.Email.ToLower().Contains(email)) &&
                (string.IsNullOrEmpty(cpf) || usuario.CPF.Replace("-", "").Replace(".", "").Replace(" ", "").Contains(cpf))
            ).ToList();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado.");
                return;
            }

            Listausuarios tela = new Listausuarios();
            tela.UsuariosFiltrados = usuariosFiltrados;
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listausuarios tela = new Listausuarios();
            tela.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim().ToLower();
            string email = textBox2.Text.Trim().ToLower();
            string cpf = maskedTextBox1.Text
                .Trim()
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "");

            var usuariosFiltrados = Banco.Usuarios.Where(usuario =>
                (string.IsNullOrEmpty(nome) || usuario.Nome.ToLower().Contains(nome)) &&
                (string.IsNullOrEmpty(email) || usuario.Email.ToLower().Contains(email)) &&
                (string.IsNullOrEmpty(cpf) || usuario.CPF.Replace(".", "").Replace("-", "").Contains(cpf))
            ).ToList();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado.");
                return;
            }

            Listausuarios tela = new Listausuarios();
            tela.UsuariosFiltrados = usuariosFiltrados;
            tela.Show();
        }

        private void buttonLIMPAR_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();       // Nome
            textBox2.Clear();       // Email
            maskedTextBox1.Clear(); // CPF
        }
    }
}