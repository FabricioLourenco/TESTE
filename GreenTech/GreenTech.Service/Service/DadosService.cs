using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;
using GreenTech.Repository.Interface;
using GreenTech.Service.Interface;

namespace GreenTech.Service.Service
{
    public class DadosService : IDadosService
    {
        private IMapper _mapper;
        private IDadosRepository _dadosRepository;

        public DadosService(IMapper mapper, IDadosRepository dadosRepository)
        {
            _mapper = mapper;
            _dadosRepository = dadosRepository;
        }

        public Dados SalvarDados(DadosDto dadosDto)
        {
            var dados = _mapper.Map<Dados>(dadosDto);
            return _dadosRepository.SalvarDados(dados);
        }

        public Dados BuscarDados(long id)
        {
            throw new NotImplementedException();
        }

        public List<Dados> BuscarTodosDados()
        {
            return _dadosRepository.BuscarTodosDados(); ;
        }

        public bool RemoverDados(long id)
        {
            return _dadosRepository.RemoverDados(id);
        }
    }
}
