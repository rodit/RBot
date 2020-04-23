using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PostSharp.Aspects;

using RBot.Utils;

namespace RBot.Flash
{
    [Serializable]
    public class CallBindingAttribute : LocationInterceptionAspect
    {
        public string Name { get; set; }
        public bool UseValue { get; set; } = true;
        public bool Get { get; set; } = true;
        public bool Set { get; set; } = true;
        public Type ConvertType { get; set; } = null;

        public CallBindingAttribute(string name)
        {
            Name = name;
        }

        public override void OnGetValue(LocationInterceptionArgs args)
        {
            base.OnGetValue(args);
            if (Get)
            {
                if (ConvertType == null)
                    ConvertType = args.Location.LocationType;
                try
                {
                    args.Value = FlashUtil.Call(Name, ConvertType);
                }
                catch
                {
                    args.Value = ConvertType.GetDefault();
                }
            }
        }

        public override void OnSetValue(LocationInterceptionArgs args)
        {
            base.OnSetValue(args);
            if (Set)
            {
                try
                {
                    if (UseValue)
                        FlashUtil.Call(Name, args.Value);
                    else
                        FlashUtil.Call(Name);
                }
                catch
                {

                }
            }
        }
    }
}
