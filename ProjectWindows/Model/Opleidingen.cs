using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWindows.Model
{
    public class Opleidingen
    {
        public string Name { get; set; }
    
        public string Type { get; set; }
        public string Description { get; set; }
        public List<AfstudeerRichting> AfstudeerRichtingen; 


        public Opleidingen(string name , string type , string description)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;


        }

        

       





    }
}
