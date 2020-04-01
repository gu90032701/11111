using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Extensions
{
    public static class ReflectionExtension
    {
        public static string GetPropertyValue<T>(this T items,string propertyName)
        {
            return items.GetType().GetProperty(propertyName).GetValue(items, null).ToString();
        }
    }
}
