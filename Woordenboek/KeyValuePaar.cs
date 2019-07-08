using System;
using System.Collections.Generic;
using System.Text;

namespace Woordenboek
{
    public class KeyValuePaar<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValuePaar(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

    }
}
