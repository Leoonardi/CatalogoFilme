using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilme.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme jFilme = new TelaCadastroFilme();
            jFilme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaSerie jserie = new TelaSerie();
            jserie.Show();
        }
    }
}
