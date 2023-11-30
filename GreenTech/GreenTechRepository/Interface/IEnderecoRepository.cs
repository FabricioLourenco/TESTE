using GreenTech.Domain.Entidades;

namespace GreenTech.Repository.Interface
{
    public interface IEnderecoRepository
    {
        Endereco SalvarEndereco(Endereco endereco);
        Endereco BuscarEndereco(long id);
        List<Endereco> BuscarTodosEnderecos();
        bool RemoverEndereco(long id);
    }
}
