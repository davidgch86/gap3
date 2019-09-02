using System.Collections.Generic;
using System.Threading.Tasks;
using GAP.Dto;

namespace GAP.Dal
{
    public interface IClientDal
    {
        Task<List<ClientDto>> GetAllClients();
        Task<ClientDto> GetAllClientsById(int ClientId);
    }
}