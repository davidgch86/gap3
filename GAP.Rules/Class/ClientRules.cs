using GAP.Dal;
using GAP.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Rules
{
    public class ClientRules : IClientRules
    {
        private readonly IClientDal ClientDal;

        public ClientRules(IClientDal ClientDal)
        {
            this.ClientDal = ClientDal;
        }

        public async Task<List<ClientDto>> GetAllClients()
        {
            try
            {
                return await ClientDal.GetAllClients();
            }
            catch (Exception)
            {
                //TODO return friendly errors make new component to handle it
                throw;
            }
        }

        public async Task<ClientDto> GetClientById(int ClientId)
        {
            try
            {
                return await ClientDal.GetAllClientsById(ClientId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
