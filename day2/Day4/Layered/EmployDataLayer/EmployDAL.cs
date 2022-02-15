using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployEntity;
using System.Threading.Tasks;

namespace EmployDataLayer
{
    public class EmployDAL
    {
        static List<Employ> employList;
        static EmployDAL()
        {
            employList = new List<Employ>();
        }

        public string DeleteEmployDAL(int empno)
        {
            Employ employFound = SeachEmployDAL(empno);
            if (employFound!=null)
            {
                employList.Remove(employFound);
                return "Employ Record Deleted...";
            }
            return "Employ Record Not Found...";
        }
        public Employ SeachEmployDAL(int empno)
        {
            foreach(Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    return employ;
                }
            }
            return null;
        }
        public string AddEmployDAL(Employ employ)
        {
            employList.Add(employ);
            return "Employ Record Added...";
        }

        public List<Employ> ShowEmployDAL()
        {
            return employList;
        }
    }
}
