using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public enum TypeOfProduct { Furniture, Mobile, Cloths}
    class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public TypeOfProduct TypeOfProduct;
        public List<Features> f = new List<Features>();
    }
    public class Features
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductDetails
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>()
            {
                new Product
                {
                    Pid=11,
                    Pname="Furniture",
                    TypeOfProduct=TypeOfProduct.Furniture,
                    f=
                    {
                        new Features{Id=101, Name="table"},
                        new Features{Id=102, Name="Chair"},
                        new Features{Id=103, Name="Cupboard"},
                    }

                },
                new Product
                {
                    Pid=22,
                    Pname="Phone",
                    TypeOfProduct=TypeOfProduct.Mobile,
                    f=
                    {
                        new Features{Id=104, Name="Samsung"},
                        new Features{Id=105, Name="Nokia"},
                        new Features{Id=106, Name="Apple"},
                    }
                },
                new Product
                {
                    Pid=33,
                    Pname="Cloths",
                    TypeOfProduct= TypeOfProduct.Cloths,
                    f=
                    {
                        new Features{Id=107, Name="Tshirt's"},
                        new Features{Id=108, Name="Pant's"},
                        new Features{Id=109, Name="Jacket's"},
                        new Features{Id=109, Name="Shirt's"},
                    }
                }
            };
            foreach (Product item in p)
            {
                Console.WriteLine($"Product Id is :{item.Pid}, Product Name is:{item.Pname}");
                foreach (Features s in item.f)
                {
                    Console.WriteLine("\t"+s.Name);
                }
            }
        }
    }

}
