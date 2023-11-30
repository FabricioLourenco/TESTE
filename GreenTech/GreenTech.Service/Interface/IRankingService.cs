using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Interface
{
    public interface IRankingService
    {
        Ranking SalvarRanking(RankingDto rankingDto);
        Ranking BuscarRanking(long id);
    }
}
