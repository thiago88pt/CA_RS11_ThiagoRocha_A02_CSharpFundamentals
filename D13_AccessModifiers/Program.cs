using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            User user01 = new User();
           

            user01.UserWriteData();

            
        }
    }
}
