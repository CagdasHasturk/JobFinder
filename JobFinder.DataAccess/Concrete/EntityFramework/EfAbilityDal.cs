using System;
using JobFinder.DataAccess.Abstract;
using JobFinder.Entities.Concrete;
using JobFinder.Core.DataAccess.EntityFramework;

namespace JobFinder.DataAccess.Concrete.EntityFramework
{
    public class EfAbilityDal : EfEntityRepositoryBase<JobFinderDbContext, Ability>, IAbilityDal
    {
       
    }
}
