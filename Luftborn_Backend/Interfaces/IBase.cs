namespace Luftborn.Interfaces
{
    public interface IBase<T> where T : class
    {
        T GetByID(int Id);
        List<T> getAll();
        T AddOne(T obj);
        T find(Expression<Func<T, bool>> match, string[] Includes = null);
        IEnumerable<T> findAll(Expression<Func<T, bool>> match, string[] Includes = null);
        //IEnumerable<T> findAllOrdered(Expression<Func<T, bool>> match, int? skip, int? take, Expression<Func<T, object>> order, string[] Includes = null);
        T Update(T entity);
        void Delete(T entity);
        T Attach(T entity);
        int Count(Expression<Func<T, bool>> match);
    }
}
