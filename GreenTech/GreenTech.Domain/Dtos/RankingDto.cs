using GreenTech.Domain.Enuns;

namespace GreenTech.Domain.Dtos
{
    public class RankingDto
    {
        public CategoriaEnum Categoria { get; set; }
        public int Pontuacao { get; set; }
    }
}
