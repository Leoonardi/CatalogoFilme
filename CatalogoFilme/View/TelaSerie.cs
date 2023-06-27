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
    public partial class TelaSerie : Form
    {
        public TelaSerie()
        {
            InitializeComponent();
        }

        private void TelaSerie_Load(object sender, EventArgs e)
        {
            serie.Serieserie = txBoxSerie.Text;
            serie.Generoserie =  txtboxgenero.Text;
            serie.Duracaoserie = txBoxDuracao.Text;
            serie.Temporadaserie = txBoxTemporada.Text;

            seriecontroller SerieController = new seriecontroller();
            SerieController.CadastrarSerie();
        }
    }
}
