using System.Collections.Generic;
using UnityEngine;

namespace MiguelGameDev
{
    public static class ListExtensions
    {
        public static bool ContainsIndex<T>(this List<T> list, int index)
        {
            return index >= 0 && index < list.Count;
        }

        public static T GetRandom<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}