using System;
using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entites;


namespace JobFinder.Entities.Concrete
{
    public class ApplicationState : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string State { get; set; }
    }
}
