using OOAD_HR_System.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace OOAD_HR_System.Controller
{
    class EmployeeController
    {
        EmployeeClass ec = new EmployeeClass();

        public void SetId(string oldId, string newId)
        {
            ec.setId(oldId, newId);
        }
        public void SetName(string name)
        {
            ec.setName(name);
        }
        public void SetSsn(string id, string ssn)
        {
            ec.setSsn(id, ssn);
        }
        public void SetSex(string id, string sex)
        {

            ec.setSex(id, sex);
        }
        public void SetBlood(string id, string blood)
        {
            ec.setBlood(id, blood);
        }
        public void SetPhone(string id, string phone)
        {
            ec.setPhone(id, phone);
        }
        public void SetAddress(string id, string address)
        {
            ec.setAddress(id, address);
        }
        public void SetEmerPerson(string id, string person)
        {
            ec.setEmerPerson(id, person);
        }
        public void SetEmerPhone(string id, string phone)
        {
            ec.setEmerPhone(id, phone);
        }
        public void SetMilitary(string id, string military)
        {
            ec.setMilitary(id, military);
        }
        public void SetJobState(string id, string state)
        {
            ec.setJobState(id, state);
        }
        public void SetMarriedState(string id, string marriedState)
        {
            ec.setMarriedState(id, marriedState);
        }
        public void SetSpouse(string id, string spouse)
        {
            ec.setSpouse(id, spouse);
        }
        public void SetBirth(string id, DateTime birth)
        {
            ec.setBirth(id, birth);
        }
        public void SetBasicSalary(string id, float basicSalary)
        {
            ec.setBasicSalary(id, Convert.ToInt32(basicSalary));
        }
        public void SetDeptId(string id, string deptId)
        {
            ec.setDeptId(id, deptId);
        }
        public void SetPositionId(string id, string positionId)
        {
            ec.setPositionId(id, positionId);
        }

    }
}
