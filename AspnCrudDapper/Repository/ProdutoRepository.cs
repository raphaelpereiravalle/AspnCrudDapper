using AspnCrudDapper.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AspnCrudDapper.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        IConfiguration _configuration;

        public ProdutoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            return connection;
        }

        public int Add(Produto produto)
        {
            //var connectionString = this.GetConnection();
            int count = 0;

            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Produtos(Nome, Estoque, Preco, DataCadastro) VALUES (@Nome, @Estoque, @Preco, @DataCadastro); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                    count = con.Execute(query, produto);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

            return count;
        }

        public List<Produto> GetProdutos()
        {
            //var connectionString = this.GetConnection();
            List<Produto> produtos = new List<Produto>();

            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM Produtos";
                    produtos = con.Query<Produto>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return produtos;
            }
        }

        public Produto Get(string id)
        {
            //  var connectionString = this.GetConnection();
            Produto produto = new Produto();
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Produtos WHERE ProdutoId = '{0}'";
                    produto = con.Query<Produto>(string.Format(query, id)).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return produto;
            }
        }

        public int Edit(Produto produto)
        {
            //var connectionString = this.GetConnection();
            var count = 0;
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Produtos SET Nome = @Nome, Estoque = @Estoque, Preco = @Preco, DataCadastro = @DataCadastro WHERE ProdutoId = @ProdutoId";
                    count = con.Execute(query, new
                    {
                        ProdutoId = produto.ProdutoId.ToString(),
                        Nome = produto.Nome,
                        Estoque = produto.Estoque,
                        Preco = produto.Preco,
                        DataCadastro = produto.DataCadastro
                    });

                    return count;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public int Delete(string id)
        {
            var count = 0;
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Produtos WHERE ProdutoId = '{0}'";
                    count = con.Execute(string.Format(query, id));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return count;
            }
        }
    }
}
