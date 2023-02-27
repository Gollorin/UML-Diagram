using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram
{
    public class Method
    {
        public string Attribute { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Values { get; set; }


        public Method(string att, string val, string name, string type)
        { 
            this.Attribute = att;
            this.Values = val;
            this.Name = name;
            this.Type = type;
        }

        public string GetMeShortString()
        { 
            return GetMeShort(this.Attribute) + this.Name + "(" + this.Values + ")" + " : " + this.Type;
        }

        public string GetMeFullString()
        {
            return this.Attribute + " " + this.Type + " " + this.Name + $"({this.Values})";
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
