using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class ArrayMap<K,V>:IMap<K,V>
    {
        public int Current { get; set; }
        public bool IsEmpty
        {
            get
            {
                if(Current == 0)
                {
                    return true;
                }
                return false;
            }
        }
        K[] keys = null;
        V[] values= null;

        public ArrayMap(int maxSize) //Counstructor
        {
            Current = 0;
            keys = new K[maxSize];
            values = new V[maxSize];
        }

        void IMap<K, V>.Put(K key, V value) //Method 1
        {
            keys[Current] = key;
            values[Current] = value;
            Current++;
        }

        void IMap<K, V>.Clear() //Method 1
        {
            for(int i = Current; i ==0; i--)
            keys[i] = default(K);
            values[i] = default(V);
            Current--;
        }
        bool IMap<K, V>.ContainsKey(K key) //Method 2
        {
            for(int i=0; i<Current; i++)
            {
                if(keys[i].Equals(key))
                {
                    return true;
                }
            }
            return false;
        }
        bool IMap<K, V>.ContainsValue(V value) //Method 3
        {
            for (int i = 0; i < Current; i++)
            {
                if (values[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        void IMap<K, V>.Remove(K key)
        {
            for (int i=0; i<Current; i++)
            {
                if (keys[i].Equals(key))
                {
                    for (int j = i; j < Current; j++)
                    {
                        if(i==Current)
                        {
                            keys[j] = default(K);
                            values[j] = default(V);
                            Current--;
                        }
                        else
                        {
                            keys[j] = keys[j + 1];
                            values[j] = values[j + 1];
                        }
                    }
                }
            }
        }
    }
}
