using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBibliotecaBonito
{
    public partial class Form1 : Form
    {
        private List<Control> dashboardOriginal = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboardOriginal = panelmenu.Controls.Cast<Control>().ToList();

            ArredondarPanel(PNLATRASADOS, 20);
            ArredondarPanel(PNLLIVROSEMPRESTADOS, 20);
            ArredondarPanel(PNLTOTALDELIVROS, 20);
            ArredondarPanel(PNLTOTALDEUSUARIOS2, 20);

            AtualizarTotais();
        }

        private void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - raio, 0, raio, raio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - raio, panel.Height - raio, raio, raio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - raio, raio, raio), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
            panel.Refresh();
        }

        public void AtualizarTotais()
        {
            label6.Text = Banco.Livros.Count.ToString();
            labelnumero1.Text = Banco.Usuarios.Count.ToString();

            int emprestados = Banco.Emprestimos.Count(e => !e.Devolvido);
            label2.Text = emprestados.ToString();

            int atrasados = Banco.Emprestimos.Count(e =>
            {
                if (e.Devolvido)
                    return false;

                DateTime data;
                if (DateTime.TryParseExact(
                    e.DataDevolucao,
                    "dd/MM/yyyy",
                    new CultureInfo("pt-BR"),
                    DateTimeStyles.None,
                    out data))
                {
                    return data.Date < DateTime.Today;
                }

                return false;
            });

            label7.Text = atrasados.ToString();
        }

        private void BIBLIOTECA_Click(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            foreach (Control c in dashboardOriginal)
            {
                panelmenu.Controls.Add(c);
            }

            AtualizarTotais();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            CadastroLivros tela = new CadastroLivros();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            Consulta_de_Livroscs tela = new Consulta_de_Livroscs();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            Adicionarusuários tela = new Adicionarusuários();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            Consultadeusuarios tela = new Consultadeusuarios();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            Realizaremprestimo tela = new Realizaremprestimo();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            Registrardevolucao tela = new Registrardevolucao();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelmenu.Controls.Clear();

            Emprestimopendentes tela = new Emprestimopendentes();
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panelmenu.Controls.Add(tela);
            tela.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Listadelivros tela = new Listadelivros();
            tela.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Listausuarios tela = new Listausuarios();
            tela.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Listaemprestimo tela = new Listaemprestimo();
            tela.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Listaemprestimo tela = new Listaemprestimo();
            tela.MostrarApenasAtrasados = true;
            tela.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Listadelivros tela = new Listadelivros();
            tela.Show();
        }

        private void labelnumero1_Click(object sender, EventArgs e)
        {
            Listausuarios tela = new Listausuarios();
            tela.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Listaemprestimo tela = new Listaemprestimo();
            tela.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Listaemprestimo tela = new Listaemprestimo();
            tela.MostrarApenasAtrasados = true;
            tela.Show();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel7_Paint(object sender, PaintEventArgs e) { }
        private void panelConteudo_Paint(object sender, PaintEventArgs e) { }
        private void Paneltotallivros_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
    }
}