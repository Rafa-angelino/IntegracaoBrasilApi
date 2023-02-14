using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ReponseGeneric<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
