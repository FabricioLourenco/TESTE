using GreenTech.Domain.Entidades;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;

namespace GreenTech.Repository.Repository
{
    public class DadosRepository : GenericRepository<Dados>, IDadosRepository
    {
        public DadosRepository(GreenTechContext context) : base(context) { }

        public Dados SalvarDados(Dados dados)
        {
            return Salvar(dados);
        }

        public Dados BuscarDados(long id)
        {
            throw new NotImplementedException();
        }

        public List<Dados> BuscarTodosDados()
        {
            return GetAll().ToList();
        }

        public bool RemoverDados(long id)
        {
            try
            {
                Remover(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
