using GreenTech.Domain.Enuns;

namespace GreenTech.Domain.Entidades
{
    public class Usuario : BaseEntity
    {
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public DateTime? DataCadastro { get; set; }
        
    }
}
