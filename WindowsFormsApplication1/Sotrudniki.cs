using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class Sotrudniki
    {
  
        public String Name { get; set; }
        public String Familia { get; set; }
        public String Otchestvo { get; set; }
        public String Phone { get; set; }
      
        public Sotrudniki ( string name, string fam, string otch, string phone)
        {
            
            Name = name;
            Familia = fam;      
            Otchestvo = otch;
            Phone = phone;
           

        }

    }
    
}
