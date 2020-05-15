using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityFeatures
{
    class Intellicode
    {

        public string IntelliCode()
        {
            string a = "";
            a.Replace("a", "b");
           
            
            
                
            // Uncomment the line below and place your cursor after "a."
            // Type Ctrl+space to open the intellisense call completion list.
            // Note that the first suggestions are no longer an alphabetical list,
            // but have ⭐ or "starred" suggestions. This star means the suggestions
            // have used AI to learn from your current coding context.

            //var b = a.
            

            // Note that Intellicode adapts to new code contexts.
            // Uncomment the variable declaration below and place your cursor after "a."
            // Type Ctrl+space to open the intellisense call completion list.
            // Now that a char array is expected the top intellisense completion is ToCharArray

            //char[] c = a.

            // IntelliCode can also recognize local code patterns.
            // Uncomment the variable declaration below and place your cursor after "a."
            // Type Ctrl+space to open the intellisense call completion list.
            // Since the lines direclty above a call repeat a pattern, IntelliCode
            // will suggest ToLower as the first call completion instead of Length.
            var d = a.ToLower();
            var e = a.ToLower();
            var f = a.ToLower();
           
            


            // var f = a.

            // IntelliCode can offer better completions on not only calls,
            // but arguments and parameters as well.
            // Is it also not limited to primitive types, 
            // but can even train to offer suggestions on your own code base.

            return a;
        }

        // IntelliCode can also provide automatically generated 
        // refactorings based off of the repeated edits that the user makes.
        // Suggested Edits can be turned on in 
        // Tools > Options > IntelliCode > Preview Fetaures > C# refactorings
        public void IntelliCodeRepeatedEditsRefactoring()
        {
            string data = IntelliCode();
            // Add .ToUpper() after all of the strings.
            // After the first 2 or 3 changes IntelliCode can pick up on what repeated edits
            // you are making and offer a codefix to complete them
            Console.WriteLine("hello");
            Console.WriteLine("goodbye");
            Console.WriteLine("hi");
            Console.WriteLine("so long");
            Console.WriteLine("greetings");
        }


        public void IntellicodeTest(string path)
        {
            List<string> testList = new List<string>();
            testList.Add("1");

            for(int i=0;i<=testList.Count;i++)
            {

            }

            IntelliCode();
            Console.WriteLine(path.Length);  
            
        }

        public void IntellicodeTest1(DateTime date)
        {
            IntelliCode();
            string d1 = DateTime.Now.ToString();
            

        }

        public void IntellicodeTest2()
        {
            List<string> testList = new List<string>();
            testList.Add("A");
            for(int i=0;i<=testList.Count;i++)
            {

            }
        }


        public class EmpInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class B
        {
            public void data(string info)
            {
                EmpInfo b1 = new EmpInfo();
                b1.FirstName = "Ashwin";
                b1.LastName = "Kumar";
                EmpInfo b2 = new EmpInfo();
                b2.FirstName = "Raj";
                b2.LastName = "Kumar";
                List<EmpInfo> NewList = new List<EmpInfo>();
                NewList.Add(b1);
                NewList.Add(b2);
                foreach (var ing in NewList)
                {

                }
                List<string> ListData = new List<string>();

            }
            public void data2(EmpInfo emp)
            {

            }

            public void data1()
            {
                string inso1 = "Ash";
                EmpInfo instance = new EmpInfo();
                this.data(inso1);
                var ind = new EmpInfo();   
            }

            public void data12()
            {
                string inso1 = "Ash";
                EmpInfo instance = new EmpInfo();
                this.data(inso1);
                var ind = new EmpInfo();
            }
        }
        //private int counter()
        //{
        //    string read= "dgfdfyhhkjhjhgrtretrgjhjgytrerwrtkhjhghtftyrf";
        //    int count = 0; 
        //}
    }
}