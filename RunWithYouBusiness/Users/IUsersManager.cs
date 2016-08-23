using RunWithYouEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWithYouBusiness
{
    public interface IUsersManager
    {
        Task SignInAsync(UsersInformations userInformation);
    }
}
