namespace GreenTech.Domain.Entidades
{
    public class Dados : BaseEntity 
    {
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string? Nome { get; set; }
        public string? CPFouCNPJ { get; set; }
        public string? Telefone { get; set; }
        public string? CNAE { get; set; }
    }
}
