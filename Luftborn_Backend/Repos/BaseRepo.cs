namespace Luftborn.Repos
{
    public class BaseRepo<T> : IBase<T> where T : class
    {
        private APPContext _db;
        public BaseRepo(APPContext db)
        {
            _db = db;
        }
        public T find(Expression<Func<T, bool>> match, string[] Includes = null)
        {
            IQueryable<T> query = _db.Set<T>();
            if (Includes != null)
                foreach (var item in Includes)
                    query = query.Include(item);
            return query.FirstOrDefault(match);
        }
        public IEnumerable<T> findAll(Expression<Func<T, bool>> match, string[] Includes = null)
        {
            IQueryable<T> query = _db.Set<T>();
            if (Includes != null)
                foreach (var item in Includes)
                    query = query.Include(item);
            return query.Where(match).ToList();
        }

        public  List<T> getAll()
        {
            return  _db.Set<T>().ToList();
        }

        public T GetByID(int Id)
        {
            return _db.Set<T>().Find(Id);
        }



        public T AddOne(T obj)
        {
            _db.Set<T>().Add(obj);
            return obj;
        }
        public T Update(T entity)
        {
            _db.Update(entity);
            return entity;
        }
        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

       
        public T Attach(T entity)
        {
            _db.Set<T>().Attach(entity);
            return entity;
        }

        public int Count(Expression<Func<T, bool>> match)
        {
            return _db.Set<T>().Count(match);
        }
   
    }
}
