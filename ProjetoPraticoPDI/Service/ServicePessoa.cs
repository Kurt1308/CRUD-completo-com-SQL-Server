using ProjetoPraticoPDI.Interfaces;
using ProjetoPraticoPDI.Model;
using System.Data.SqlClient;

namespace ProjetoPraticoPDI.Service
{
    public class ServicePessoa : IServicePessoa
    {
        string conexao = "Data Source=B2C-SPMP-17;Initial Catalog=PROJETO_PRATICO_PDI;Integrated Security=True";

        public List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetPessoasComId", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    var pessoa = new Pessoa();
                                    mapperToGetPessoa(reader, pessoa);
                                    pessoas.Add(pessoa);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return pessoas;
        }
        public List<Pessoa> GetPessoaById(int id)
        {
            List<Pessoa> pessoa = new List<Pessoa>();
            SqlConnection conn = new SqlConnection(conexao);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetPessoaById", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var pessoaRequest = new Pessoa();
                        mapperToGetPessoaById(reader, pessoaRequest);
                        pessoa.Add(pessoaRequest);
                    }
                    return pessoa;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void InserirPessoa(PessoaDTO pessoaDTO)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddPessoa", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        mapperToInserirPessoa(pessoaDTO, cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void DeletePessoa(int id)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open(); ;
                    SqlCommand cmd = new SqlCommand("DeletePessoa1", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void UpdatePessoa(Pessoa pessoa)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdatePessoa", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        mapperToUpdatePessoa(pessoa, cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private static void mapperToGetPessoa(SqlDataReader reader, Pessoa pessoa)
        {
            pessoa.Id = reader.GetInt32(0);
            pessoa.Nome = reader["Nome"].ToString();
            pessoa.Email = reader["Email"].ToString();
        }
        private static void mapperToUpdatePessoa(Pessoa pessoa, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id", pessoa.Id);
            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
        }
        private static void mapperToInserirPessoa(PessoaDTO pessoaDTO, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Nome", pessoaDTO.Nome);
            cmd.Parameters.AddWithValue("@Email", pessoaDTO.Email);
        }
        private static void mapperToGetPessoaById(SqlDataReader reader, Pessoa pessoaRequest)
        {
            pessoaRequest.Id = reader.GetInt32(0);
            pessoaRequest.Nome = reader["Nome"].ToString();
            pessoaRequest.Email = reader["Email"].ToString();
        }
    }
}
