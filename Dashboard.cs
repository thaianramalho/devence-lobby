namespace devence_lobby
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Color verdeDevence = Color.FromArgb(8, 79, 73);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closeGUI(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_principal(object sender, PaintEventArgs e)
        {

        }


        private Button ultimoBotaoClicado = null;
        public void loadForm(object Form, Button button)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

            if (ultimoBotaoClicado != null)
            {
                ultimoBotaoClicado.ForeColor = SystemColors.ControlText;
            }
            button.ForeColor = verdeDevence;
            ultimoBotaoClicado = button;
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            loadForm(new telaPesquisa(), btnPesquisar);
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            loadForm(new telaCadastro(), btnNovoCadastro);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            loadForm(new telaVisitantes(), btnVisitantes);
        }

        private void btnMoradores_Click(object sender, EventArgs e)
        {
            loadForm(new telaMoradores(), btnMoradores);
        }

        private void btnTerceirizados_Click(object sender, EventArgs e)
        {
            loadForm(new telaTerceirizados(), btnTerceirizados);

        }

        private void btnFamiliares_Click(object sender, EventArgs e)
        {
            loadForm(new telaFamiliares(), btnFamiliares);

        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            loadForm(new telaColaboradores(), btnColaboradores);

        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            loadForm(new telaEntradas(), btnEntradas);

        }

        private void btnSaidas_Click(object sender, EventArgs e)
        {
            loadForm(new telaSaidas(), btnSaidas);
        }

        private void btnPedestres_Click(object sender, EventArgs e)
        {
            loadForm(new telaPedestres(), btnPedestres);
        }
    }
}
