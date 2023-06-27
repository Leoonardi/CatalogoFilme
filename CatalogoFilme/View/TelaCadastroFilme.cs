using CatalogoFilme.Controller;
using CatalogoFilme.Model;
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
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Filme.NomeFilme  = txBoxFilme.Text;
            Filme.EstreiaFilme = txBoxEstreia.Text;
            Filme.DuracaoFilme = txBoxDuracao.Text;
            Filme.CategoriaFilme = txBoxCategoria.Text;

            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();

           

        }
    }
}
