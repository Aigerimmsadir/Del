using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Globals
    {
        public static int k;
        public static string a ="9";
        public static string b ="8";
    }
    public delegate void Delegate();
    public class Method
    {
        public string a;
        public string b;
        public Method()
        {
           this.a =Globals.a; 
           this.b= Globals.b; 

        }
        public void Zadachka()
        {
            Globals.k = int.Parse(a) + int.Parse(b);
            Console.WriteLine(Globals.k);        
        }
    }
   public class Del
    {
        public Delegate invoker;
        public void Use()
        {
          
            Thread.Sleep(10000);
            invoker.Invoke();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Method method = new Method();
            Del del = new Del();
            
            del.invoker = method.Zadachka;
            del.Use();
        }
    }
}
