using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Projekt
{
    public class UmlMethod
    {
        public string Name { get; set; } // jmeno
        public string Type { get; set; } // datovy typ
        public string Visibility { get; set; } // public, private ...
        public UmlMethod(string name, string type, string visibility)
        {
            Name = name;
            Type = type;
            Visibility = visibility;
        }

        public override string ToString()
        {
            return $"{Visibility} {Name} : {Type}";
        }
    }
}
