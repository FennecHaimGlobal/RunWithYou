using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunWithYouEntities;
using RunWithYouData;

namespace RunWithYouBusiness
{
    public class TrailsManager: ITrailsManager
    {
        #region Members

        /// <summary>
        /// The _instance
        /// </summary>
        private static ITrailsManager _instance;

        /// <summary>
        /// The _locker
        /// </summary>
        private static object _locker = new object();

        private ITrailsDataProvider _trailsDataProvider = TrailsDataProvider.GetInstance;

        #endregion

        #region Properties
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static ITrailsManager GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new TrailsManager();
                        }
                    }
                }
                return _instance;
            }
        }



        #endregion

        #region public Methods
        public async Task CreateInAsync(TrailsInformations trail)
        {
            try
            {
                await _trailsDataProvider.CreateInAsync(trail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
