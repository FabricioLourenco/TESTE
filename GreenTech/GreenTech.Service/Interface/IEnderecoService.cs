using GreenTech.Domain.Dtos;
using GreenTech.Domain.Entidades;

namespace GreenTech.Service.Interface
{
    public interface IEnderecoService
    {
        Endereco SalvarEndereco(EnderecoDto EnderecoDto);
        Endereco BuscarEndereco(long id);
        List<Endereco> BuscarTodosEndereco();
        bool RemoverEndereco(long id);
    }
}
