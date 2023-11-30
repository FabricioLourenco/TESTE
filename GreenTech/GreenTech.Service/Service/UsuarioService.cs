using AutoMapper;
using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;
using GreenTech.Repository.Interface;
using GreenTech.Service.Interface;

namespace GreenTech.Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        private IMapper _mapper;
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }

        public Usuario SalvarUsuario(UsuarioDto usuarioDto)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDto);
            return _usuarioRepository.SalvarUsuario(usuario);
        }

        public Usuario BuscarUsuario(long id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            return _usuarioRepository.BuscarTodosUsuarios();
        }

        public bool RemoverUsuario(long id)
        {
            return _usuarioRepository.RemoverUsuario(id);
        }
    }
}
