using GreenTech.Domain.Entidades;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;

namespace GreenTech.Repository.Repository
{
    public class EnderecoRepository : GenericRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(GreenTechContext context) : base(context) { }

        public Endereco SalvarEndereco(Endereco endereco)
        {
            return Salvar(endereco);
        }

        public Endereco BuscarEndereco(long id)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> BuscarTodosEnderecos()
        {
            return GetAll().ToList();
        }

        public bool RemoverEndereco(long id)
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
