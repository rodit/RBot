using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Options
{
    public interface IOption
    {
        string Category { get; set; }
        string Name { get; }
        string DisplayName { get; }
        string Description { get; }
        object DefaultValue { get; }
        bool Transient { get; }
        Type Type { get; }
    }
}
