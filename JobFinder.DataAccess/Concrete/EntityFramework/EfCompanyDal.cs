using System;
using JobFinder.DataAccess.Abstract;
using JobFinder.Entities.Concrete;
using JobFinder.Core.DataAccess.EntityFramework;
using JobFinder.DataAccess.Concrete.EntityFramework;

namespace JobFinder.DataAccess.Concrete
{
    public class EfCompanyDal : EfEntityRepositoryBase<JobFinderDbContext, Company>, ICompanyDal
    {
      
    }
}
