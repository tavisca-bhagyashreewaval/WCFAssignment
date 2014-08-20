using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementUsingWCF
{
    [ServiceContract]
    public interface IAddEmployeeData
    {
        [OperationContract]
        void ClearpreviousRecords();

        [OperationContract]
        [FaultContract(typeof(CustomeException))]
        string CreateEmployee(Employee e);

        [OperationContract(Name = "AddRemarkOnId")]
        [FaultContract(typeof(CustomeException))]
        string AddRemark(int id, string remarkText, string remarkGrade, string remarkAuthor);

        [OperationContract(Name = "AddRemarkOnName")]
        [FaultContract(typeof(CustomeException))]
        String AddRemark(String name, string remarkText, string remarkGrade, string remarkAuthor);
    }

    [ServiceContract]
    public interface IGetEmployeeData
    {

        [OperationContract (Name="GetEmployeeById")]
        [FaultContract(typeof(CustomeException))]
        Employee GetEmployee(int id);

        [OperationContract(Name = "GetEmployeeByName")]
        [FaultContract(typeof(CustomeException))]
        Employee GetEmployee(String name);

        [OperationContract]
        [FaultContract(typeof(CustomeException))]
        List<Employee> GetAllEmployees();
    }

    [DataContract]
    public class Employee
    {

        [DataMember]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public string Name
        {
            get;
            set;
        }

  
      [DataMember]
        public List<String> Remarks = new List<String>();
    }
}
