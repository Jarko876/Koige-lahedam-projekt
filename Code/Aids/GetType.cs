using System.Reflection;

namespace Abc.Aids
{
    public static class GetType
    {
        public static IEnumerable<PropertyInfo> Properties <TClass>(BindingFlags flags) 
            => typeof(TClass).GetProperties(flags);
        public static IEnumerable<string> PropertyNames<TClass>(BindingFlags flags) 
            => Properties<TClass>(flags).Select(p => p.Name);
        public static IEnumerable<MethodInfo> Methods<TClass>(BindingFlags flags, bool includeSpecialNames = false) 
            => Array.FindAll(typeof(TClass).GetMethods(flags), i => includeSpecialNames || !i.IsSpecialName);
        public static IEnumerable<string> MethodNames<TClass>(BindingFlags flags, bool includeSpecialNames = false) 
            => Methods<TClass>(flags, includeSpecialNames).Select(i => i.Name);
    }
}
