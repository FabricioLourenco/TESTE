using GreenTech.Domain.Entidades;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;

namespace GreenTech.Repository.Repository
{
    public class RankingRepository : GenericRepository<Ranking>, IRankingRepository
    {
        public RankingRepository(GreenTechContext context) : base(context) { }

        public Ranking SalvarRanking(Ranking ranking)
        {
            return Salvar(ranking);
        }

        public Ranking BuscarRanking(long id)
        {
            throw new NotImplementedException();
        }
    }
}
