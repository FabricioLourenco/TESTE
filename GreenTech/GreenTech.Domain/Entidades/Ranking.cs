using GreenTech.Domain.Enuns;

namespace GreenTech.Domain.Entidades
{
    public class Ranking : BaseEntity
    {
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public CategoriaEnum Categoria { get; set; }
        public int Pontuacao { get; set; }
    }
}
