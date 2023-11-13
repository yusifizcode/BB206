namespace EFCore_Task.Abstractions
{
    public interface IService<T>
    {
        void Create(T entity);
        void Delete(int id);

        List<T> GetAll();
        T GetById(int id);
    }
}
