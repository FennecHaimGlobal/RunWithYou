using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunWithYouEntities.Users;
using RunWithYouData.Users;

namespace RunWithYouBusiness.Users
{
    public class UsersManager: IUsersManager
    {
        #region Members

        /// <summary>
        /// The _instance
        /// </summary>
        private static IUsersManager _instance;

        /// <summary>
        /// The _locker
        /// </summary>
        private static object _locker = new object();

        private IUsersDataProvider usersDataProvider = UsersDataProvider.GetInstance;

        #endregion

        #region Properties
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static IUsersManager GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new UsersManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public async Task SignInAsync(UsersInformations userInformation)
        {
            await usersDataProvider.SignInAsync(userInformation);
        }


        #endregion
    }
}
