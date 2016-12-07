using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWindows.Model
{
    public class AfstudeerRichting
    {
        public string Naam;

        public string Beschrijving;

        public AfstudeerRichting(string naam , string beschrijving)
        {
            this.Naam = naam;
            this.Beschrijving = beschrijving;
        }


    }
}
