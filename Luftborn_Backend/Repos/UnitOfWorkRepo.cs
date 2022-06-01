namespace Luftborn.Repos
{
    public class UnitOfWorkRepo : IUnitOfWork
    {

        private readonly APPContext _db;

        public IBase<Department> Departments { get; private set; }
        public UnitOfWorkRepo(APPContext db)
        {
            _db = db;
            Departments = new BaseRepo<Department>(_db);
        }
        public int complete()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        { _db.Dispose(); }
        
    }
}
