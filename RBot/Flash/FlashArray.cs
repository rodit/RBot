using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Flash
{
    public class FlashArray<T> : FlashObject<T[]>, IEnumerable<FlashObject<T>>
    {
        public FlashArray(int id) : base(id)
        {
        }

        public FlashObject<T> Get(int index)
        {
            return new FlashObject<T>(FlashUtil.Call<int>("lnkGetArray", ID, index));
        }

        public void Set(int index, T value)
        {
            FlashUtil.Call("lnkSetArray", ID, index, value);
        }

        IEnumerator<FlashObject<T>> IEnumerable<FlashObject<T>>.GetEnumerator()
        {
            return new FlashArrayEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FlashArrayEnumerator<T>(this);
        }

        private class FlashArrayEnumerator<S> : IEnumerator<FlashObject<S>>
        {
            private int _index;
            private FlashArray<S> _array;
            private FlashObject<int> _length;

            public FlashObject<S> Current { get; set; }
            object IEnumerator.Current => Current;

            public FlashArrayEnumerator(FlashArray<S> array)
            {
                _array = array;
                _length = _array.GetChild<int>("length");
            }

            public void Dispose()
            {
                Current?.Dispose();
                _length.Dispose();
            }

            public bool MoveNext()
            {
                int length = _length.Value;
                if (_index >= length)
                    return false;
                Current?.Dispose();
                Current = _array.Get(_index);
                _index++;
                return true;
            }

            public void Reset()
            {
                _index = 0;
                Current?.Dispose();
            }
        }
    }
}
