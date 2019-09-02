using GAP.Dal;
using GAP.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Rules
{
    public class PolicyRules : IPolicyRules
    {
        private readonly IPolicyDal PolicyDal;

        public PolicyRules(IPolicyDal PolicyDal)
        {
            this.PolicyDal = PolicyDal;
        }

        public async Task<MessageDto> SavePolicy(PolicyDto Policy)
        {
            try
            {
                if (Policy.Risk == (int)RiskEnum.Higher && Policy.CoveringPercentage > 50)
                {
                    throw new ArgumentException("Must be less than 50%");
                }

                await PolicyDal.SavePolicy(Policy);
                return new MessageDto
                {
                    Code = (int)MessageEnum.Successful,
                    Message = "Policy saved successfully!"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MessageDto> UpdatePolicy(PolicyDto Policy)
        {
            try
            {
                await PolicyDal.UpdatePolicy(Policy);
                return new MessageDto
                {
                    Code = (int)MessageEnum.Successful,
                    Message = "Policy updated successfully!"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MessageDto> CancelPolicy(PolicyDto Policy)
        {
            try
            {
                await PolicyDal.CancelPolicy(Policy);
                return new MessageDto
                {
                    Code = (int)MessageEnum.Successful,
                    Message = "Policy canceled successfully!"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<PolicyDto>> GetPoliciesByClientId(int ClientId)
        {
            try
            {
                return await PolicyDal.GetPoliciesByClientId(ClientId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
