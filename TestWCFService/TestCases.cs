using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWCFService.EmployeeService;
using System.ServiceModel;
using System.Collections.Generic;
namespace TestWCFService
{
    [TestClass]
    public class TestCases
    {
        AddEmployeeDataClient _generateEmployeeDetailsClient = new AddEmployeeDataClient("BasicHttpBinding_IAddEmployeeData");
        GetEmployeeDataClient _getEmployeeDetailsclient = new GetEmployeeDataClient("WSHttpBinding_IGetEmployeeData");

        [TestCleanup]
        public void CloseClientInstance()
        {
            if (_generateEmployeeDetailsClient != null && _generateEmployeeDetailsClient.State == System.ServiceModel.CommunicationState.Opened) _generateEmployeeDetailsClient.Close();
            if (_getEmployeeDetailsclient != null && _getEmployeeDetailsclient.State == System.ServiceModel.CommunicationState.Opened) _getEmployeeDetailsclient.Close();
        }


        [TestMethod]
        public void AddandRetrieveById()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            Employee employee = new Employee();
            employee.Id = 11;
            employee.Name = "Bhagyashree";
            _generateEmployeeDetailsClient.CreateEmployee(employee);
            employee = _getEmployeeDetailsclient.GetEmployeeById(11);
            Assert.AreEqual("Bhagyashree", employee.Name);
        }


        [TestMethod]
        [ExpectedException(typeof(FaultException<CustomeException>))]
        public void AddEmployeeWithSameId()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            Employee employee = new Employee();
            employee.Id = 12;
            employee.Name = "Waval Bhagyashree";
            _generateEmployeeDetailsClient.CreateEmployee(employee);
            _generateEmployeeDetailsClient.CreateEmployee(employee);
        }


        [TestMethod]
        public void AddRemarkOnId()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            Employee employee = new Employee();
            employee.Id = 5;
            employee.Name = "Waval Bhagyashree";
            _generateEmployeeDetailsClient.CreateEmployee(employee);
            _generateEmployeeDetailsClient.AddRemarkOnId(5, "Good", "A", "Project manager");
            employee = _getEmployeeDetailsclient.GetEmployeeById(5);
            Assert.AreNotEqual(employee.Remarks[0], "No remarks added yet");
        }


        [TestMethod]
        public void AddRemarkOnName()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            Employee employee = new Employee();
            employee.Id = 15;
            employee.Name = "WavalB";
            _generateEmployeeDetailsClient.CreateEmployee(employee);
            _generateEmployeeDetailsClient.AddRemarkOnName("WavalB", "Good", "A", "Project manager");
            employee = _getEmployeeDetailsclient.GetEmployeeById(15);
            Assert.AreNotEqual(employee.Remarks[0], "No remarks added yet");
        }


        [TestMethod]
        [ExpectedException(typeof(FaultException<CustomeException>))]
        public void AddRemarkWhereEmployeeNotPresent()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            _generateEmployeeDetailsClient.AddRemarkOnId(102, "Good", "A", "Project manager");
        }


        [TestMethod]
        public void AddandRetrieveByName()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            Employee employee = new Employee();
            employee.Id = 14;
            employee.Name = "BhagyashreeWaval";
            _generateEmployeeDetailsClient.CreateEmployee(employee);
            employee = _getEmployeeDetailsclient.GetEmployeeByName("BhagyashreeWaval");
            Assert.AreEqual(14, employee.Id);
        }


        [TestMethod]
        public void RetrieveAllemployees()
        {
            _generateEmployeeDetailsClient.ClearpreviousRecords();
            Employee employee = new Employee();
            employee.Id = 100;
            employee.Name = "Bhagyashree";
            _generateEmployeeDetailsClient.CreateEmployee(employee);
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.AddRange(_getEmployeeDetailsclient.GetAllEmployees());
            Assert.IsFalse(EmployeeList.Count < 1);
        }

       
    }
}
