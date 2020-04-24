using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Options
{
    public class Option<T> : IOption where T : IConvertible
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public object DefaultValue { get; set; }
        public bool Transient { get; set; }
        public Type Type
        {
            get
            {
                return typeof(T);
            }
        }

        /// <summary>
        /// Constructs an option definition with the given attributes.
        /// </summary>
        public Option(string name, string displayName, string description, T defaultValue = default, bool transient = false)
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            DefaultValue = defaultValue;
            Transient = transient;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
