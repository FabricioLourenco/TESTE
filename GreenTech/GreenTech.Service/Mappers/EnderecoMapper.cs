using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Mappers
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
            CreateMap<EnderecoDto, Endereco>();
        }
    }
}
