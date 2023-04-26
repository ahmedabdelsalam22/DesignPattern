using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Builder
{
    public interface IRobotPlan
    {
        void SetRobotHead(String Head);
        void SetRobotArmes(String Armes);
        void SetRobotLegs(String Legs);
        void SetRobotBody(String Body);

    }
}
