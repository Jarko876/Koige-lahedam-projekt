using System.Reflection;

namespace Abc.Aids
{
    public static class GetRandom
    {
        private static readonly Random random = Random.Shared;
        
        public static int Int32(int min = 0, int max = int.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return random.Next(min, max);
        }

        public static long Int64(long min = long.MinValue, long max = long.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return random.NextInt64(min, max);
        }

        public static double Double(double min = double.MinValue, double max = double.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return min + random.NextDouble() * (max - min);
        }

        public static sbyte Int8(sbyte min = sbyte.MinValue, sbyte max = sbyte.MaxValue)
        {
             return (sbyte) Int32(min, max);
        }

        public static short Int16(short min = short.MinValue, short max = short.MaxValue)
        {
            return (short)Int32(min, max);
        }

        public static byte UInt8(byte min = byte.MinValue, byte max = byte.MaxValue)
        {
            return (byte) Int32(min, max);
        }

        public static ulong UInt64(ulong min = ulong.MinValue, ulong max = ulong.MaxValue)
        {
            return (ulong)Double(min, max);
        }

        public static uint UInt32(uint min = uint.MinValue, uint max = uint.MaxValue)
        {
            return (uint) Int64(min, max);
        }

        public static ushort UInt16(ushort min = ushort.MinValue, ushort max = ushort.MaxValue)
        {
            return (ushort) Int32(min, max);
        }

        public static float Float(float min = float.MinValue, float max = float.MaxValue)
        {
            return (float) Double(min, max);
        }

        public static decimal Decimal(decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
           return (decimal) Double((double)min, (double)max);
        }

        public static string String(byte minLength = byte.MinValue , byte maxLength = byte.MaxValue, string chars = null)
        {
            var length = UInt8(minLength, maxLength);
            var s = new char[length];
            for (var i = 0; i < length; i++) s[i] = (chars is null) ? Char('a', 'z') 
                    : chars[UInt8(0, (byte)chars.Length)];
            return new string(s);
        }

        public static char Char(char min = char.MinValue, char max = char.MaxValue)
        {
           return (char) UInt16(min, max);
        }

        public static bool Bool()
        {
            return random.Next(2) == 0;
        }

        public static DateTime DateTime(DateTime? min = null, DateTime? max = null)
        {
            var minTicks = min?.Ticks ?? System.DateTime.MinValue.Ticks;
            var maxTicks = max?.Ticks ?? System.DateTime.MaxValue.Ticks;
            var ticks = Int64(minTicks, maxTicks);
            return new DateTime(ticks);
            
        }

        public static TimeSpan TimeSpan(TimeSpan? min = null, TimeSpan? max = null)
        {
            var minTicks = min?.Ticks ?? System.TimeSpan.MinValue.Ticks;
            var maxTicks = max?.Ticks ?? System.TimeSpan.MaxValue.Ticks;
            var ticks = Int64(minTicks, maxTicks);
            return new TimeSpan(ticks);
        }

        public static Guid Guid()
        {
            Span<byte> buffer = stackalloc byte[16];
            random.NextBytes(buffer);
            return new Guid(buffer);
        }

        public static object Object(Type type, string[] exclude = null)
        {
            exclude = exclude ?? [];
            var x = Nullable.GetUnderlyingType(type);
            if (x is not null)
            {
                type = x;
            }

            var o = Activator.CreateInstance(type);
            foreach (var p in type.GetProperties())
            {
                if (!p.CanWrite) continue;
                if (p.PropertyType.IsArray) continue;
                if (exclude.Contains(p.Name)) continue;
                
                var randomAttribute = p.GetCustomAttribute<RandomAttribute>();
                var v = randomAttribute is not null 
                    ? randomAttribute.CreateValue(p.PropertyType) 
                    : isClass(p) ? Object(p.PropertyType)
                    : Value(p.PropertyType);
                p.SetValue(o, v);
            }
            return o;
        }

        private static bool isClass(PropertyInfo p)
            => p.PropertyType.IsClass && p.PropertyType != typeof(string);

        public static object Value(Type type)
        {
            var x = Nullable.GetUnderlyingType(type);
            if (x is not null) type = x;
            if (type == typeof(string)) return String(0, 30);
            if (type == typeof(char)) return Char();
            if (type == typeof(bool)) return Bool();
            if (type == typeof(DateTime)) return DateTime();
            if (type == typeof(decimal)) return Decimal();
            if (type == typeof(double)) return Double();
            if (type == typeof(float)) return Float();
            if (type == typeof(byte)) return UInt8();
            if (type == typeof(ushort)) return UInt16();
            if (type == typeof(uint)) return UInt32();
            if (type == typeof(ulong)) return UInt64();
            if (type == typeof(sbyte)) return Int8();
            if (type == typeof(short)) return Int16();
            if (type == typeof(int)) return Int32();
            if (type == typeof(long)) return Int64();
            //if (type == typeof(TimeSpan)) return TimeSpan();
            //if (type == typeof(Guid)) return Guid();
            return null;
            //throw new NotSupportedException($"Type {type} is not supported.");
        }

    }
}
