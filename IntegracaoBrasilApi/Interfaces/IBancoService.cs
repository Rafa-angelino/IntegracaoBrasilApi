using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ReponseGeneric<List<BancoResponse>>> BuscarTodos();
        Task<ReponseGeneric<BancoResponse>> BuscaBanco(string codigoBanco);
    }
}
