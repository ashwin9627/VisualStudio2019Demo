using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityFeatures
{
    class CodeCleanup
    {
        // Code Cleanup
        // If you'd like Code cleanup to include var and explicit type rules
        // check the option to apply implicit/explicit type preferences
        // in Analyze > Code Cleanup > Configure Code Cleanup.
        // Now press (Ctrl + k, Ctrl + e) to "fix" the types below.
        public void FixMyType()
        {
            int myint = 0;
            string mystring = "Hello, world!";
            double myfloat = 0.2;
            bool mybool = true;
            Console.WriteLine(myint.ToString(), mystring, myfloat, mybool);
        }

        // Right click on this project or the solution in Solution Explorer
        // Select Analyze and Code cleanup
        // Select 'Run Code Cleanup'
        // The spacing below and in all documents selected had code cleanup applied!
        void CodeCleanupProjectsAndSolution()
        {

        }
        public void UnUsedVariables()
        {
        }

        // Select the entire comment below
        // Type (Ctrl+Shift,/) to toggle the line comment
        // Type the same command again to toggle the comments back!
        void ToggleBlockComment()
        {
            /*string hi = "Hello, World!";*/
        }
    }
}
