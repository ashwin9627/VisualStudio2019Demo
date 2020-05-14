using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityFeatures
{
    public class Debugging
    {
        public static void debug()
        {

            IList<string> newList = new List<string>();
            newList.Add("a");
            newList.Add("b");
            newList.Add("c");
            newList.Add("d");
            newList.Add("e");

            foreach (var ind in newList)
            {

            }
        }
        public static string add(EmployeeInfo a)
        {
            return "";
        }
        public static string add1(EmployeeInfo a)
        {
            return "";
        }

        #region code


        public static void debug2()
        {
            //   throw new Exception();
            EmployeeInfo emp = new EmployeeInfo();

            EmployeeInfo e1 = new EmployeeInfo();
            e1.FirstName = "Ashwin";
            e1.LastName = "Kumar";
            EmployeeInfo e10 = new EmployeeInfo();
            e10.FirstName = "aaa";
            e10.LastName = "bbb";


            EmployeeInfo e7 = new EmployeeInfo();
            e7.FirstName = "Vidya";
            e7.LastName = "Sagar";

            EmployeeInfo e8 = new EmployeeInfo();
            e8.FirstName = "Raj";
            e8.LastName = "kumar";

            EmployeeInfo e2 = new EmployeeInfo();
            e2.FirstName = "Raj";
            e2.LastName = "Kumar";
            EmployeeInfo e3 = new EmployeeInfo();
            e3.FirstName = "Daniel";
            e3.LastName = "Raj";
            EmployeeInfo e4 = new EmployeeInfo();
            e4.FirstName = "Abdul";
            e4.LastName = "Kumar";
            EmployeeInfo e5 = new EmployeeInfo();
            e5.FirstName = "saran";
            e5.LastName = "raj";
            EmployeeInfo e33 = new EmployeeInfo();
            e33.FirstName = "sam";
            e33.LastName = "";

            var JsonData = JsonConvert.SerializeObject(e33);
            var JsonDeserialize = JsonConvert.DeserializeObject(JsonData);

            List<EmployeeInfo> EmpList = new List<EmployeeInfo>();
            EmpList.Add(e1);
            EmpList.Add(e2);
            EmpList.Add(e3);
            EmpList.Add(e4);
            EmpList.Add(e5);

            foreach (var ind1 in EmpList)
            {
                Console.WriteLine("First Name of Employee is" + ind1.FirstName + "\t Last Name of Employee is" + ind1.LastName);
            }

        }
    }
    #endregion

    public class EmployeeInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
