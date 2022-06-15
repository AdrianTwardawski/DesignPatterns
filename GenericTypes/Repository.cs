using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class Repository<T> where T : IEntity, new() //ograniczenie na parametr generyczny T,
                                                        //aby to były typy, które implementują interfejs IEntity,
                                                        //oraz musi mieć bezparametrowy konstuktor
    //public class Repository<T> where T : class //ograniczenie na parametr generyczny T, który musi być typem referencyjnym
    {
        public List<T> data = new List<T>();

        public void AddElement(T element)
        {
            var newElement = new T();
            newElement.Id = 23;

            if(element != null)
            {
                data.Add(element);       
            }
        }

        public T GetElementById(int id)
        {
            var element = data.FirstOrDefault(e => e.Id == id);
            return element;
        }


        //pobranie elementu z konkretnego indeksu
        public T GetElement(int index)
        {
            if (index < data.Count)
            {
                return data[index];
            }
            else
            {
                //throw new IndexOutOfRangeException();
                //return default(T);
                return default;
            }
        }
    }


    // class with two generic parameters
    public class Repository<TKey, TValue>
        where TKey : class
        where TValue : new()
    {
        public Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

        public void AddElement(TKey key, TValue value)
        {
            if (key != null && value != null)
            {
                data.Add(key, value);
            }
        }

   
        public TValue GetElement(TKey key)
        {
            if (data.TryGetValue(key, out TValue result))
            {
                return result;
            }
            else
            {
                return default;
            }
        }
    }
}
