using System.Threading.Tasks;
using GAP.Dto;


namespace GAP.Rules.Interface
{
   public interface IUserGAP
    {
        Task<UsersGAPDto> IsUser(UsersGAPDto userGAP);
    }
}
