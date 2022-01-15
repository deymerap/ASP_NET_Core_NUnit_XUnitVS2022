using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    public interface ICliente
    {
        string NameClient { get; set; }
        int Discount { get; set; } 
        int OrderTotal { get; set; }
        bool IsPremium { get; set; }


    }

    public class Cliente
    {
        public string NameClient { get; set; }
        public int Discount { get; set; }
        public int OrderTotal { get; set; }
        public bool IsPremium { get; set; }

        public Cliente()
        {
            Discount = 10;
            IsPremium = false;
        }
        public string CreateFullName(string Name, string LastName)
        {

            if(string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("The name is not empty");
                
            Discount = 30;
            NameClient = $"{Name} {LastName}";
            return NameClient;
        } 
            
        public ClientType GetDeltailClient()
        {
            if (OrderTotal < 500)
                return new ClientBasic();
  
            return new ClientPremiun();

        }

    }


    public class ClientType { }
    public class ClientBasic : ClientType { }
    public class ClientPremiun : ClientType { }

}
