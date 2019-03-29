using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalesFromUnexpected
{
    public static class ListExtensions
    {
        public static T PickRandom<T>(this List<T> enumerable)
        {
            int index = new Random().Next(0, enumerable.Count());
            return enumerable[index];
        }
    }
}
