using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ObjectInitializer
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }

       
        public class Product
        {
            static void Main(string[] args)
            {
                ObjectInitializer[] arr = new ObjectInitializer[]
                {



                  new ObjectInitializer { Id = 1, Name = "mause", Price = 1200},
                  new ObjectInitializer { Id = 2, Name = "keyboard", Price = 15200 },
                  new ObjectInitializer { Id = 3, Name = "laptop", Price = 13200 },
                  new ObjectInitializer { Id = 4, Name = "mause pad", Price = 100 }
                     };
                foreach (ObjectInitializer a in arr)
                {
                    Console.WriteLine($"{a.Id}  {a.Name}  {a.Price}");
                }

                Console.WriteLine(".............................");
                foreach (ObjectInitializer b in arr)
                {
                    if(b.Price>2000)
                    {
                        Console.WriteLine($"{b.Id}  {b.Name}  {b.Price}");
                    }
                }
            }
        }
    }
}
