using GAP.Dto;
using GAP.Rules;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GAP.Api.Controllers
{
    public class ClientController : ApiController
    {
        private readonly IClientRules ClientRules;

        public ClientController(IClientRules ClientRules)
        {
            this.ClientRules = ClientRules;
        }

        [Route("api/Client/GetClients")]
        [HttpPost]
        public async Task<HttpResponseMessage> GetClients()
        {
            try
            {
                List<ClientDto> lData = await ClientRules.GetAllClients();
                return Request.CreateResponse(HttpStatusCode.OK, new { ModelData = lData, Message = string.Empty });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new MessageDto
                {
                    Code = (int)MessageEnum.Error,
                    Message = ex.Message
                });
            }
        }

        [Route("api/Client/GetClientById")]
        [HttpPost]
        public async Task<HttpResponseMessage> GetClientById(int ClientId)
        {
            try
            {
                ClientDto lData = await ClientRules.GetClientById(ClientId);
                return Request.CreateResponse(HttpStatusCode.OK, new { ModelData = lData, Message = string.Empty });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new MessageDto
                {
                    Code = (int)MessageEnum.Error,
                    Message = ex.Message
                });
            }
        }
    }
}