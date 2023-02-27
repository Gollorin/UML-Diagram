using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram
{
    public class Property
    {
        public string Attribute { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public Property(string att, string type, string name)
        { 
            this.Attribute = att;
            this.Type = type;
            this.Name = name;
        }

        public string GetMeShortString()
        {
            return GetMeShort(this.Attribute) + this.Name + " : " + this.Type;
        }

        public string GetMeFullString()
        {
            return this.Attribute + " " + this.Type + " " + this.Name;
        }

        private string GetMeShort(string shor)
        {
            if (shor == "Protected")
            {
                return "#";
            }
            else if (shor == "Private")
            {
                return "-";
            }
            else if (shor == "Public")
            {
                return "+";
            }
            else if (shor == "#")
            {
                return "Protected";
            }
            else if (shor == "-")
            {
                return "Private";
            }
            else if (shor == "+")
            {
                return "Public";
            }

            return "?";
        }
    }
}
