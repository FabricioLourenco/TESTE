using GreenTech.Domain.Entidades;

namespace GreenTech.Repository.Interface
{
    public interface ICadastroResiduoRepository
    {
        CadastroResiduo SalvarCadastroResiduo(CadastroResiduo cadastroResiduo);
        CadastroResiduo BuscarCadastroResiduo(long id);
        List<CadastroResiduo> BuscarTodosCadastrosResiduos();
        bool RemoverCadastroResiduo(long id);
    }
}
