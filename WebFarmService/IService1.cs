using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebFarmService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
       
        int Login(String email, string password);
        [OperationContract]
        Boolean Register(String Name,String Surname,String email,String password,String contact);
       

        
        // TODO: Add your service operations here
    }


}
