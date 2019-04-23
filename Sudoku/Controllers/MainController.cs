using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SudocuData.Entities;
using SudocuServices.Services;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Http.Results;
using Sudoku.Models;

namespace Sudoku.Controllers
{
    [RoutePrefix("api/main")]
    public class MainController : ApiController
    {
        private INumberService _numService = new NumberService();
        private NumberContext db = new NumberContext();
                
        [HttpPost]
        public IHttpActionResult Post( int level)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }            
            var response = _numService.Load(level);
            db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        [Route("OpenCell")]
        public IHttpActionResult OpenCell([FromBody] Cell cells)
        {
            int n = _numService.Open(cells.Id, cells.ColName);
            if (n != 0)
                return Ok(n);
            else
                return NotFound();
        }

        [HttpPut]
        [Route("Verify")]
        public IHttpActionResult Verify([FromBody] List<NumberResponse> data)
        {
            bool eq = _numService.Verify(data);

            return Ok(eq);
        }

    }
}
