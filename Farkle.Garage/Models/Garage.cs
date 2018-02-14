using System;

namespace Farkle.Garage.Models
{
    public class Garage
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid OwnerId { get; set; }
    }
}
