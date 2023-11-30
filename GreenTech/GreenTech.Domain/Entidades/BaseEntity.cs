using System.ComponentModel.DataAnnotations;

namespace GreenTech.Domain.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
