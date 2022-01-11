using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    public class Cliente
    {
        public string NameClient { get; set; }
        public int Discount { get; set; } = 10;
        public string CreateFullName(string Name, string LastName)
        {

            if(string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("The name is not empty");
                
            Discount = 30;
            NameClient = $"{Name} {LastName}";
            return NameClient;
        } 
            


    }
}
