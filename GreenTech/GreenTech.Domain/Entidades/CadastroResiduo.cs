using GreenTech.Domain.Enuns;

namespace GreenTech.Domain.Entidades
{
    public class CadastroResiduo : BaseEntity
    {
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public TipoResiduoEnum TipoResiduo { get; set; }
        public long Quantidade { get; set; }
        public UnidadeMedidaEnum UnidadeMedida { get; set; }
    }
}
