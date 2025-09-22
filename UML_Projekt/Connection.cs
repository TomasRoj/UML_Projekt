using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Projekt
{
    public class Connection
    {
        public UmlClass From { get; set; }
        public UmlClass To { get; set; }
        public string ConType { get; set; } 

    }
}
