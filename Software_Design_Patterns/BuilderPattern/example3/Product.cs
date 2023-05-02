using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern.example3
{
    public class Product
    {
        public List<string> Parts;

        public Product()
        {
            Parts = new List<string>();
        }

        public void Add(String part) 
        {
            Parts.Add(part);
        }
        public String Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Product Components are:- ");
            foreach(String part in Parts) 
            {
                sb.AppendLine(part);
            }
            return sb.ToString();
        }

    }
}
