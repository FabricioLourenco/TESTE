using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Mappers
{
    public class RankingMapper : Profile
    {
        public RankingMapper()
        {
            CreateMap<RankingDto, Ranking>();
        }
    }
}
