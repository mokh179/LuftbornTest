namespace Luftborn.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IBase<Department> Departments { get; }
        int complete ();
    }
}
