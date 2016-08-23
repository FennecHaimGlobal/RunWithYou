using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunWithYouEntities;

namespace RunWithYouBusiness
{
    public interface ITrailsManager
    {
        Task CreateInAsync(TrailsInformations trail);
    }
}
