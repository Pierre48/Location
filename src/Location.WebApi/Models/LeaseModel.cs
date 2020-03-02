using System;

namespace Location.WebApi.Models
{
    public class LeaseModel
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}