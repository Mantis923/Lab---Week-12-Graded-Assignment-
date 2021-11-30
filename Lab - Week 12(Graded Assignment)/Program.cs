using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// File Name: Lab - Week 12(Graded Assignment)
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola



namespace LabWeek12GradedAssignment
{
    class Program
    {
        /// <summary>
        /// Create a phone lookup program. You should have the ability to add, 
        /// delete, and find phones number. The key will be a person’s name, 
        /// for the example use just a first name and this will retrieve a person’s phone number. 
        /// Use the Dictionary Collection
        /// </summary>
        /// 
        private static Dictionary<string, string> dict;
       
        private static void Add(string strKey, string dataType)
        {
            dict[strKey] = dataType;
        }

        private static string GetPhoneNumber(string strKey)
        {
           dict.TryGetValue(strKey, out string phoneNumber);
           
            return phoneNumber;
        }

        public static void DeleteNumber( string keyName)
        {
            dict.Remove(keyName);
        }
        static void Main(string[] args)
        {
            dict = new Dictionary<string, string>();

            Add("Samuel", "916-596-7711");
            Console.WriteLine("Samuel = " + GetPhoneNumber("Samuel"));
            DeleteNumber("Samuel");
            Console.WriteLine("Samuel = " + GetPhoneNumber("Samuel"));

            Console.ReadLine();
        }
    }
}
