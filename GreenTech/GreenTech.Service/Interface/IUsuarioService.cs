using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Interface
{
    public interface IUsuarioService
    {
        Usuario SalvarUsuario(UsuarioDto usuarioDto);
        Usuario BuscarUsuario(long id);
        List<Usuario> BuscarTodosUsuarios();
        bool RemoverUsuario(long id);
    }
}
