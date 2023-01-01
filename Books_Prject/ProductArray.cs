using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class ProductArray
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[] { 
            new Product{Pid=1, Pname="Moouse"},
            new Product{Pid=2, Pname="Keyboard"},
            new Product{Pid=3, Pname="Wire"},
            };

            foreach (Product item in products)
            {
                Console.WriteLine($"{item.Pid}  {item.Pname}");
            }
        }
        
        	

	}
    }

