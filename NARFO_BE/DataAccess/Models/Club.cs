using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Club
    {
        public Club()
        {
            Member = new HashSet<Member>();
        }

        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public decimal? ClubTelNo { get; set; }
        public string ClubEmail { get; set; }
        public string ClubWebSite { get; set; }
        public string ClubPostAddress1 { get; set; }
        public int? ClubPostCode { get; set; }
        public string Executive { get; set; }
        public string Administartion { get; set; }
        public string Secretary { get; set; }
        public string Fard { get; set; }
        public string Fards { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
