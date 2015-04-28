using System;

namespace TheCsprojLibrary
{
    internal static class TypeExtensions
    {
        public static Type GetUnderlyingType<T>()
        {
            Type type = typeof(T);

            if (type.IsGenericType &&
                type.GetGenericTypeDefinition() == typeof (Nullable<>))
            {
                return type.GetGenericArguments()[0];
            }

            return type;
        }
    }
}