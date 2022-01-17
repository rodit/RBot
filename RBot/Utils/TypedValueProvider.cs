using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Utils
{
    public interface ITypedValueProvider
    {
        object Provide(Type type);
    }

    [Serializable]
    public class DefaultTypedValueProvider : ITypedValueProvider
    {
        public object Provide(Type type)
        {
            try
            {
                return type == null || type == typeof(void) ? null : Activator.CreateInstance(type);
            }
            catch
            {
                return type.GetDefaultValue();
            }
        }
    }

    [Serializable]
    public class EmptyListProvider<T> : ITypedValueProvider
    {
        public object Provide(Type type)
        {
            return new List<T>();
        }
    }
}
