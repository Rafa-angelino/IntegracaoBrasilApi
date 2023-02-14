using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ReponseGeneric<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ReponseGeneric<List<BancoModel>>> BuscarTodosBancos();
        Task<ReponseGeneric<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
