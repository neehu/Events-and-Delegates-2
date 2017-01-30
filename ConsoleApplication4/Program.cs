using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    
    class Program
    {
        delegate string Assignments(string answer);
        public string Check(string x)
        {
            string ans="no";
            while(ans !="Yes")
            {
                Console.ReadLine();
            }
            return "yes";
        }
        static void Main(string[] args)
        {
            Assignments num1 = new Assignments(Check());
            num1("yes");
        }
    }
}
