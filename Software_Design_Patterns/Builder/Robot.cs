using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Builder
{
    public class Robot : IRobotPlan
    {

        private String RobotArmes;
        private String RobotBody;
        private String RobotHead;
        private String RobotLegs;

        // setter
        public void SetRobotArmes(string Armes)
        {
            RobotArmes = Armes;
        }

        public void SetRobotBody(string Body)
        {
            RobotBody = Body;
        }

        public void SetRobotHead(string Head)
        {
           RobotHead = Head;
        }

        public void SetRobotLegs(string Legs)
        {
            RobotLegs = Legs;
        }
        //getter
        public String GetRobotArmes()
        {
            return RobotArmes;
        }

        public String GetRobotBody()
        {
           return RobotBody;
        }

        public String GetRobotHead()
        {
           return RobotHead;
        }

        public String GetRobotLegs()
        {
           return RobotLegs;
        }
    }
}
