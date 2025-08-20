namespace EasyAdmin.WebService.Template.Repository.Abstractions.Interfaces
{
    public interface IRepositoryBase<T>
    {
        public IEasyAdminContext EasyAdminContext { get; }
        int Add(T obj);
        List<T> Get();
        T? Get(int id);
        bool Update(T obj);
        bool Remove(int id);
    }
}
