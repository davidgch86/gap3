using GAP.Dto;
using GAP.Rules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurances.Rules.Class
{


    public class UserGAPRules : IUserGAP
    {

        private readonly IUserGAP UserGAP;

        public UserGAPRules(IUserGAP UserGAPDal)
        {
           // this.UserGAPDal = UserGAPDal;
        }

        Task<UsersGAPDto> IUserGAP.IsUser(UsersGAPDto userGAP)
        {
            throw new NotImplementedException();
        }
    }
}
