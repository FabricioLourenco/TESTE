using GreenTech.Domain.Entidades;

namespace GreenTech.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Usuario SalvarUsuario(Usuario usuario);
        Usuario BuscarUsuario(long id);
        List<Usuario> BuscarTodosUsuarios();
        bool RemoverUsuario(long id);
    }
}
