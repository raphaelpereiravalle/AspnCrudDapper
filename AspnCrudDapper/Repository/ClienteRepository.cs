using AspnCrudDapper.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AspnCrudDapper.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        IConfiguration _configuration;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            return connection;
        }

        public int Add(Cliente cliente)
        {
            var connectionString = this.GetConnection();
            int count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "INSERT INTO CLIENTES (Nome, Telefone, Endereco, Cidade, Bairro, DataNascimento) VALUES (@Nome, @Telefone, @Endereco, @Cidade, @Bairro, @DataNascimento); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                    count = con.Execute(query, cliente);
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

        public List<Cliente> GetClientes()
        {
            var connectionString = this.GetConnection();
            List<Cliente> clientes = new List<Cliente>();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM Clientes";
                    clientes = con.Query<Cliente>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return clientes;
            }

        }

        public Cliente Get(string id)
        {
            var connectionString = this.GetConnection();
            Cliente cliente = new Cliente();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = $"SELECT * FROM Clientes WHERE ClienteId = {id}";
                    cliente = con.Query<Cliente>(query).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return cliente;
            }
        }

        public int Edit(Cliente cliente)
        {
            var connectionString = this.GetConnection();
            var count = 0;
            Cliente clietes = new Cliente();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = $@"UPDATE CLIENTES SET Nome = @Nome, Telefone = @Telefone, Endereco = @Endereco, Cidade = @Cidade, Bairro = @Bairro, DataNascimento = @DataNascimento
                                WHERE (ClienteId = {cliente.ClienteId})";
                    count = con.Execute(query, cliente);
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

        public int Delete(string id)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = $@"DELETE FROM CLIENTES WHERE (ClienteId = {id})";
                    count = con.Execute(query);
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
