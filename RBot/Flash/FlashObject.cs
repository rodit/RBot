using System;
using Newtonsoft.Json;

namespace RBot.Flash;

public class FlashObject<T> : IFlashObject, IDisposable
{
    public int ID { get; private set; }

    public T Value
    {
        get
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(FlashUtil.Call("lnkGetValue", ID));
            }
            catch
            {
                return default;
            }
        }
        set
        {
            FlashUtil.Call("lnkSetValue", ID, value);
        }
    }

    public FlashObject(int id)
    {
        ID = id;
    }

    public FlashObject<R> GetChild<R>(string path)
    {
        return new FlashObject<R>(FlashUtil.Call<int>("lnkGetChild", ID, path));
    }

    public void ClearChild(string path)
    {
        FlashUtil.Call("lnkDeleteChild", ID, path);
    }

    public FlashCaller CreateCaller(string func, bool destroyOnCall = true)
    {
        return FlashCaller.Create(this, func, destroyOnCall);
    }

    public void Dispose()
    {
        FlashUtil.Call("lnkDestroy", ID);
    }

    public FlashArray<T> ToArray()
    {
        return new FlashArray<T>(ID);
    }

    public static FlashObject<T> Create(string path)
    {
        return new FlashObject<T>(FlashUtil.Call<int>("lnkCreate", path));
    }
}
