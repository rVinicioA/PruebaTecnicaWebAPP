using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaWebAPP.DataAccess.Service
{
    internal class RequestValidation
    {
        public static Boolean Validate(HttpStatusCode statusCode)
        {
            if (statusCode == System.Net.HttpStatusCode.NoContent
                      || statusCode == System.Net.HttpStatusCode.OK
                      || statusCode == System.Net.HttpStatusCode.Created
                      || statusCode == System.Net.HttpStatusCode.Accepted)

                return true;
            else
                return false;
        }
    }
}
