using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    public class AgentException :ApplicationException
    {
        public AgentException() { }
        public AgentException(string message) : base(message) { }
    }
}
