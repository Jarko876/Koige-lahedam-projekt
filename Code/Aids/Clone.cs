using System.Reflection;

namespace Abc.Aids
{
    public static class Clone
    {
        public static TClass Object<TClass>(TClass obj)
            where TClass : class, new() => (TClass)clone(obj);

        private const BindingFlags publicInstance = BindingFlags.Public | BindingFlags.Instance;
        private static object clone(object obj)
        {
            if (obj == null) return null;
            var type = obj.GetType();
            var o = Activator.CreateInstance(type);
            var properties = type.GetProperties(publicInstance);
            copy(obj, o, properties);
            return o;

        }

        private static void copy(object from, object to, PropertyInfo[] properties)
        {
            foreach (var property in properties)
            {
                if (!property.CanRead || !property.CanWrite) continue;
                var value = property.GetValue(from);
                if (value != null && isClass(property))
                {
                  value = clone(value);
                }
                property.SetValue(to, value);
            }
        }

        private static bool isClass(PropertyInfo property)
            => property.PropertyType.IsClass && property.PropertyType != typeof(string);

    }
}
