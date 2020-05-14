using System;

namespace ProductivityFeatures
{
    // Allow Extract Interface to remain in same file
    // Place cursor in class name and type (Ctrl R, Ctrl I)
    // In the dialog select destination as "Add to current file"
    public class ExtractInterfaceToSameFile
    {
        public bool A() => false;
        public string B() => String.Empty;

        #region code
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void method(int a, int b)
        {
            a = 0;
            b = 0;
            if (a == b)
            {

            }
        }
        #endregion

        public void fac()
        {
            int a = 1;
            double b = 1.345;
            string c = "hello";
        }
        public void data()
        {

        }

        public void data1()
        {

        }
    }
}
