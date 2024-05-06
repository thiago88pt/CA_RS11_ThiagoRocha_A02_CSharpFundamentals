/*
 * CLASS ELEMENTS:
        Attributes or fields    = variáveis privadas da classe (suporte às propriedades)
        Properties = caraterísticas
        Methods = funcionalidades
        Constructors = funcionalidade invocada aquando da criação do objeto
        Destructor              = funcionalidade que permite indicar como é que o objeto é destruído
    EXEMPLO
        Classe: Produto
        Objects(instâncias da classe): Produto1, Produto2, Produto3...
        Properties: Nome, Cor, Unidade, ...
        Methods: Inserir, Pesquisar, Editar, Apagar, ...
        Constructor: Cor = verde
        Destructor(log): informar que o objeto vai ser destruído
*/
using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Classes
{
    internal class Person
    {
        #region Fields (private)
        private string address, city, country;       // var interna da classe para utilização privada das propriedades 
       
        #endregion


        #region Propreties (public ou internal)

        #endregion


        #region Auto-implemented properties

        public int Id { get; set; }
        public string Name { get ; set; }
        public string NIF { get; set; }
        public string Phone { get; set; }
         
        #endregion

       
        #region Classic properties
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        
        public string City
        {
            get { return city; }     // ler o valor da propriedade
            set { city = value; }           // escrever o valor da propriedade
        }   


        #endregion


        #region Bodied-expression properties
        public string Country
        { 
            get => country;                 // => lambda operator
            set => country = value;
        }

        #endregion


        #region Constructors (public)
        // Substituto do default constructor
        public Person ()
        {
            Id = 0;
            Name = "";
            NIF = string.Empty;
            Phone = "";
            Address = "";
            City = "";
            Country = "";


        }

        public Person(int id, string name)
        { 
            Id= id;
            Name = name;    
        }

        public Person (int id, string name, string nif, string phone, string address, string city, string country)
        {
            Id = id;
            Name = name;
            NIF = nif;
            Phone = phone;
            Address = address;  
            City = city;    
            Country = country;  


        }

        #endregion


        #region Methods
        public void PersonWriteData()
        {

            Utility.WriteTitle("Person - list");
            Utility.WriteMessage($"Id: {Id}", "", "\n");
            Utility.WriteMessage($"\n\n\nName: {Name}", "", "\n");
            Utility.WriteMessage($"Nif: {NIF}", "", "\n");
            Utility.WriteMessage($"Phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Address: {Address}", "", "\n");
            Utility.WriteMessage($"City: {City}", "", "\n");
        }


    }
        #endregion


        #region Destructor

        #endregion



    
}
