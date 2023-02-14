using AutoMapper;
using IntegracaoBrasilApi.Dtos;
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ReponseGeneric<BancoResponse>> BuscaBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ReponseGeneric<BancoResponse>>(banco);
        }

        public async Task<ReponseGeneric<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilApi.BuscarTodosBancos();
            return _mapper.Map<ReponseGeneric<List<BancoResponse>>>(bancos);

        }
    }
}
