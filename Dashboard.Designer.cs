namespace devence_lobby
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPedestres = new Button();
            btnSaidas = new Button();
            btnEntradas = new Button();
            btnColaboradores = new Button();
            btnFamiliares = new Button();
            btnTerceirizados = new Button();
            btnMoradores = new Button();
            btnVisitantes = new Button();
            btnNovoCadastro = new Button();
            btnPesquisar = new Button();
            btnInicio = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPedestres);
            panel1.Controls.Add(btnSaidas);
            panel1.Controls.Add(btnEntradas);
            panel1.Controls.Add(btnColaboradores);
            panel1.Controls.Add(btnFamiliares);
            panel1.Controls.Add(btnTerceirizados);
            panel1.Controls.Add(btnMoradores);
            panel1.Controls.Add(btnVisitantes);
            panel1.Controls.Add(btnNovoCadastro);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 661);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.profile;
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(7, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 17);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 3;
            label1.Text = "MAURO LUIZ";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.devenceLogo;
            pictureBox1.Location = new Point(12, 592);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPedestres
            // 
            btnPedestres.FlatAppearance.BorderSize = 0;
            btnPedestres.FlatStyle = FlatStyle.Flat;
            btnPedestres.Font = new Font("Calibri", 16F);
            btnPedestres.ForeColor = Color.Black;
            btnPedestres.Image = Properties.Resources.walk;
            btnPedestres.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedestres.Location = new Point(5, 483);
            btnPedestres.Name = "btnPedestres";
            btnPedestres.Size = new Size(200, 35);
            btnPedestres.TabIndex = 2;
            btnPedestres.Text = "   Pedestres";
            btnPedestres.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedestres.UseVisualStyleBackColor = true;
            btnPedestres.Click += btnPedestres_Click;
            // 
            // btnSaidas
            // 
            btnSaidas.FlatAppearance.BorderSize = 0;
            btnSaidas.FlatStyle = FlatStyle.Flat;
            btnSaidas.Font = new Font("Calibri", 16F);
            btnSaidas.ForeColor = Color.Black;
            btnSaidas.Image = Properties.Resources._out;
            btnSaidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaidas.Location = new Point(5, 442);
            btnSaidas.Name = "btnSaidas";
            btnSaidas.Size = new Size(200, 35);
            btnSaidas.TabIndex = 2;
            btnSaidas.Text = "   Saídas";
            btnSaidas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaidas.UseVisualStyleBackColor = true;
            btnSaidas.Click += btnSaidas_Click;
            // 
            // btnEntradas
            // 
            btnEntradas.FlatAppearance.BorderSize = 0;
            btnEntradas.FlatStyle = FlatStyle.Flat;
            btnEntradas.Font = new Font("Calibri", 16F);
            btnEntradas.ForeColor = Color.Black;
            btnEntradas.Image = Properties.Resources._in;
            btnEntradas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntradas.Location = new Point(5, 401);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(200, 35);
            btnEntradas.TabIndex = 2;
            btnEntradas.Text = "   Entradas";
            btnEntradas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntradas.UseVisualStyleBackColor = true;
            btnEntradas.Click += btnEntradas_Click;
            // 
            // btnColaboradores
            // 
            btnColaboradores.FlatAppearance.BorderSize = 0;
            btnColaboradores.FlatStyle = FlatStyle.Flat;
            btnColaboradores.Font = new Font("Calibri", 16F);
            btnColaboradores.ForeColor = Color.Black;
            btnColaboradores.Image = Properties.Resources.work;
            btnColaboradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnColaboradores.Location = new Point(5, 360);
            btnColaboradores.Name = "btnColaboradores";
            btnColaboradores.Size = new Size(200, 35);
            btnColaboradores.TabIndex = 2;
            btnColaboradores.Text = "   Colaboradores";
            btnColaboradores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnColaboradores.UseVisualStyleBackColor = true;
            btnColaboradores.Click += btnColaboradores_Click;
            // 
            // btnFamiliares
            // 
            btnFamiliares.FlatAppearance.BorderSize = 0;
            btnFamiliares.FlatStyle = FlatStyle.Flat;
            btnFamiliares.Font = new Font("Calibri", 16F);
            btnFamiliares.ForeColor = Color.Black;
            btnFamiliares.Image = Properties.Resources.people;
            btnFamiliares.ImageAlign = ContentAlignment.MiddleLeft;
            btnFamiliares.Location = new Point(5, 319);
            btnFamiliares.Name = "btnFamiliares";
            btnFamiliares.Size = new Size(200, 35);
            btnFamiliares.TabIndex = 2;
            btnFamiliares.Text = "   Familiares";
            btnFamiliares.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFamiliares.UseVisualStyleBackColor = true;
            btnFamiliares.Click += btnFamiliares_Click;
            // 
            // btnTerceirizados
            // 
            btnTerceirizados.FlatAppearance.BorderSize = 0;
            btnTerceirizados.FlatStyle = FlatStyle.Flat;
            btnTerceirizados.Font = new Font("Calibri", 16F);
            btnTerceirizados.ForeColor = Color.Black;
            btnTerceirizados.Image = Properties.Resources.working;
            btnTerceirizados.ImageAlign = ContentAlignment.MiddleLeft;
            btnTerceirizados.Location = new Point(5, 278);
            btnTerceirizados.Name = "btnTerceirizados";
            btnTerceirizados.Size = new Size(200, 35);
            btnTerceirizados.TabIndex = 2;
            btnTerceirizados.Text = "   Terceirizados";
            btnTerceirizados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTerceirizados.UseVisualStyleBackColor = true;
            btnTerceirizados.Click += btnTerceirizados_Click;
            // 
            // btnMoradores
            // 
            btnMoradores.FlatAppearance.BorderSize = 0;
            btnMoradores.FlatStyle = FlatStyle.Flat;
            btnMoradores.Font = new Font("Calibri", 16F);
            btnMoradores.ForeColor = Color.Black;
            btnMoradores.Image = Properties.Resources.user;
            btnMoradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnMoradores.Location = new Point(5, 237);
            btnMoradores.Name = "btnMoradores";
            btnMoradores.Size = new Size(200, 35);
            btnMoradores.TabIndex = 2;
            btnMoradores.Text = "   Moradores";
            btnMoradores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoradores.UseVisualStyleBackColor = true;
            btnMoradores.Click += btnMoradores_Click;
            // 
            // btnVisitantes
            // 
            btnVisitantes.FlatAppearance.BorderSize = 0;
            btnVisitantes.FlatStyle = FlatStyle.Flat;
            btnVisitantes.Font = new Font("Calibri", 16F);
            btnVisitantes.ForeColor = Color.Black;
            btnVisitantes.Image = Properties.Resources.people;
            btnVisitantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisitantes.Location = new Point(5, 196);
            btnVisitantes.Name = "btnVisitantes";
            btnVisitantes.Size = new Size(200, 35);
            btnVisitantes.TabIndex = 2;
            btnVisitantes.Text = "   Visitantes";
            btnVisitantes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisitantes.UseVisualStyleBackColor = true;
            btnVisitantes.Click += btnVisitantes_Click;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Font = new Font("Calibri", 16F);
            btnNovoCadastro.ForeColor = Color.Black;
            btnNovoCadastro.Image = Properties.Resources.add;
            btnNovoCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCadastro.Location = new Point(5, 155);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(200, 35);
            btnNovoCadastro.TabIndex = 2;
            btnNovoCadastro.Text = "   Novo Cadastro";
            btnNovoCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoCadastro.UseVisualStyleBackColor = true;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Calibri", 16F);
            btnPesquisar.ForeColor = Color.Black;
            btnPesquisar.Image = Properties.Resources.search;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(5, 114);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(200, 35);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "   Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Calibri", 16F);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Image = Properties.Resources.house_25px;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(5, 73);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(200, 35);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "   Início";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 79, 73);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 42);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(8, 79, 73);
            btnClose.Image = Properties.Resources.exit;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(851, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 42);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += closeGUI;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.Silver;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(210, 42);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(885, 619);
            mainpanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(1095, 661);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnInicio;
        private PictureBox pictureBox1;
        private Button btnNovoCadastro;
        private Button btnPesquisar;
        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnTerceirizados;
        private Button btnMoradores;
        private Button btnVisitantes;
        private Button btnPedestres;
        private Button btnSaidas;
        private Button btnEntradas;
        private Button btnColaboradores;
        private Button btnFamiliares;
        private Panel mainpanel;
    }
}
