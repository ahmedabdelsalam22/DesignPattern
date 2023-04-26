using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Builder
{
    public interface IRobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotArmes();
        void BuildRobotLegs();
        void BuildRobotBody();
    }
}
