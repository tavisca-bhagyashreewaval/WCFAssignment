using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementUsingWCF
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceImplemtation : IAddEmployeeData,IGetEmployeeData
    {
        static List<Employee> _employeesData = new List<Employee>();

        public void ClearpreviousRecords()
        {
            _employeesData.Clear();
        }
        public string CreateEmployee(Employee employee)
        {
            var emp = _employeesData.Where(t => t.Id == employee.Id).FirstOrDefault();

            if (emp != null)
            {
                CustomeException exception = new CustomeException();
                exception.Message = "Record Cannot be Added.";
                exception.Reason = "Employee of same id Already Exists.";
                throw new FaultException<CustomeException>(exception);
            }
                employee.Remarks = new List<string>();
                employee.Remarks.Add("No remarks added yet");
                _employeesData.Add(employee);
                return "Record Successfully Added.";
        }


        public string AddRemark(int id, string remarkText, string remarkGrade, string remarkAuthor)
        {
            var emp = _employeesData.Where(t => t.Id == id).FirstOrDefault();
            if (emp == null)
            {
                CustomeException exception = new CustomeException();
                exception.Message = "Remark Cannot be Added successfully.";
                exception.Reason = "No Record with the Received Id Found.";
                throw new FaultException<CustomeException>(exception);
            }
            if (emp.Remarks[0] == "No remarks added yet")
            {
                emp.Remarks.Remove("No remarks added yet");
            }
            emp.Remarks.Add("\nRemark Date: " + DateTime.Now.ToString() + "\nRemark Text: " + remarkText + "\nRemark Grade: " + remarkGrade + "\nRemark Author: " + remarkAuthor + "\n");
            return "Remark Added successfully.";
        }


        public string AddRemark(string name, string remarkText, string remarkGrade, string remarkAuthor)
        {
            var emp = _employeesData.Where(t => t.Name == name).FirstOrDefault();
            if (emp == null)
            {
                CustomeException exception = new CustomeException();
                exception.Message = "Remark Cannot be Added successfully.";
                exception.Reason = "No Record with the Received Name Found.";
                throw new FaultException<CustomeException>(exception);
            }
            if (emp.Remarks[0] == "No remarks added yet")
            {
                emp.Remarks.Remove("No remarks added yet");
            }
            emp.Remarks.Add("\nRemark Date: " + DateTime.Now.ToString() + "\nRemark Text: " + remarkText + "\nRemark Grade: " + remarkGrade + "\nRemark Author: " + remarkAuthor + "\n");
            return "Remark Added successfully.";
            
        }


        public Employee GetEmployee(int id)
        {
            var emp = _employeesData.Where(t => t.Id == id).FirstOrDefault();
            if (emp == null)
            {
                CustomeException exception = new CustomeException();
                exception.Message = "Cannot Provide Employee Deatils Received Id.";
                exception.Reason = "No Record with the Received Id present.";
                throw new FaultException<CustomeException>(exception);
            }
            return emp;
        }


        public Employee GetEmployee(string name)
        {
             var emp = _employeesData.Where(t => t.Name == name).FirstOrDefault();
             if (emp == null)
             {
                 CustomeException exception = new CustomeException();
                 exception.Message = "Cannot Provide Employee Deatils Received Name.";
                 exception.Reason = "No Record with the Received Name present.";
                 throw new FaultException<CustomeException>(exception);
             }
             return emp;

        }


        public List<Employee> GetAllEmployees()
        {
            if (_employeesData.Count == 0)
                {
                    CustomeException exception = new CustomeException();
                    exception.Message = "No Records Exists.";
                    exception.Reason = "No Records Found.";
                    throw new FaultException<CustomeException>(exception);
                }
            return _employeesData;
        }

       
    }
}
