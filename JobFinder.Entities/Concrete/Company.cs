using System.ComponentModel.DataAnnotations;
using System;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class Company : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int SectorId { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(10)]
        public string TaxNumber { get; set; }
    }
}
