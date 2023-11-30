using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;
using GreenTech.Repository.Interface;
using GreenTech.Service.Interface;

namespace GreenTech.Service.Service
{
    public class EnderecoService : IEnderecoService
    {
        private IMapper _mapper;
        private IEnderecoRepository _enderecoRepository;

        public EnderecoService(IMapper mapper, IEnderecoRepository enderecoRepository)
        {
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
        }
        public Endereco SalvarEndereco(EnderecoDto enderecoDto)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDto);
            return _enderecoRepository.SalvarEndereco(endereco);
        }

        public Endereco BuscarEndereco(long id)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> BuscarTodosEndereco()
        {
            return _enderecoRepository.BuscarTodosEnderecos();
        }

        public bool RemoverEndereco(long id)
        {
            return _enderecoRepository.RemoverEndereco(id);
        }
    }
}
