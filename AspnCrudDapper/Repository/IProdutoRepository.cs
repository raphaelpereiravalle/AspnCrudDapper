using AspnCrudDapper.Entities;
using System.Collections.Generic;

namespace AspnCrudDapper.Repository
{
    public interface IProdutoRepository
    {
        int Add(Produto produto);
        List<Produto> GetProdutos();
        Produto Get(string id);
        int Edit(Produto produto);
        int Delete(string id);
    }
}
