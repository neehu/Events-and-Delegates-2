using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public delegate string Assignments();
    class Delegate
    {
        public event Assignments test;
        public Delegate()
        {
            test = new Assignments(Check);
        }
        //delegate instance//
        public string Check()
        {
            string ans = "no";
            while (ans != "Yes")
            {
                ans = Console.ReadLine();
            }
            return ans;
        }


        static void Main(string[] args)
        {
            string ans;
            Delegate test1 = new Delegate();
            ans = test1.test();
            Console.WriteLine("The user has entered {0}", ans);
            Console.ReadKey();
        }
    }
}


