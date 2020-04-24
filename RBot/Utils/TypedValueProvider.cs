using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Utils
{
    public interface TypedValueProvider
    {
        object Provide(Type type);
    }

    [Serializable]
    public class DefaultTypedValueProvider : TypedValueProvider
    {
        public object Provide(Type type)
        {
            try
            {
                return Activator.CreateInstance(type);
            }
            catch
            {
                return type.GetDefaultValue();
            }
        }
    }

    [Serializable]
    public class EmptyListProvider<T> : TypedValueProvider
    {
        public object Provide(Type type)
        {
            return new List<T>();
        }
    }
}
