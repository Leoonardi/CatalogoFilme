using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilme.Model
{
    internal class serie
    {
        private int id;
      private static string serieserie;
        private static string duracaoserie;
        private static string generoserie;
        private static string temporadaserie;

        public int Id { get => id; set => id = value; }
        public static string Serieserie { get => serieserie; set => serieserie = value; }
        public static string Duracaoserie { get => duracaoserie; set => duracaoserie = value; }
        public static string Generoserie { get => generoserie; set => generoserie = value; }
        public static string Temporadaserie { get => temporadaserie; set => temporadaserie = value; }
    }
}
