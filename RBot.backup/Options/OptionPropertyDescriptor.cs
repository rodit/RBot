using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace RBot.Options
{
    internal class OptionPropertyDescriptor : PropertyDescriptor
    {
        private OptionContainer _container;

        private IOption _key;

        internal OptionPropertyDescriptor(OptionContainer c, IOption key) : base(key.ToString(), null)
        {
            _container = c;
            _key = key;
        }

        public override string Category => _key.Category.Replace('_', ' ');

        public override string Description => _key.Description;

        public override Type PropertyType => _key.Type;

        public override void SetValue(object component, object value)
        {
            _container.Set(_key, value);
        }

        public override object GetValue(object component)
        {
            return typeof(OptionContainer).GetMethod("Get", new Type[] { typeof(IOption) })
                .MakeGenericMethod(new Type[] { _key.Type })
                .Invoke(_container, new object[] { _key });
        }

        public override bool IsReadOnly { get; } = false;

        public override Type ComponentType { get; } = null;

        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override void ResetValue(object component)
        {
            _container.Set(_key, _key.DefaultValue.ToString());
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
