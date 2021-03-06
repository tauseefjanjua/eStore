﻿using System;
using System.Collections.Generic;

namespace eStore.Interfaces.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach(var item in list)
            {
                action(item);
            }
        }
    }
}
