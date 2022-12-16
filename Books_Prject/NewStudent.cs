using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public class NewStudentNameException:Exception
    {
        public NewStudentNameException(string message):base(message)
        {

        }
    }
    public class StudDemo
    {
        private string name;
        public void AcceptName(string name)
        {
            if(name==null)
            {
                throw new NewStudentNameException("Name should not be null");
            }
            else if(name==" ")
            {
                throw new NewStudentNameException("Name is Reqired");
            }
            else
            {
                this.name = name;
                Console.WriteLine("Name of student is "+name);
            }
        }
    }
    public class NewClass
    {
        static void Main(string[] args)
        {
            StudDemo s = new StudDemo();

            try
            {
                s.AcceptName(" ");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
