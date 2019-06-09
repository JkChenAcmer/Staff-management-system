using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMserver.Model
{
    public class Log
    {
        public Guid OperatorID { get; set; }
        public DateTime LoginTime { get; set; }
        public string LoginDesc { get; set; }

        public Log(Guid opID,DateTime time,string desc)
        {
            OperatorID = opID;
            LoginTime = time;
            LoginDesc = desc;
        }
        public Log() { }
    }
}
