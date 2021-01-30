using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetItemById(int id);

        T Create(T item);

        void Update(int id, T item);

        bool Delete(T item);
    }
}
