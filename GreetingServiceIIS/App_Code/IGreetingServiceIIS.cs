using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGreetingServiceIIS" in both code and config file together.
[ServiceContract]
public interface IGreetingServiceIIS
{

	[OperationContract]
	string GetGreeting(string name);

	[OperationContract]
	string SendGreeting(string name);

	// TODO: Add your service operations here
}
