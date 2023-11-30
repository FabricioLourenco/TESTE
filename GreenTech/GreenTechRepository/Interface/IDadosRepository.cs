using GreenTech.Domain.Entidades;

namespace GreenTech.Repository.Interface
{
    public interface IDadosRepository
    {
        Dados SalvarDados(Dados dados);
        Dados BuscarDados(long id);
        List<Dados> BuscarTodosDados();
        bool RemoverDados(long id);
    }
}
