using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Api.Filtros   
{
    public class ApiAuthorizerFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var header = actionContext.Request.Headers.Authorization;
            var headerParameters = Encoding.Default.GetString(Convert.FromBase64String(header.Parameter));

            var username = headerParameters.Split(':')[0];
            var password = headerParameters.Split(':')[1];
                            
            if (username.ToLower() == "igor" && password.ToLower() == "igor")
                base.OnAuthorization(actionContext);
            else
                return;
            
        }

    }
}