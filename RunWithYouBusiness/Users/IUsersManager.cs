using RunWithYouEntities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWithYouBusiness.Users
{
    public interface IUsersManager
    {
        Task SignInAsync(UsersInformations userInformation);
    }
}
