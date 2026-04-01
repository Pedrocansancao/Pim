namespace SistemaBibliotecaBonito
{
    partial class CadastroLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNOME = new System.Windows.Forms.Label();
            this.LabelAUTOR = new System.Windows.Forms.Label();
            this.labelANO = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelGENERO = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTITULO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNOME
            // 
            this.labelNOME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNOME.AutoSize = true;
            this.labelNOME.Location = new System.Drawing.Point(22, 145);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(137, 25);
            this.labelNOME.TabIndex = 0;
            this.labelNOME.Text = "Nome do Livro";
            this.labelNOME.Click += new System.EventHandler(this.labelNOME_Click);
            // 
            // LabelAUTOR
            // 
            this.LabelAUTOR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAUTOR.AutoSize = true;
            this.LabelAUTOR.Location = new System.Drawing.Point(27, 258);
            this.LabelAUTOR.Name = "LabelAUTOR";
            this.LabelAUTOR.Size = new System.Drawing.Size(61, 25);
            this.LabelAUTOR.TabIndex = 1;
            this.LabelAUTOR.Text = "Autor";
            this.LabelAUTOR.Click += new System.EventHandler(this.LabelAutor_Click_1);
            // 
            // labelANO
            // 
            this.labelANO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelANO.AutoSize = true;
            this.labelANO.Location = new System.Drawing.Point(856, 145);
            this.labelANO.Name = "labelANO";
            this.labelANO.Size = new System.Drawing.Size(47, 25);
            this.labelANO.TabIndex = 2;
            this.labelANO.Text = "Ano";
            this.labelANO.Click += new System.EventHandler(this.labelANO_Click);
            // 
            // labelISBN
            // 
            this.labelISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(856, 258);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(54, 25);
            this.labelISBN.TabIndex = 3;
            this.labelISBN.Text = "ISBN";
            this.labelISBN.Click += new System.EventHandler(this.labelISBN_Click);
            // 
            // labelGENERO
            // 
            this.labelGENERO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGENERO.AutoSize = true;
            this.labelGENERO.Location = new System.Drawing.Point(27, 356);
            this.labelGENERO.Name = "labelGENERO";
            this.labelGENERO.Size = new System.Drawing.Size(74, 25);
            this.labelGENERO.TabIndex = 4;
            this.labelGENERO.Text = "Gênero";
            this.labelGENERO.Click += new System.EventHandler(this.labelGENERO_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(27, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(804, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(27, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(804, 31);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aventura",
            "Autobiografia",
            "Autoajuda",
            "Biografia",
            "Chick Lit",
            "Crônica",
            "Desenvolvimento Pessoal",
            "Distopia",
            "Drama",
            "Ensaio",
            "Erótico",
            "Espiritualidade",
            "Fantasia",
            "Ficção Científica",
            "Ficção Histórica",
            "Filosofia",
            "História",
            "Horror Cósmico",
            "Humor",
            "Infantojuvenil",
            "Mistério",
            "New Adult",
            "Policial",
            "Poesia",
            "Realismo Mágico",
            "Romance",
            "Suspense",
            "Terror",
            "Thriller Psicológico",
            "Young Adult (YA)"});
            this.comboBox1.Location = new System.Drawing.Point(27, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(804, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(861, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 31);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(861, 286);
            this.maskedTextBox1.Mask = "000-00-000-0000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(350, 31);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.TabStop = false;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLIMPAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Location = new System.Drawing.Point(453, 559);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(124, 36);
            this.buttonLIMPAR.TabIndex = 10;
            this.buttonLIMPAR.Text = "LIMPAR";
            this.buttonLIMPAR.UseVisualStyleBackColor = false;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(617, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelTITULO
            // 
            this.labelTITULO.AutoSize = true;
            this.labelTITULO.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTITULO.Location = new System.Drawing.Point(26, 47);
            this.labelTITULO.Name = "labelTITULO";
            this.labelTITULO.Size = new System.Drawing.Size(309, 38);
            this.labelTITULO.TabIndex = 12;
            this.labelTITULO.Text = "CADASTRO DE LIVRO";
            this.labelTITULO.Click += new System.EventHandler(this.labelTITULO_Click);
            // 
            // CadastroLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTITULO);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGENERO);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelANO);
            this.Controls.Add(this.LabelAUTOR);
            this.Controls.Add(this.labelNOME);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Label LabelAUTOR;
        private System.Windows.Forms.Label labelANO;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelGENERO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTITULO;
    }
}