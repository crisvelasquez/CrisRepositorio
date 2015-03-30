using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace App.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvcOperaciones" in both code and config file together.
    [ServiceContract]
    public interface ISvcOperaciones
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebGet(UriTemplate="/Suma/{a}/{b}",ResponseFormat=WebMessageFormat.Json)]
        string Add(string a,string b);
    }
}
