using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DOMAIN.Models
{
    public class StoreModifications
    {
        [DataMember]
        public string ModuleCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public bool CollapsedState { get; set; }
        [DataMember]
        public string ReturnType { get; set; }
        [DataMember]
        public string ReturnTypeDesc { get; set; }
        [DataMember]
        public bool StartWith { get; set; }

    }
}
