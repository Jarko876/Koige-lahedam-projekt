using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Aids
{
    public static class TypeExtension
    {
        public static bool IsBool(this Type type)
        {
            return toUnderlying(type) == typeof(bool);
        }

        private static Type toUnderlying(Type type)
        {
            if (type is null) return null;
            return Nullable.GetUnderlyingType(type) ?? type;
        }

        public static bool IsDate(this Type type)
        {
            return toUnderlying(type) == typeof(DateTime) || toUnderlying(type) == typeof(DateOnly);
        }

        public static bool IsString(this Type type)
        {
            if (type is null) return false;
            return type == typeof(string);
        }

        public static bool IsNumeric(this Type type)
        {
            type = toUnderlying(type);

            return type == typeof(byte) || type == typeof(sbyte) ||
                   type == typeof(short) || type == typeof(ushort) ||
                   type == typeof(int) || type == typeof(uint) ||
                   type == typeof(long) || type == typeof(ulong) ||
                   type == typeof(float) || type == typeof(double) ||
                   type == typeof(decimal);
        }


    }
}
