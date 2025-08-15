using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WebFarmService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       WebfarmDataClassDataContext db = new WebfarmDataClassDataContext();
        public int Login(string email, string password)
        {
            var User = (from u in db.USERs
                      where u.U_Email.Equals(email) && u.U_Password.Equals(password)
                      select u).FirstOrDefault();
            return User.U_ID;
        }

        public bool Register(string Name, string Surname, string email, string password, string contact)
        {
            throw new NotImplementedException();
        }
    }
}
