using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    using System;

    class Task1
    {
        public void task1()
        {
            int quantity = 8;
            string itemName = "Widget";

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Product: {itemName}, Index: {i}");

            }
        }
    }
}
