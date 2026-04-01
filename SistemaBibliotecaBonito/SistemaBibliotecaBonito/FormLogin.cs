using System;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.MaximizeBox = false;   // tira o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // trava o tamanho
            this.StartPosition = FormStartPosition.CenterScreen; // centraliza
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxSenha.PasswordChar = '*';
        }

        private void labelISBN_Click(object sender, EventArgs e)
        {
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.Trim();
            string senha = textBoxSenha.Text.Trim();

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (usuario == "admin" && senha == "123")
            {
                Form1 menu = new Form1();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}