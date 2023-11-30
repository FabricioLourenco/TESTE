using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Mappers
{
    public class DadosMapper : Profile
    {
        public DadosMapper()
        {
            CreateMap<DadosDto, Dados>();
        }
    }
}
