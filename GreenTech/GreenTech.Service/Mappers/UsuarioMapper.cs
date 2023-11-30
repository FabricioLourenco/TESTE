using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Mappers
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<UsuarioDto, Usuario>();
        }
    }
}
