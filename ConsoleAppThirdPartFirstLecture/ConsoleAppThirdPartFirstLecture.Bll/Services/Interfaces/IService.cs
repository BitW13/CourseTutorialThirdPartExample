using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetItemById(int id);

        T Create(T item);

        void Update(int id, T item);

        bool Delete(T item);
    }
}
