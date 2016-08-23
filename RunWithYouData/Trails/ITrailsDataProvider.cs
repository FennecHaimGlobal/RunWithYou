using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunWithYouEntities;

namespace RunWithYouData
{
    public interface ITrailsDataProvider
    {
        Task CreateInAsync(TrailsInformations trail);
    }
}
