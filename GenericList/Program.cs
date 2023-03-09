using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<String> sehirler = new MyList<String>();
            sehirler.Add("erzurum");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);
            Console.WriteLine(sehirler.ToString());
            Console.ReadLine();
        }
    }


    public class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length +1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;

        }

        public string ToString()
        {
            string str = "";
            for (int i = 0; i < _array.Length; i++)
            {
                str += _array[i] + "  ";
            }
            return str;
        }

      

        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}
