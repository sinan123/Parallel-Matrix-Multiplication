using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServerService.svc or ServerService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple)] 
    public class ServerService : IServerService
    {

          
        public int Multiplication(int[] Matrix1, int[] Matrix2)
        {
            int _result = 0;

            for (int i = 0; i < Matrix1.Length; i++)
            {
                _result += Matrix1[i] * Matrix2[i];
            }


            return _result;
        }
    }
}

