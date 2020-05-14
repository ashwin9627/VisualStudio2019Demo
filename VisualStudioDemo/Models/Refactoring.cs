using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityFeatures
{
    class Refactoring
    {
        public void FixMyType()
        {
            int myint = 0;
            string mystring = "Hello, world!";
            double myfloat = 0.2;
            bool mybool = true;
            Console.WriteLine(myint.ToString(), mystring, myfloat, mybool);
        }

        public void WrapParameters(string a, string b, string c)
        {

        }

        // Click in the if statements and type (Ctrl + .) to invert them.
        public void InvertIfElse()
        {
            bool tru = true;
            //Bool expressions
            if (tru)
            {

                Console.WriteLine("Truth!");
            }
            else
            {
                Console.WriteLine("Falsehood!");
            }

            // Comparisons
            if (1 > 2)
            {
                Console.WriteLine("Change places!");
            }
            else
            {
                Console.WriteLine("Okay!");
            }

            // Multiple conditions
            if (0 == 0 && true || true)
            {
                Console.WriteLine("AlwaysTrue");
            }
            else
            {
                Console.WriteLine("Unreachable");
            }
        }

        // Multi-caret allows you to place multiple cursors in the file 
        // and edit them all at once.
        // Hold down (Ctrl + Alt) and click with the left mouse 
        // at the beginning of the strings below. Add the word "Hi"
        public void MultiCaret()
        {
            Console.WriteLine("dotnet Bot!");
            Console.WriteLine("Allison!");
            Console.WriteLine("Kendra!");
        }

        // Use a conditional expression to simplify your code.
        // Click inside the if statement and type (Ctrl + .)
        // to refactor the if else into a conditional expression.
        public bool ConditionalExpression(int two, string ang)
        {
            if (two % 0 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // You can now add a parameter to a method from a callsite.
        // This example involves the two methods below.
        // Uncomment the parameter in callMethodA and use the codefix (Ctrl + .) 
        // to add a string parameter to the MethodA signature.
        public void CallMethodA()
        {
            MethodA(0, "add this parameter");
        }
        public void MethodA(int zero, string v)
        {

        }

        // Place you cursor beside the grayed out parenthesis in the if statement.
        // Type (Ctrl + .) to remove the extra parenthesis.
        public void RemoveParenthesis()
        {
            if ((true) && !(2 > 1)) { }
        }

        // Place your cursor in the for loop statement.
        // Use (Ctrl + .) to convert it to a foreach loop.
        // Use (Ctrl + .) to convert it back into a for loop.
        public void ForLoopToForEach()
        {
            List<int> intList = new List<int>() { 1, 2, 3 };

            for (int i = 0; i < intList.Count; i++)
            {
                int num = intList[i];
                Console.WriteLine(intList[num]);
            }
        }
        // Place you cursor in the linq query of shortGreeting.
        // Type (Shift + Alt + plus symbol) to select only the linq query.
        // Type (Ctrl + .) to convert the linq query into a foreach loop.
        public void ForeachLoopToLinqQuery()
        {
            List<string> greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (string greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // Place cursor in foreach keyword and type (Ctrl + .)
        // Select 'Convert to Linq(call form)' to convert to a method
        public void ForeachLoopToLinqMethod()
        {
            List<string> greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (string greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }





        interface IAnimal
        {
            int legs { get; }

            void hello(string hi, string b);
        }

        interface IFood
        {
            
            void eatFood();
        }

        public class bannana : IFood
        {
            public bool eatHealthy => true;
            public void eatFood()
            {
                IList<string> newList = new List<string>();
                newList.Add("h");
                newList.Add("w");
                newList.Add("k");
                newList.Add("m");
                newList.Add("n");
                foreach(var ind in newList)
                {

                }
            }
        }

       
    }
    public interface IFood
    {
        string fName { get; set; }
        void interfaceImplement();
    }
    public class Eat : IFood
    {
        public string fName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void interfaceImplement()
        {
            throw new NotImplementedException();
        }

        public void interfaceImplement1()
        {
            throw new NotImplementedException();
        }
    }

    public interface animals
    {
       
        void cat();
        void horse();
    }
    public class animalclass : animals
    {
        public void cat()
        {
            throw new NotImplementedException();
        }

        public void horse()
        {

        }
    }
}
public class Employee : IEmployeeInterface
{
    public void EmployeeData()
    {
        throw new NotImplementedException();
    }

    public void EmployeeDetails()
    {
        throw new NotImplementedException();
    }
    public void EmployeeBioData()
    {

    }
}



public interface IEmployeeInterface
{
    void EmployeeBioData();
    void EmployeeData();
    void EmployeeDetails();
    
}

public interface IEmployee
{
    void empList();
    void empDtails();
    void empsimple();
}

public class Emp : IEmployee
{
    public void empDtails()
    {
        throw new NotImplementedException();
    }

    public void empList()
    {
        throw new NotImplementedException();
    }

    public void empsimple()
    {

    }
}