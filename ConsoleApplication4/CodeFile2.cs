using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
public delegate string Assignments();

class Delegate
{
    public event Assignments assignment;
    public Delegate()
    {
        assignment = new Assignments(CheckForCompletion);
    }
    //delegate instance//
    public string CheckForCompletion()
    {
        string returnedAnswer = "no";
        while (returnedAnswer != "Yes")
        {
            returnedAnswer = Console.ReadLine();
        }
        return returnedAnswer;
    }


    static void Main(string[] args)
    {
        string userInput;
        Delegate testvariable = new Delegate();
        userInput = testvariable.assignment();
        Console.WriteLine("The user has entered {0}", userInput);
        Console.ReadKey();
    }
}
}


