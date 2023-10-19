using System;

/*Generic means the general form, not specific. 
 * In C#, generic means not specific to a particular data type.*/
namespace Generics
{
    class DataStore<T>  // Generic class
    {
        public T Data { get; set; } // Generic field
    }


    class DataPrint<T> : DataStore <T>
    {
        public void Print()
        {
            Console.WriteLine("Data: " + Data);
        }
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World";

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 23;

            DataPrint<int> intPrint = new DataPrint<int>();
            intPrint.Data = 24;
            intPrint.Print();

            /*KeyValuePair<int, string> kvp = new KeyValuePair<int, string>();
            kvp.Key = 100;
            kvp.Value = "Hundred";
            Console.WriteLine(kvp.Value);

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine(kvp2.Value);*/

            /*DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Hanoi");
            cities.AddOrUpdate(1, "Paris");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(cities.GetData(i));
            }*/
        }
    }

    /*class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if(index >=0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index) // Generic method
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }*/
}

/*Advantages of Generics
- Generics increase the reusability of the code.
- Generics are type-safe.
- Generic has a performance advantage because it removes the possibilities of boxing and unboxing.*/