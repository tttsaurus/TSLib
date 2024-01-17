using System;
using System.Collections.Generic;

namespace TS.TSLib.Accessor
{
    public class AccessorDict<TValue>
    {
        public Dictionary<string, Func<TValue>> Getters = new Dictionary<string, Func<TValue>>();
        public Dictionary<string, Action<TValue>> Setters = new Dictionary<string, Action<TValue>>();

        public void Clear()
        {
            Getters.Clear();
            Setters.Clear();
        }
    }
    public class AccessorDict<TTarget, TValue>
    {
        public Dictionary<string, Func<TTarget, TValue>> Getters = new Dictionary<string, Func<TTarget, TValue>>();
        public Dictionary<string, Action<TTarget, TValue>> Setters = new Dictionary<string, Action<TTarget, TValue>>();

        public void Clear()
        {
            Getters.Clear();
            Setters.Clear();
        }
    }
}
