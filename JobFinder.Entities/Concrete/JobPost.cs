using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class JobPost : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        [MaxLength(300)]
        public string JobContent { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public short YearsOfExperience { get; set; }
        public int EducationLevelId { get; set; }
    }
}
