using System;
using JobFinder.DataAccess.Abstract;
using JobFinder.Entities.Concrete;
using JobFinder.Core.DataAccess.EntityFramework;

namespace JobFinder.DataAccess.Concrete.EntityFramework
{
    public class EfSectorDal : EfEntityRepositoryBase<JobFinderDbContext, Sector>, ISectorDal
    {
       
    }
}
