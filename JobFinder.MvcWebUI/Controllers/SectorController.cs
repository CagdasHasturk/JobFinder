using System;
using JobFinder.Business.Abstract;
using JobFinder.MvcWebUI.Models;

using Microsoft.AspNetCore.Mvc;

namespace JobFinder.MvcWebUI.Controllers
{
    public class SectorController : Controller
    {
        private ISectorService _sectorService;

        public SectorController(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }

        public IActionResult Index()
        {
            SectorListModelView sectorListModel = new SectorListModelView
            {
                Sectors = _sectorService.GetAll()
            };

            return View(sectorListModel);
        }
    }
}
