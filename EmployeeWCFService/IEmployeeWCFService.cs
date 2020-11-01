using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeWCFService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeWCFService
    {
        [OperationContract]
        Employee GetEmployeeWCF(int Id);

        [OperationContract]
        void SaveEmployeeWCF(Employee employee);
    }

}
