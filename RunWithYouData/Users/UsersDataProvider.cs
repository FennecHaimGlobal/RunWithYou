using RunWithYouEntities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWithYouData.Users
{
    public class UsersDataProvider: IUsersDataProvider
    {
        #region Members

        /// <summary>
        /// The _instance
        /// </summary>
        private static IUsersDataProvider _instance;

        /// <summary>
        /// The _locker
        /// </summary>
        private static object _locker = new object();

        #endregion

        #region Properties
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static IUsersDataProvider GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new UsersDataProvider();
                        }
                    }
                }
                return _instance;
            }
        }



        #endregion

        #region Public Methods
        public async Task SignInAsync(UsersInformations userInformation)
        {
            using (Entities context = new Entities())
            {
                RunWithYouData.UsersInformation userEntry = new UsersInformation()
                {
                    Id = userInformation.Id,
                    FirstName = userInformation.FirstName,
                    LastName = userInformation.LastName,
                    Email = userInformation.Email,
                    Address = userInformation.Address,
                    city = userInformation.city,
                    code = userInformation.code,
                    country = userInformation.country,
                    Phone1 = userInformation.Phone1,
                    Phone2 = userInformation.Phone2
                };

                context.UsersInformations.Add(userEntry);

                context.SaveChanges();
            }
        }
        #endregion
    }
}
