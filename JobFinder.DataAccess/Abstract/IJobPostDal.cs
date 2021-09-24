using System;
using JobFinder.Core.DataAccess;
using JobFinder.Entities.Concrete;

namespace JobFinder.DataAccess.Abstract
{
    public interface IJobPostDal : IEntityRepository<JobPost>
    {
    }
}
