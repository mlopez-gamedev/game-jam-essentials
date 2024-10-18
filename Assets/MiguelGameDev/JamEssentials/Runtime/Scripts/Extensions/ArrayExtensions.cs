using UnityEngine;

namespace MiguelGameDev
{
    public static class ArrayExtensions
    {
        public static bool ContainsIndex<T>(T[] array, int index)
        {
            return index >= 0 && index < array.Length;
        }

        public static bool Contains<T>(this T[] array, T element)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public static T GetRandom<T>(this T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }
    }
}