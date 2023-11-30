using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Mappers
{
    public class CadastroResiduoMapper : Profile
    {
        public CadastroResiduoMapper()
        {
            CreateMap<CadastroResiduoDto, CadastroResiduo>();
        }
    }
}
