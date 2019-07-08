using System;
using System.Collections.Generic;
using System.Text;

namespace Woordenboek
{
    public class Woordenboek<TKey, TValue>
    {
        public KeyValuePaar<TKey, TValue>[] Boek { get; set; }

        public Woordenboek()
        {
            Boek = new KeyValuePaar<TKey, TValue>[0];
        }

        public void Add(KeyValuePaar<TKey, TValue> paar)
        {
            KeyValuePaar<TKey, TValue>[] temp = new KeyValuePaar<TKey, TValue>[Boek.Length + 1];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = Boek[i];
            }
            temp[temp.Length - 1] = paar;
            Boek = temp;
        }
        public void Add(TKey key, TValue value)
        {
            Add(new KeyValuePaar<TKey, TValue>(key, value));
        }

        public TValue Get(TKey key)
        {
            if (Boek.Length > 0)
            {
                TValue result = default(TValue);
                for (int i = 0; i < Boek.Length; i++)
                {
                    if (Boek[i].Key.Equals(key))
                    {
                        result = Boek[i].Value;
                        break;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Woordenboek leeg");
            }          
        }

        public void Remove(TKey key)
        {
            KeyValuePaar<TKey, TValue>[] temp = new KeyValuePaar<TKey, TValue>[Boek.Length - 1];
            int a = 0;
            for (int i = 0; i <temp.Length + 1; i++)
            {
                if (!Boek[i].Key.Equals(key))
                {
                    temp[a] = Boek[i];
                    a++;
                }
            }
            Boek = temp;
        }

    }
}
