using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWithYouEntities
{
    public class TrailsInformations
    {
        public int Id { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }

        [Display(Name = "Date")]
        public System.DateTime date_of_trail { get; set; }

        [Display(Name = "Place")]
        public string place_of_start { get; set; }

        [Display(Name = "Distance")]
        public int distance { get; set; }

        [Display(Name = "Type of Trail")]
        public string type_of_trail { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Geo Location")]
        public string geo_location { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "Country")]
        public string country { get; set; }
    }
}
