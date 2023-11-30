using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Interface
{
    public interface ICadastroResiduoService
    {
        CadastroResiduo SalvarCadastroResiduo(CadastroResiduoDto CadastroResiduoDto);

        CadastroResiduo BuscarCadastroResiduo(long id);

        List<CadastroResiduo> BuscarTodosCadastroResiduo();

        bool RemoverCadastroResiduo(long id);
    }
}
