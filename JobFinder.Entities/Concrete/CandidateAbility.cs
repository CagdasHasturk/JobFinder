using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class CandidateAbility : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int AbilityId { get; set; }
    }
}
