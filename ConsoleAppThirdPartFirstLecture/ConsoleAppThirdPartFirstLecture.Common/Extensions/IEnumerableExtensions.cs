using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppThirdPartFirstLecture.Common.Extensions
{
    public static class IEnumerableExtensions
    {
        public static int GetNextId<T>(this IEnumerable<T> collection)
        {
            var id = collection.Count();

            return ++id;
        }
    }
}
