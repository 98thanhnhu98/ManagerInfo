using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    internal class Program
    {
        static void Main(string[] cmd)
        {
            try
            {
                Console.WriteLine("Input :...............");
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();

                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Number:");
                string phone = Console.ReadLine();

                Console.WriteLine("Enter Date of birth (mm/dd/yyyy):  ");
                DateTime dateOfBarth = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Joining Date (mm/dd/yyyy):");
                string id = Console.ReadLine();

                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
            }
        }
    }
}
