using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjectPool
{
    internal class objectPool<T> where T : new()
    {
        private List<T> objectList = new List<T>();

        private int counter = 0;
        private int maxObjects = 5;

        public int getObjectsNUmber()
        {
            return counter;
        }

        public T getObject()
        {
            T objectItem;
            if(counter > 0)
            {
                objectItem = objectList[0];
                objectList.RemoveAt(0);
                counter--;
                return objectItem;
            }
            else
            {
                T newObject = new T();
                return newObject;
            }
        }
    
        public void releaseObject(T item)
        {
            if(counter < maxObjects)
            {
                objectList.Add(item);
                counter++;
            }
        }


    
    
    
    
    
    
    
    
    }
}
