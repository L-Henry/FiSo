//
//
//
using Stringrev; //Gebruikt DynamischeLijst van Stringrev
using System;
using System.Collections.Generic;
using System.Text;

namespace Woordenboek
{
    public class Woordenboek2<TKey, TValue>
    {
        public DynamischeLijst<KeyValuePaar<TKey, TValue>> Boek { get; set; }

        public Woordenboek2()
        {
            Boek = new DynamischeLijst<KeyValuePaar<TKey, TValue>>();
        }

        public void Add(KeyValuePaar<TKey, TValue> paar)
        {
            Boek.Add(paar);
        }

        public void Add(TKey key, TValue value)
        {
            Boek.Add(new KeyValuePaar<TKey, TValue>(key, value));
        }

        public TValue Get(TKey key)
        {
            for (int i = 0; i < Boek.Count(); i++)
            {
                if (Boek.Get(i).Key.Equals(key))
                {
                    return Boek.Get(i).Value;
                }
            }
            throw new Exception("Geen resulaat.");
        }

        public void Remove(TKey key)
        {
            for (int i = 0; i < Boek.Count(); i++)
            {
                if (Boek.Get(i).Key.Equals(key))
                {
                    Boek.Remove(i);
                }
            }
        }
    }
}
