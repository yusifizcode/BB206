namespace EFCore_Task.Abstractions
{
    public interface IService<T>
    {
        void Create(T entity);
        void Delete(int? id);
        void Update(int? id, T entity);
        List<T> GetAll();
        T GetById(int? id);
    }
}
