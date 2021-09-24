using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;


namespace JobFinder.Entities.Concrete
{
    public class Application : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobPostId { get; set; }
        public int CandidateId { get; set; }
        public int ApplicatioinStateId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime ApplicationSettleDate { get; set; }
    }
}
