using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class EducationLevel : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Degree { get; set; }
    }
}
