using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunWithYouEntities.Users;

namespace RunWithYouData.Users
{
    public interface IUsersDataProvider
    {
        Task SignInAsync(UsersInformations userInformation);
    }
}
