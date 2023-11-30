using GreenTech.Domain.Entidades;

namespace GreenTech.Repository.Interface
{
    public interface IRankingRepository
    {
        Ranking SalvarRanking(Ranking ranking);
        Ranking BuscarRanking(long id);
    }
}
