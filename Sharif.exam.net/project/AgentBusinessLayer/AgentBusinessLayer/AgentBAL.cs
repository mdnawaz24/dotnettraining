using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clsAgent;
using Exceptions1;
using AgentDataLayer;
using System.Threading.Tasks;

namespace AgentBusinessLayer
{

    public class AgentBAL
    {
        static StringBuilder sb=new StringBuilder();
        static AgentDal dal=new AgentDal();
        public bool ValidateAgent(Agent agent)
        {
            bool IsValid = true;
            if (agent.AgentName.Length<5 || agent.AgentName.Length > 12) 
            {
                IsValid = false;
                sb.Append("Employ Name contains min. 5 characters and maxium 12 characters...\r\n");

            }
            if(agent.gender.Equals("MALE" )==false || agent.gender.Equals("FEMALE")==false)
            {
                IsValid=false;
                sb.Append("gender is either male or female....\r\n");
            }
            if(agent.PayMode!=1 || agent.PayMode != 2 || agent.PayMode != 3)
            {
                IsValid = false;
                sb.Append("paymode can only be 1 ,2 0r 3....\r\n");
            }
            if (agent.Premium < 15000)
            {
                IsValid = false;
                sb.Append("premium shouldn't be less than 15000....\r\n");
            }
            return IsValid;
        }
        public string ReadAgentFileBAL()
        {
            return dal.ReadFromFileDAL();
        }
        public string WriteAgentFileBAL()
        {
            return dal.WriteAgentFileDAL();
        }
        public Agent SearchAgentBAL(int agent)
        {
            return dal.SearchAgentDAL(agent);
        }
        public string DeleteAgentBAL(int agent)
        {
            return dal.DeleteAgentDAL(agent);
        }
        public string UpdateAgentBAL(Agent agent)
        {
            return dal.UpdateAgentDAL(agent);
        }
        public string AddAgentBAL(Agent agent)
        {
            if (ValidateAgent(agent)==false)
            {
                throw new AgentException(sb.ToString());
            }
            else
            {
                return dal.AddAgentDAL(agent);
            }
        }
    }
}
