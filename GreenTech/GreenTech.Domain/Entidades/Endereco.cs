﻿namespace GreenTech.Domain.Entidades
{
    public class Endereco : BaseEntity
    {
        public long DadosId { get; set; }
        public Dados Dados { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Referencia { get; set; }
        public string? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}
