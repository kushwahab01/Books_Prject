using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class SwipNumber
    {
        public void SwipeNumber1(int[] a)
        {
           
            for(int i=0; i<a.Length-1; i++)
            {
               for(int j=i+1; j<a.Length; j++)
                {
                    if(a[j]==0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    
                }
            }
            
           
        }
        public void SwipeNumber2(int[] a)
        {
            for(int i=a.Length-1; i>=1; i--)
            {
                for(int j=i-1; j>=0; j--)
                {
                    if(a[j]==0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                   
                }
            }
           
        }

       
    }
}
