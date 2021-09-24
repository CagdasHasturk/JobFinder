using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class JobAbility : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int JobPostId { get; set; }
        public int AbilityId { get; set; }
    }
}
