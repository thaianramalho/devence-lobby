using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devence_lobby
{
    public partial class telaInicio : Form
    {
        public telaInicio()
        {
            InitializeComponent();
            lblEntradasNumber.Parent = pictureEntradas;
            lblEntradasNumber.BackColor = Color.Transparent;
            lblSaidasNumber.Parent = pictureSaidas;
            lblSaidasNumber.BackColor = Color.Transparent;


        }

        private void telaInicio_Load(object sender, EventArgs e)
        {
        }

        private void pictureEntradas_Click(object sender, EventArgs e)
        {

        }
    }
}
