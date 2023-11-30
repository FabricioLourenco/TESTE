using GreenTech.Domain.Entidades;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;

namespace GreenTech.Repository.Repository
{
    public class CadastroResiduoRepository : GenericRepository<CadastroResiduo>, ICadastroResiduoRepository
    {
        public CadastroResiduoRepository(GreenTechContext context) : base(context) { }

        public CadastroResiduo SalvarCadastroResiduo(CadastroResiduo cadastroResiduo)
        {
            return Salvar(cadastroResiduo);
        }

        public CadastroResiduo BuscarCadastroResiduo(long id)
        {
            throw new NotImplementedException();
        }

        public List<CadastroResiduo> BuscarTodosCadastrosResiduos()
        {
            return GetAll().ToList();
        }

        public bool RemoverCadastroResiduo(long id)
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
