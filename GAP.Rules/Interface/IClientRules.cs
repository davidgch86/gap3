using System.Collections.Generic;
using System.Threading.Tasks;
using GAP.Dto;

namespace GAP.Rules
{
    public interface IClientRules
    {
        Task<List<ClientDto>> GetAllClients();
        Task<ClientDto> GetClientById(int ClientId);
    }
}