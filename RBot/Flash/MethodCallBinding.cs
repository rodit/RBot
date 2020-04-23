using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Newtonsoft.Json;

using PostSharp.Aspects;

using RBot.Utils;

namespace RBot.Flash
{
    [Serializable]
    public class MethodCallBindingAttribute : MethodInterceptionAspect
    {
        public string Name { get; set; }
        public bool RunMethodPre { get; set; } = false;
        public bool RunMethodPost { get; set; } = false;
        public bool GameFunction { get; set; } = false;
        public object DefaultValue { get; set; } = null;

        public MethodCallBindingAttribute(string name)
        {
            Name = name;
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            if (RunMethodPre)
                args.Proceed();
            if (GameFunction)
            {
                try
                {
                    args.ReturnValue = JsonConvert.DeserializeObject(ScriptInterface.Instance.CallGameFunction(Name, args.Arguments.ToArray()), (args.Method as MethodInfo).ReturnType);
                }
                catch
                {
                    args.ReturnValue = DefaultValue ?? (args.Method as MethodInfo).ReturnType.GetDefault();
                }
            }
            else
                args.ReturnValue = FlashUtil.Call(Name, (args.Method as MethodInfo).ReturnType, args.Arguments.ToArray());
            if (RunMethodPost && !RunMethodPre)
                args.Proceed();
        }
    }
}
