using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BNP.BLL;

namespace BNP.API.Controllers
{
    [EnableCors("*", "*", "*")]
   
    public class MovimentoController : ApiController
    {

        public HttpResponseMessage Get()
        {
            HttpResponseMessage response;
            try
            {
                response = Request.CreateResponse(HttpStatusCode.OK, BLL.Movimento.Listar());
            }
            catch (IndexOutOfRangeException ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
            catch (ArgumentException ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
            catch (FormatException ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
            catch (TimeoutException ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
            return response;
        }



        public HttpResponseMessage Post(DTO.Movimento movimento)
        {
            var result = BLL.Movimento.Gravar(movimento);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
