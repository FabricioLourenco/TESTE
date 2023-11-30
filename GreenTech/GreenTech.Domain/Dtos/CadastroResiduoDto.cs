using GreenTech.Domain.Enuns;

namespace GreenTech.Domain.Dtos
{
    public class CadastroResiduoDto
    {
        public TipoResiduoEnum TipoResiduo { get; set; }
        public long Quantidade { get; set; }
        public UnidadeMedidaEnum UnidadeMedida { get; set; }
    }
}
