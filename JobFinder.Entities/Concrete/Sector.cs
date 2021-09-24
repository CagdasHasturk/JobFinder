using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;

namespace JobFinder.Entities.Concrete
{
    public class Sector : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string SectorName { get; set; }
    }
}
