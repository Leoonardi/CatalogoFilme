using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilme.Model
{
    internal class Conexao
    {
      public static string  conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matheus.fleonardi\source\repos\CatalogoFilme\CatalogoFilme\Model\filmesbd.mdf;Integrated Security=True";
        }
    }
}
