using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubTelNo { get; set; }
        public string ClubEmail { get; set; }
        public string ClubWebSite { get; set; }
        public string ClubPostAdd1 { get; set; }
        public string ClubPostAdd2 { get; set; }
        public string ClubPostAdd3 { get; set; }
        public int? ClubPostCode { get; set; }
        public string Executive { get; set; }
        public string Administration { get; set; }
        public string Secretary { get; set; }
        public string Fardh { get; set; }
        public string Fards { get; set; }
    }
}
