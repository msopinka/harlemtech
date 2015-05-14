using HarlemTech.DataAccess;
using HarlemTech.DataAccess.Interfaces;
using HarlemTech.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HarlemTech.Controllers
{
    public class HomeController : Controller
    {
        private IUmbracoRepository _umbracoRepository;
        public HomeController(IUmbracoRepository umbracoRepository)
        {
            _umbracoRepository = umbracoRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var model = new PoiModel();
            model.POIs = await _umbracoRepository.GetAllPOIs();
            model.Images = await _umbracoRepository.GetAllImageData();
            return View(model);
        }
    }
}