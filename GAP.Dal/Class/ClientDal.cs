using GAP.Dto;
using GAP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;

namespace GAP.Dal
{
    public class ClientDal : IClientDal
    {
        #region Vars & Props
        private readonly GAPContext context;
        #endregion

        #region Constructor
        public ClientDal(GAPContext context)
        {
            this.context = context;
        }
        #endregion

        #region Public Methods
        public async Task<List<ClientDto>> GetAllClients()
        {
            try
            {
                List<Client> DataSrc = await (from x in context.Client
                                              select x).ToListAsync();

                return Mapper.Map(DataSrc, new List<ClientDto>());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ClientDto> GetAllClientsById(int ClientId)
        {
            try
            {
                Client DataSrc = await (from x in context.Client
                                        where x.Id == ClientId
                                        select x).FirstOrDefaultAsync();

                return Mapper.Map(DataSrc, new ClientDto());
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
