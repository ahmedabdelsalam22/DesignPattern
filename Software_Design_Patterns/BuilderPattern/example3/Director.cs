using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern.example3
{
    public class Director
    {
        IBuilder _builder;

        public void Consuruct(IBuilder builder) 
        {
            _builder = builder;
            _builder.StartUpOperations();
            _builder.BuildBody();
            _builder.InsertWheels();
            _builder.AddHeadLights();
            _builder.AddHeadLights();
        }

    }
}
