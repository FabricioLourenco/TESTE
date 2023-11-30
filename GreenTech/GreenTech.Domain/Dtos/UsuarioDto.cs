using GreenTech.Domain.Enuns;

namespace GreenTech.Domain.Dtos
{
    public class UsuarioDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
