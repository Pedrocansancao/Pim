namespace SistemaBibliotecaBonito
{
    partial class Consulta_de_Livroscs
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
            this.labelTITULO = new System.Windows.Forms.Label();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelGENERO = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelANO = new System.Windows.Forms.Label();
            this.LabelAUTOR = new System.Windows.Forms.Label();
            this.labelNOME = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTITULO
            // 
            this.labelTITULO.AutoSize = true;
            this.labelTITULO.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTITULO.Location = new System.Drawing.Point(26, 47);
            this.labelTITULO.Name = "labelTITULO";
            this.labelTITULO.Size = new System.Drawing.Size(307, 38);
            this.labelTITULO.TabIndex = 13;
            this.labelTITULO.Text = "CONSULTA DE LIVRO";
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLIMPAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Location = new System.Drawing.Point(453, 559);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(124, 36);
            this.buttonLIMPAR.TabIndex = 24;
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
            this.button1.TabIndex = 25;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.maskedTextBox1.TabIndex = 23;
            this.maskedTextBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(861, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 31);
            this.dateTimePicker1.TabIndex = 22;
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
            this.comboBox1.TabIndex = 21;
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
            this.textBox2.TabIndex = 20;
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
            this.textBox1.TabIndex = 19;
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
            this.labelGENERO.TabIndex = 18;
            this.labelGENERO.Text = "Gênero";
            // 
            // labelISBN
            // 
            this.labelISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(856, 258);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(54, 25);
            this.labelISBN.TabIndex = 17;
            this.labelISBN.Text = "ISBN";
            // 
            // labelANO
            // 
            this.labelANO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelANO.AutoSize = true;
            this.labelANO.Location = new System.Drawing.Point(856, 145);
            this.labelANO.Name = "labelANO";
            this.labelANO.Size = new System.Drawing.Size(47, 25);
            this.labelANO.TabIndex = 16;
            this.labelANO.Text = "Ano";
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
            this.LabelAUTOR.TabIndex = 15;
            this.LabelAUTOR.Text = "Autor";
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
            this.labelNOME.TabIndex = 14;
            this.labelNOME.Text = "Nome do Livro";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(588, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 36);
            this.button2.TabIndex = 42;
            this.button2.Text = "LISTA DE LIVROS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consulta_de_Livroscs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.labelTITULO);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Name = "Consulta_de_Livroscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consunta de Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consulta_de_Livroscs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTITULO;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelGENERO;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelANO;
        private System.Windows.Forms.Label LabelAUTOR;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Button button2;
    }
}