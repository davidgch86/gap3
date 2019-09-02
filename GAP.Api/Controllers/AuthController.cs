using GAP.Dto;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GAP.Api.Controllers
{
    public class AuthController : ApiController
    {
        public AuthController()
        {
        }

        [HttpGet, HttpPost]
        [Route("api/Login/GetAuth")]
        public HttpResponseMessage GetAuth([FromBody]UsersGAPDto User)
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new UsersGAPDto
                {
                    Id = 1,
                    UserName = User.UserName,
                    IsAdmin= true,
                    UserPassword = "password",
                });
        }
    }
}
