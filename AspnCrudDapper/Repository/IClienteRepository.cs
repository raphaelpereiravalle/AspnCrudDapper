using AspnCrudDapper.Entities;
using System.Collections.Generic;

namespace AspnCrudDapper.Repository
{
    public interface IClienteRepository
    {
        int Add(Cliente cliente);
        List<Cliente> GetClientes();
        Cliente Get(string id);
        int Edit(Cliente cliente);
        int Delete(string id);
    }
}