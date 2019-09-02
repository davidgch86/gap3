/*using GAP.Dto;
using GAP.Rules;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GAP.Api.Controllers
{
    public class CoveringTypeController : ApiController
    {
       /* private readonly ICoveringTypeRules CoveringTypeRules;

        public CoveringTypeController(ICoveringTypeRules CoveringTypeRules)
        {
            this.CoveringTypeRules = CoveringTypeRules;
        }

        [Route("api/CoveringType/GetCoveringTypes")]
        [HttpPost]
        public async Task<HttpResponseMessage> GetCoveringTypes()
        {
            try
            {
                List<CoveringTypeDto> lData = await CoveringTypeRules.GetAllCoveringTypes();
                return Request.CreateResponse(HttpStatusCode.OK, new { ModelData = lData, Message = string.Empty });
            }
            catch (Exception ex)
            {
               /* return Request.CreateResponse(HttpStatusCode.InternalServerError, new MessageDto
                {
                    Code = (int)MessageEnum.Error,
                    Message = ex.Message
                });
            }
        }
    }
}*/