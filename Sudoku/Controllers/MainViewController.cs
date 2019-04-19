using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using SudocuData.Entities;
using SudocuServices.Services;



namespace Sudoku.Controllers
{
    public class MainViewController : Controller
    {
        private INumberService _numService = new NumberService();
        private NumberContext db = new NumberContext();

        [HttpGet]
        public ActionResult Index(int level)
        {
            var data = _numService.Load(level);
            return View(data); 
        }

       
    }
}