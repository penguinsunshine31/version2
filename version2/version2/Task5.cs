using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    public class Task5
    {

        class MyCollection<T>
        {
            private List<T> items = new List<T>();

            public void AddItem(T item)
            {
                items.Add(item);
            }

            public T GetItem(int index)
            {
                if (index >= 0 && index < items.Count)
                {
                    return items[index];
                }
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        public void task5()
        {
            MyCollection<string> myCollection = new MyCollection<string>();

            
            myCollection.AddItem("Item 1");
            myCollection.AddItem("Item 2");
            myCollection.AddItem("Item 3");

            
            string item1 = myCollection.GetItem(0);
            string item2 = myCollection.GetItem(1);
            string item3 = myCollection.GetItem(2);

            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Item 3: " + item3);








        }






















    }
}
