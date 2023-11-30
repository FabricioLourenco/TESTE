using GreenTech.Domain.Entidades;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;

namespace GreenTech.Repository.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(GreenTechContext context) : base(context) { }

        public Usuario SalvarUsuario(Usuario usuario)
        {
            return Salvar(usuario);
        }

        public Usuario BuscarUsuario(long id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            return GetAll().ToList();
        }

        public bool RemoverUsuario(long id)
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
