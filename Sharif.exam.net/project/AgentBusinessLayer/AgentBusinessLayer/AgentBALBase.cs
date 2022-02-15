using clsAgent;
using System.Linq;

namespace AgentBusinessLayer
{
    public class AgentBALBase
    {
        public bool ValidAgent(Agent agent)
        {
            bool IsValid = true;
            if (agent.AgentName.Length < 5 || agent.AgentName.Length > 12)
            {
                IsValid = false;
                sb.Append("Employ Name contains min. 5 characters and maxium 12 characters...\r\n");

            }
            if (agent.gender.Equals("MALE") == false || agent.gender.Equals("FEMALE") == false)
            {
                IsValid = false;
                sb.Append("gender is either male or female....\r\n");
            }
            if (agent.PayMode != 1 || agent.PayMode != 2 || agent.PayMode != 3)
            {
                IsValid = false;
                sb.Append("paymode can only be 1 ,2 0r 3....\r\n");
            }
            if (agent.Premium < 15000)
            {
                IsValid = false;
                sb.Append("premium shouldn't be less than 15000....\r\n");
            }
        }
    }
}