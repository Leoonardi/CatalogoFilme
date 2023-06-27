using CatalogoFilme.Model;
using CatalogoFilme.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlParameter = System.Data.SqlClient.SqlParameter;

namespace CatalogoFilme.Controller
{
    internal class FilmeController
    {


        public void CadastrarFilme()
        {
            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("InserirFilmeP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Filme.NomeFilme);
                cmd.Parameters.AddWithValue("@estreia", Filme.EstreiaFilme);
                cmd.Parameters.AddWithValue("@categoria", Filme.CategoriaFilme);
                cmd.Parameters.AddWithValue("@duracao", Filme.DuracaoFilme);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Filme Cadastrado com sucesso, " +
                    "Deeseja Cadastrar outro filme?",
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
       

