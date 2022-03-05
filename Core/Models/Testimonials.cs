using System;

namespace Core.Models
{
    public class Testimonials: BaseEntity
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool visibile { get; set; }
    }
}