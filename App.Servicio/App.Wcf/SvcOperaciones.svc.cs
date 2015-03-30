using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace App.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SvcOperaciones" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SvcOperaciones.svc or SvcOperaciones.svc.cs at the Solution Explorer and start debugging.
    public class SvcOperaciones : ISvcOperaciones
    {
        public void DoWork()
        {
        }


        public string Add(string a, string b)
        {
            var s = Convert.ToDouble(a) + Convert.ToDouble(b);
            return "La Suma es "+ s;
        }
    }
}
