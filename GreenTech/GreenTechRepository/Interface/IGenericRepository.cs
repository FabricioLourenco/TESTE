namespace GreenTech.Repository.Interface
{
    public interface IGenericRepository <T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        IQueryable<T> GetAll();
        T Salvar(T entity);
        void Remover(long id);
    }
}
