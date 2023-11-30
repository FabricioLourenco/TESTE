using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;
using GreenTech.Repository.Interface;
using GreenTech.Service.Interface;

namespace GreenTech.Service.Service
{
    public class RankingService : IRankingService
    {
        private IMapper _mapper;
        private IRankingRepository _rankingRepository;

        public RankingService(IMapper mapper, IRankingRepository rankingRepository)
        {
            _mapper = mapper;
            _rankingRepository = rankingRepository;
        }

        public Ranking SalvarRanking(RankingDto rankingDto)
        {
            var ranking = _mapper.Map<Ranking>(rankingDto);
            return _rankingRepository.SalvarRanking(ranking);
        }

        public Ranking BuscarRanking(long id)
        {
            throw new NotImplementedException();
        }
    }
}
