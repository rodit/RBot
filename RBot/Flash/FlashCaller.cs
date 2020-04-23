using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RBot.Flash
{
    public class FlashCaller
    {
        private FlashObject<object> _fobj;

        public bool DestroyOnCall { get; set; }

        public FlashCaller PushArgs(params IFlashObject[] objects)
        {
            FlashUtil.Call("fcPush", _fobj.ID, objects.Select(x => x.ID).ToArray());
            return this;
        }

        public FlashCaller PushArgs(params object[] objects)
        {
            FlashUtil.Call("fcPushDirect", new object[] { _fobj.ID }.Concat(objects).ToArray());
            return this;
        }

        public FlashCaller ClearArgs()
        {
            FlashUtil.Call("fcClear", _fobj.ID);
            return this;
        }

        public void Destroy()
        {
            _fobj.Destroy();
        }

        public FlashObject<T> CallFlash<T>()
        {
            FlashObject<T> obj = new FlashObject<T>(FlashUtil.Call<int>("fcCallFlash", _fobj.ID));
            if (DestroyOnCall)
                Destroy();
            return obj;
        }

        public string Call()
        {
            string result = FlashUtil.Call("fcCall", _fobj.ID);
            if (DestroyOnCall)
                Destroy();
            return result;
        }

        public T Call<T>()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(this.Call());
            }
            catch
            {
                return default;
            }
        }

        public static FlashCaller Create(IFlashObject obj, string func, bool destroyOnCall = true)
        {
            return new FlashCaller
            {
                _fobj = new FlashObject<object>(FlashUtil.Call<int>("fcCreate", obj.ID, func)),
                DestroyOnCall = destroyOnCall
            };
        }
    }
}
