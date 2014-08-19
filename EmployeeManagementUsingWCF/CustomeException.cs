using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EmployeeManagementUsingWCF
{
    [DataContract]
    public class CustomeException
    {
        [DataMember]
        public String Message { get; set; }

        [DataMember]
        public String Reason { get; set; }
    }
}