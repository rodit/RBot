using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Flash
{
    [Serializable]
    public class ModuleBindingAttribute : LocationInterceptionAspect
    {
        public string ModuleName { get; set; }

        public ModuleBindingAttribute(string name)
        {
            ModuleName = name;
        }

        public override void OnSetValue(LocationInterceptionArgs args)
        {
            base.OnSetValue(args);
            FlashUtil.Call($"mod{((bool)args.Value ? "Enable" : "Disable")}", ModuleName);
        }
    }
}
