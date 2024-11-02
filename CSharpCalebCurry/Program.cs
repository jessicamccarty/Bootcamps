using System; 

namespace CSharpCalebCurry // a namespace - used for organization
{
    class Program // a class - has members (such as a method)
    {
        static void Main(string[] args) // a method -- contains a block of code
                                        // starting method is named static Main. called directly when program is executed
        { 
            // System.Console.WriteLine(); // fully qualified name, using System; at top allows you to use shortened 
                Program myProgram = new Program();
                myProgram.Print();
        }
        
        void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Hello World!"); // Statement that tells the computer what to do.
            Console.WriteLine("Best friend!"); // StatementConsole.WriteLine("Hello World!")
        }

    }
}



// namespace > classes > members > method > statements

// create the method
// invoke the method (not necessary in the main method)


