using System;

namespace Core.Models
{
    public class CurrentOffers : BaseEntity
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}