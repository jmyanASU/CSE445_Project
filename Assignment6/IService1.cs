using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment6
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void addMember(string user, string pass);

        [OperationContract]
        string hashPass(string pass);

    }


}
