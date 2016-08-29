using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWithYouEntities
{
    public class TrailTypeInfo
    {
        public string DisplayName { get; set; }

        public string EnglishName { get; set; }
    }

    public class TrailTypes
    {
        public List<TrailTypeInfo> TrailType
        {
            get
            {
                List<TrailTypeInfo> trailType = new List<TrailTypeInfo>();
                trailType.Add(new TrailTypeInfo() { EnglishName = "Plaisur", DisplayName = "Plaisur" });
                trailType.Add(new TrailTypeInfo() { EnglishName = "ShortAndSlow", DisplayName = "Short And Slow" });
                trailType.Add(new TrailTypeInfo() { EnglishName = "ShortAndQuikly", DisplayName = "Short And Quikly" });
                trailType.Add(new TrailTypeInfo() { EnglishName = "LongAndSlow", DisplayName = "Long And Slow" });
                trailType.Add(new TrailTypeInfo() { EnglishName = "LongAndQuikly", DisplayName = "Long And Quikly" });
                return trailType;
            }
        }
    }
}
