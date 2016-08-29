using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunWithYouEntities;

namespace RunWithYouData
{
    public class TrailsDataProvider : ITrailsDataProvider
    {
        #region Members

        /// <summary>
        /// The _instance
        /// </summary>
        private static ITrailsDataProvider _instance;

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
        public static ITrailsDataProvider GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new TrailsDataProvider();
                        }
                    }
                }
                return _instance;
            }
        }



        #endregion

        #region public Methods

        public async Task<List<TrailsInformations>> GetAllActivesTrails()
        {
            List<TrailsInformations> result = new List<TrailsInformations>();

            using (Entities context = new Entities())
            {
                var response = context.Trails.Where(T => T.date_of_trail >= DateTime.UtcNow).ToList();

                if (response.Count > 0)
                {
                    result = response.Select(T => new TrailsInformations()
                    {
                        Id = T.Id,
                        created_by = T.created_by,
                        created_date = T.created_date,
                        date_of_trail = T.date_of_trail,
                        distance = T.distance,
                        city = T.city,
                        country = T.country,
                        place_of_start = T.place_of_start,
                        type_of_trail = T.type_of_trail,
                        geo_location = T.geo_location,
                        description = T.description
                    }).ToList();
                }
            }

            return result;
        }

        public async Task CreateInAsync(TrailsInformations trail)
        {
            try
            {
                using (Entities context = new Entities())
                {
                    Trail trailEntry = new Trail()
                    {
                        created_by = trail.created_by,
                        created_date = DateTime.UtcNow,
                        update_date = DateTime.UtcNow,
                        date_of_trail = trail.date_of_trail,
                        place_of_start = trail.place_of_start,
                        distance = trail.distance,
                        type_of_trail = trail.type_of_trail,
                        description = trail.description,
                        geo_location = trail.geo_location,
                        city = trail.city,
                        country = trail.country
                    };

                    context.Trails.Add(trailEntry);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
