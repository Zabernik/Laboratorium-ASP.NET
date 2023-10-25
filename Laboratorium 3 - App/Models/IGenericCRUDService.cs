namespace Laboratorium_3___App.Models
{
    public interface IGenericCRUDService<T, Key>
    {
        void Add(T entity);
        void DeleteById(T entity);
        void Update(T entity);
        List<T> FindAll();
        T? FindById(Key id);
    }
}
