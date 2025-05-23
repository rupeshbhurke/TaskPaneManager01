using System;

namespace CommonUtilities.Extensions
{
    public static class ObjectExtension
    {
        public static void ToInt(this object o, out int val)
        {
            string valueString = o.ToString();
            val = string.IsNullOrWhiteSpace(valueString) ? 0 : int.Parse(o.ToString());
        }

        public static int ToInt(this object o)
        {
            string valueString = o.ToString();
            if (string.IsNullOrWhiteSpace(valueString))
                return 0;
            if (string.Compare(valueString, "True", StringComparison.OrdinalIgnoreCase) == 0)
                return 1;
            if (string.Compare(valueString, "False", StringComparison.OrdinalIgnoreCase) == 0)
                return 0;
            valueString = valueString.Replace(@",", @"");
            return int.Parse(valueString);
        }

        public static int CheckedToInt(this object o)
        {
            string valueString = o.ToString();
            if (string.IsNullOrWhiteSpace(valueString))
                return 0;
            valueString = valueString.Replace(@",", @"");
            return int.Parse(valueString);
        }

        public static void ToBool(this object o, out bool val)
        {
            val = false;
            if (o == null) return;
            try
            {
                val = Convert.ToBoolean(o);
                return;
            }
            catch
            {
                // ignored
            }

            string valueString = o.ToString();
            if (string.IsNullOrWhiteSpace(valueString)) return;
            if (string.Compare(valueString, "False", StringComparison.OrdinalIgnoreCase) == 0) return;
            if (String.CompareOrdinal(valueString, "0") == 0) return;
            if ((string.Compare(valueString, "True", StringComparison.OrdinalIgnoreCase) == 0) ||
                (String.CompareOrdinal(valueString, "1") == 0) || valueString.CheckedToInt() != 0)
                val = true;



        }

        public static bool ToBool(this object o)
        {
            bool b;
            o.ToBool(out b);
            return b;
        }


        public static decimal ToDecimal(this object o)
        {
            decimal val;
            try
            {
                val = Convert.ToDecimal(o);
            }
            catch (Exception)
            {
                val = default(decimal);
            }

            return val;
        }

        //public static decimal CheckedToDecimal(this object o)
        //{
        //    string valueString = o.ToString();
        //    if (string.IsNullOrWhiteSpace(valueString))
        //        return 0;
        //    valueString = valueString.Replace(@",", @"");
        //    return Convert.ToDecimal(valueString);
        //}

        public static float ToSingle(this object o)
        {
            string valueString = o.ToString();
            if (string.IsNullOrWhiteSpace(valueString))
                return 0;
            valueString = valueString.Replace(@",", @"");
            return Convert.ToSingle(valueString);
        }

        public static void ToSingle(this object o, out float val)
        {
            val = o.ToSingle();
        }

        public static DateTime ToDateTime(this object o)
        {
            string valueString = o.ToString();
            if (string.IsNullOrWhiteSpace(valueString))
                return DateTime.MinValue;
            return Convert.ToDateTime(valueString);
        }

        public static void ToDateTime(this object o, out DateTime val)
        {
            val = o.ToDateTime();
        }

        public static bool CanCastTo<T>(this object self, bool assert = false)
        {
            T t;
            try
            {
                t = (T)self;
            }
            catch (InvalidCastException)
            {
                if (assert) throw;
                return false;
            }
            return (t != null);
        }

        public static bool CastTo<T>(this object self, out T t, bool assert = false)
        {
            t = default(T);
            try
            {
                t = (T)self;
            }
            catch (InvalidCastException)
            {
                if (assert) throw;
                return false;
            }
            return (t != null);
        }
    }
}
