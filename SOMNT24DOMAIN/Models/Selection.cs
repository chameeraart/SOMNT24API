using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DOMAIN.Models
{
    public class Selection
    {
        [DataMember]
        public string BusinessUnit { get; set; }
        [DataMember]
        public string ModuleCode { get; set; }
        [DataMember]
        public string ModuleCodeDesc { get; set; }
        [DataMember]
        public string RetnType { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool StartWith { get; set; }
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public int FirstRow { get; set; }
        [DataMember]
        public int LastRow { get; set; }

        public Selection()
        {
            BusinessUnit = "";
            ModuleCode = "";
            ModuleCodeDesc = "";
            RetnType = "";
            Description = "";
            StartWith = true;
            Status = true;
            FirstRow = 0;
            LastRow = 0;
        }
    }
}
