//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RunWithYouData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trail
    {
        public int Id { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public System.DateTime date_of_trail { get; set; }
        public string place_of_start { get; set; }
        public int distance { get; set; }
        public string type_of_trail { get; set; }
        public string description { get; set; }
        public string geo_location { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
