using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;
using GreenTech.Repository.Interface;
using GreenTech.Service.Interface;

namespace GreenTech.Service.Service
{
    public class CadastroResiduoService : ICadastroResiduoService
    {
        private IMapper _mapper;
        private ICadastroResiduoRepository _cadastroResiduoRepository;

        public CadastroResiduoService(IMapper mapper, ICadastroResiduoRepository cadastroResiduoRepository)
        {
            _mapper = mapper;
            _cadastroResiduoRepository = cadastroResiduoRepository;
        }

        public CadastroResiduo SalvarCadastroResiduo(CadastroResiduoDto cadastroResiduoDto)
        {
            var cadastroResiduo = _mapper.Map<CadastroResiduo>(cadastroResiduoDto);
            return _cadastroResiduoRepository.SalvarCadastroResiduo(cadastroResiduo);
        }

        public CadastroResiduo BuscarCadastroResiduo(long id)
        {
            throw new NotImplementedException();
        }

        public List<CadastroResiduo> BuscarTodosCadastroResiduo()
        {
            return _cadastroResiduoRepository.BuscarTodosCadastrosResiduos();
        }

        public bool RemoverCadastroResiduo(long id)
        {
            return _cadastroResiduoRepository.RemoverCadastroResiduo(id);
        }
    }
}
