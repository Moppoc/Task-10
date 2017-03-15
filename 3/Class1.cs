using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public interface IMap<K,V>
    {
        void Put(K key, V value);
        void Clear();
        bool ContainsKey(K key);
        bool ContainsValue(V value);
        void Remove(K key);

        int Count { get; set; }
        bool IsEmpty{ get; set; }
        V this[K key] { get;  set; }
        IEnumerable<K> Keys { get; set; }
        IEnumerable<V> Value { get; set; }


    }
}
