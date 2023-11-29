using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string WordFilter(string input);
        
        [OperationContract]
        string Number2Words(string number);

        [OperationContract]
        string GetRandomRecipe();

        [OperationContract]
        string GetWineDescription(string wine);

        [OperationContract]
        string AnalyzeRecipe(string recipe);




    }

   

}
