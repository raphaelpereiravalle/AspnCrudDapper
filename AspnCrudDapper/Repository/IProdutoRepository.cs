using AspnCrudDapper.Entities;
using SYN.Domain.Model;
using System.Threading.Tasks;

namespace AspnCrudDapper.Repository
{
    public interface IProdutoRepository
    {
        Task<Notificacao> Add(Produto produto);
        Task<DadosProduto> GetProdutos();
        Produto Get(string id);
        Task<Notificacao> Edit(Produto produto);
        Task<Notificacao> Delete(string id);
    }
}
