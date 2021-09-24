using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class Candidate : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int EducationLevelId { get; set; }
        public short YearsOfExperience { get; set; }
    }
}
