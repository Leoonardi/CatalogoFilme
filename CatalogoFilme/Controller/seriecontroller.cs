using CatalogoFilme.Model;
using CatalogoFilme.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilme.Controller
{
    internal class seriecontroller
    {

        public void CadastrarSerie()
        {
            SqlConnection cn = new SqlConnection(Conexao1.conectar());
            SqlCommand cmd = new SqlCommand("inserirSerieP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", serie.Serieserie);
                cmd.Parameters.AddWithValue("@estreia", serie.Duracaoserie);
                cmd.Parameters.AddWithValue("@categoria", serie.Generoserie);
                cmd.Parameters.AddWithValue("@duracao", serie.Temporadaserie);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Série Cadastrado com sucesso, " +
                    "Deeseja Cadastrar outra Série?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    TelaCadastroFilme TelaFilme = new TelaCadastroFilme();
                    TelaFilme.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}






