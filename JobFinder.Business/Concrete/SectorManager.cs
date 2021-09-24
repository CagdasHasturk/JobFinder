using System;
using System.Collections.Generic;
using JobFinder.Entities.Concrete;
using JobFinder.Business.Abstract;
using JobFinder.DataAccess.Abstract;

namespace JobFinder.Business.Concrete
{
    public class SectorManager : ISectorService
    {

        private ISectorDal _sectorDal;

        public SectorManager(ISectorDal sectorDal)
        {
            _sectorDal = sectorDal;
        }


        public Sector Get(string SectorName)
        {
            return _sectorDal.Get(s => s.SectorName.ToLower() == SectorName.ToLower());
        }

        public List<Sector> GetAll()
        {
            return _sectorDal.GetAll();
        }
    }
}
