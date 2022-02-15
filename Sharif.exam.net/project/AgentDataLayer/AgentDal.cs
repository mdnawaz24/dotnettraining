using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using clsAgent;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace AgentDataLayer
{
    public class AgentDal
    {
        static List<Agent> AgentList;
        static AgentDal()
        {
            AgentList = new List<Agent>();
        }
        public string ReadFromFileDAL()
        {
            FileStream fs = new FileStream(@"C:\files\pg",FileMode.Open,FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            AgentList=(List<Agent>)formatter.Deserialize(fs);
            fs.Close();
            return "Data Restored...";
        }
        public string  WriteAgentFileDAL()
        {
            FileStream fs = new FileStream(@"C:\files\pg", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, AgentList);
            fs.Close ();
            return "data stored in File...";
        }
        public string UpdateAgentDAL(Agent agent)
        {
            Agent agentFound=SearchAgentDAL(agent.AgentId);
            if (agentFound != null)
            {
                foreach(Agent ag in AgentList)
                {
                    if (ag.AgentId == agent.AgentId)
                    {
                        ag.AgentName = agent.AgentName;
                        ag.gender = agent.gender;
                        ag.Premium=agent.Premium;
                        ag.PayMode = agent.PayMode;

                    }
                }
                return "Agent Record Updated...";
            }
            return "Agent Record Not Found....";
        }
        public string DeleteAgentDAL(int agentid)
        {
            Agent agentFound=SearchAgentDAL(agentid);
            if (agentFound != null)
            {
                AgentList.Remove(agentFound);
                return "Agent Record Deleted...";
            }
            return "Record Not Found";
        }
        public Agent SearchAgentDAL(int agentid)
        {
            foreach(Agent agent in AgentList)
            {
                if(agent.AgentId == agentid)
                {
                    return agent;
                }    
            }
            return null;
        }
        public string AddAgentDAL(Agent agent)
        {
            AgentList.Add(agent);
            return "Agent Record Added...";
        }
        public List<Agent> ShowAgentDAL()
        {
            return AgentList;   
        }

    }
}
