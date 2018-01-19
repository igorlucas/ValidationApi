using Data.Contexts;
using Domain;
using Service;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers   
{
    [RoutePrefix("service")]
    public class ValidationsController : ApiController
    {
        private AppDataContext db = new AppDataContext();
        private ValidationContaService service = new ValidationContaService();

        [Route("public/validation/email")]
        public HttpResponseMessage PostValidationEmail(Conta entity)
        {
            var response = new HttpResponseMessage();


            if (service.ValidationDominioEmail(entity.Email))
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "domínio valido!");
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "domínio invalido!");
            }

            return response;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}