using AspnCrudDapper.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using SYN.Domain.Model;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<Notificacao> Add(Produto produto)
        {
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO Produtos(
                                         ProdutoId,
                                         CodProduto, 
                                         Nome, 
                                         Estoque, 
                                         Preco, 
                                         DataCadastro) 
                                    VALUES 
                                        (@ProdutoId,
                                         @CodProduto, 
                                         @Nome, 
                                         @Estoque,
                                         @Preco,
                                         @DataCadastro)";

                    Guid guid = Guid.NewGuid();

                    await con.ExecuteAsync(query, new
                    {
                        ProdutoId = guid.ToString(),
                        CodProduto = produto.CodProduto.ToString(),
                        Nome = produto.Nome.ToString(),
                        Estoque = produto.Estoque,
                        Preco = produto.Preco,
                        DataCadastro = produto.DataCadastro
                    });

                    return new Notificacao(false, "Cadastro realizado com sucesso", "");
                }
                catch (Exception ex)
                {
                    return new Notificacao(true, "Erro ao cadastrar", ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public async Task<DadosProduto> GetProdutos()
        {
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    var query = @"SELECT 
                                    ProdutoId,
                                    CodProduto, 
                                    Nome, 
                                    Estoque, 
                                    Preco, 
                                    DataCadastro
                                FROM Produtos 
                                ORDER BY DataCadastro DESC";

                    return new DadosProduto(false, "Listagem com sucesso", await con.QueryAsync<Produto>(query));
                }
                catch (Exception ex)
                {
                    return new DadosProduto(true, "Erro ao listar" + ex, null);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public Produto Get(string id)
        {
            Produto produto = new Produto();
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT 
                                        ProdutoId,
                                        CodProduto, 
                                        Nome, 
                                        Estoque, 
                                        Preco, 
                                        DataCadastro
                                    FROM Produtos WHERE ProdutoId = '{0}'";

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

        public async Task<Notificacao> Edit(Produto produto)
        {
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE Produtos SET 
                                        CodProduto = @CodProduto,                         
                                        Nome = @Nome, 
                                        Estoque = @Estoque, 
                                        Preco = @Preco, 
                                        DataCadastro = @DataCadastro 
                                    WHERE ProdutoId = @ProdutoId";

                    await con.ExecuteAsync(query, new
                    {
                        ProdutoId = produto.ProdutoId.ToString(),
                        CodProduto = produto.CodProduto,
                        Nome = produto.Nome,
                        Estoque = produto.Estoque,
                        Preco = produto.Preco,
                        DataCadastro = produto.DataCadastro
                    });

                    return new Notificacao(false, "Atualização realizada com sucesso!", "");
                }
                catch (Exception ex)
                {
                    return new Notificacao(true, "Erro ao atualizar", ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public async Task<Notificacao> Delete(string id)
        {
            using (var con = new SqlConnection(this.GetConnection()))
            {
                try
                {
                    con.Open();
                    string query = @"DELETE FROM Produtos WHERE ProdutoId = '{0}'";
                    await con.ExecuteAsync(string.Format(query, id));

                    return new Notificacao(false, "Produto deletada com sucesso!", "");
                }
                catch (Exception ex)
                {
                    return new Notificacao(true, "Erro ao deletar Produto", ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
