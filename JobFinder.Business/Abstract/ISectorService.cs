using System;
using System.Collections.Generic;
using JobFinder.Entities.Concrete;

namespace JobFinder.Business.Abstract
{
    public interface ISectorService
    {
        List<Sector> GetAll();

        Sector Get(string SectorName);
    }
}
