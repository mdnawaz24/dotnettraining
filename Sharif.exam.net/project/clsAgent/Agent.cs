using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsAgent
{
    public class Agent
    {
        public int AgentId{ get; set; }    
        public string AgentName { get; set; }   
        public string gender { get; set; }
        public int PayMode { get; set; }
        public double Premium { get; set; }

        public override string ToString()
        {
            return "Agent Id :" + AgentId + " Agent Name:" + AgentName + "Gender: " + gender + "PayMode" + PayMode
                + "Premium:" + Premium;
        }
    }
}
