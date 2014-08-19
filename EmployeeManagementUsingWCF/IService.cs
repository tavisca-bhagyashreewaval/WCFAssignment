using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementUsingWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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

        //private List<String> newList;
        //  [DataMember]
        //public List<String> Remarks
        //{
        //    get { return newList; }
        //    set { newList = value; }
        //}

      [DataMember]
        public List<String> Remarks = new List<String>();
        //public StringBuilder Remarks = new StringBuilder();
    }
}
