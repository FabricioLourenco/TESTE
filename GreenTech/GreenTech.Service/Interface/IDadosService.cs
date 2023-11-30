using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Interface
{
    public interface IDadosService
    {
        Dados SalvarDados(DadosDto DadosDto);
        Dados BuscarDados(long id);
        List<Dados> BuscarTodosDados();
        bool RemoverDados(long id);
    }
}
