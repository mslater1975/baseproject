using System;

namespace Core.Models
{
    public class RecentWork : BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Picture1Url { get; set; }
        public string Picture2Url { get; set; }
        public string Picture3Url { get; set; }
        public string Picture4Url { get; set; }
        public string Picture5Url { get; set; }  


    }
}