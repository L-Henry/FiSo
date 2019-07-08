using System;
using System.Collections.Generic;
using System.Text;

namespace Stringrev
{
    public class DynamischeLijst<TLijst>
    {
        private TLijst[] _lijst;

        public DynamischeLijst(params TLijst[] lijst)
        {
            _lijst = lijst;
        }

        public DynamischeLijst()
        {
            _lijst = new TLijst[0];
        }

        public void Add(TLijst value)
        {
            TLijst[] temp = new TLijst[_lijst.Length + 1];
            for (int i = 0; i < _lijst.Length; i++)
            {
                temp[i] = _lijst[i];
            }
            temp[temp.Length - 1] = value;
            _lijst = temp;
        }

        public void Add(int index, TLijst value)
        {
            TLijst[] temp = new TLijst[_lijst.Length + 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = _lijst[i];
            }
            temp[index] = value;
            for (int i = index + 1; i < temp.Length; i++)
            {
                temp[i] = _lijst[i - 1];
            }
            _lijst = temp;
        }

        public void Remove(int index)
        {
            TLijst[] temp = new TLijst[_lijst.Length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = _lijst[i];
            }
            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = _lijst[i + 1];
            }
            _lijst = temp;
        }

        public TLijst Get(int index)
        {
            if (index >= _lijst.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return _lijst[index];
        }

        public int Count()
        {
            return _lijst.Length;
        }

        public void Reverse()
        {
            TLijst[] temp = new TLijst[_lijst.Length];
            for (int i = 0; i < _lijst.Length; i++)
            {
                temp[i] = _lijst[_lijst.Length - 1 - i];
            }
            _lijst = temp;
        }


    }
}
