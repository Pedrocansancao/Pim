using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Adicionarusuários : Form
    {
        private readonly Usuario usuarioEditando = null;

        public Adicionarusuários()
        {
            InitializeComponent();
        }

        public Adicionarusuários(Usuario usuario)
        {
            InitializeComponent();

            usuarioEditando = usuario;

            textBox1.Text = usuario.Nome;
            textBox2.Text = usuario.Email;
            maskedTextBox1.Text = usuario.CPF;
        }

        private void Adicionarusuários_Load(object sender, EventArgs e)
        {
        }

        private void labelNOME_Click(object sender, EventArgs e)
        {
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
        }

        private void buttonLIMPAR_Click_1(object sender, EventArgs e)
        {
            buttonLIMPAR_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Digite o nome do usuário!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Digite o email!");
                return;
            }

            if (!textBox2.Text.Contains("@") || !textBox2.Text.Contains("."))
            {
                MessageBox.Show("Digite um email válido!");
                return;
            }

            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Digite o CPF completo!");
                return;
            }

            if (usuarioEditando != null)
            {
                bool cpfDuplicado = Banco.Usuarios.Any(u =>
                    u != usuarioEditando && u.CPF == maskedTextBox1.Text);

                if (cpfDuplicado)
                {
                    MessageBox.Show("Esse CPF já está cadastrado!");
                    return;
                }

                bool emailDuplicado = Banco.Usuarios.Any(u =>
                    u != usuarioEditando &&
                    u.Email.ToLower() == textBox2.Text.Trim().ToLower());

                if (emailDuplicado)
                {
                    MessageBox.Show("Esse email já está cadastrado!");
                    return;
                }

                usuarioEditando.Nome = textBox1.Text.Trim();
                usuarioEditando.Email = textBox2.Text.Trim();
                usuarioEditando.CPF = maskedTextBox1.Text;

                MessageBox.Show("Usuário alterado com sucesso!");
                this.Close();
                return;
            }

            if (Banco.Usuarios.Any(u => u.CPF == maskedTextBox1.Text))
            {
                MessageBox.Show("Esse CPF já está cadastrado!");
                return;
            }

            if (Banco.Usuarios.Any(u => u.Email.ToLower() == textBox2.Text.Trim().ToLower()))
            {
                MessageBox.Show("Esse email já está cadastrado!");
                return;
            }

            Usuario novoUsuario = new Usuario();
            novoUsuario.Nome = textBox1.Text.Trim();
            novoUsuario.Email = textBox2.Text.Trim();
            novoUsuario.CPF = maskedTextBox1.Text;

            Banco.Usuarios.Add(novoUsuario);

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1 menu)
                {
                    menu.AtualizarTotais();
                }
            }

            MessageBox.Show("Usuário cadastrado com sucesso!");
            buttonLIMPAR_Click(sender, e);
        }
    }
}