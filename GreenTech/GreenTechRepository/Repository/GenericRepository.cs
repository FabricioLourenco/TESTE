using GreenTech.Domain.Entidades;
using GreenTech.Repository.Context;
using GreenTech.Repository.Interface;

namespace GreenTech.Repository.Repository
{
    public class GenericRepository <T> : IGenericRepository<T> where T : BaseEntity
    {
        private GreenTechContext _context;

        public GenericRepository(GreenTechContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T Salvar(T entity)
        {
            if ((entity as BaseEntity).Id == 0)
                Add(entity);
            else
                Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Remover(long id)
        {
            var entidade = _context.Set<T>().First(c => c.Id == id);
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }
    }
}
