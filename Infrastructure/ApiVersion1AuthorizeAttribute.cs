using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarternWebApi.Infrastructure
{
    public class ApiVersion1AuthorizeAttribute : ApiAuthorizeAttribute
    {
        public ApiVersion1AuthorizeAttribute()
        {

        }

        public ApiVersion1AuthorizeAttribute(string accessLevel)
        {

        }
    }
}
