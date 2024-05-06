using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;
namespace D13_AccessModifiers
{
   

    internal class User
    {

        bool dataCorreta = false;
       

        #region Fields
        private DateTime registrationDate;       

        #endregion

        #region Auto-implemented properties

        public int Id { get; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        #endregion


        #region Classic properties
        internal DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
        #endregion


        #region Constructors 
        
        internal User()
        {   
            Id = 1;
            Name = "";
            Department = "";
            RegistrationDate = DateTime.Today;
            Username = "";
            Password = "";
        }
        internal User(int id, string name, string department, DateTime registrationDate, string username, string password)
        {
            Id = id;
            Name = name;
            Department = department;
            RegistrationDate = DateTime.Today;
            Username = username;
            Password = password;
        }

    
        #endregion

        
        #region Methods
        public void UserWriteData()
        {

            Utility.WriteTitle("Creating user") ;

            Utility.WriteMessage($"\nId: {Id}", "", ""); //vai ser readonly
            
            Utility.WriteMessage($"\nName: {Name}", "", "");
            Name = Console.ReadLine();
            Utility.WriteMessage($"\nDepartment: {Department}", "", "");
            Department =  Console.ReadLine();

            Utility.WriteMessage($"\nRegistration Date: {RegistrationDate}", "", ""); // date apenas data
            while (!dataCorreta)
            {
                Utility.WriteMessage("\nInforme uma data: ", "", "");
                string intDate = Console.ReadLine();

                if (DateTime.TryParse(intDate, out registrationDate))
                {
                    dataCorreta = true; 
                }
                else
                {
                    Utility.WriteMessage("\nData informada no formato incorreto. Por favor, tente novamente no formato MM/DD/AAAA.", "");
                }
            }

            Utility.WriteMessage($"\nRegistration Date: {registrationDate.ToShortDateString()}", "", "");

            Utility.WriteMessage($"Username: {Username}", "", "");
            Username = Console.ReadLine();

            Utility.WriteMessage($"\nPassword: {Password}", "", "");
            Password = Console.ReadLine();

            Utility.PauseConsole();
        }
            #endregion


    }

}

