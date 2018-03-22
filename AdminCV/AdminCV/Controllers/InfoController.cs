using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdminCV.Repository;
using AdminCV.ViewModels;

namespace AdminCV.Controllers
{
    public class InfoController : ApiController
    {
        private WorkExpRepo _workExpRepo = new WorkExpRepo();
        private CompaniesRepo _compRepo = new CompaniesRepo();
        private PositionRepo _posRepo = new PositionRepo();

        [HttpPost]
        [Route("api/savework")]
        public IHttpActionResult SaveWork([FromBody] WorkViewModel wrkVm)
        {
            try
            {
                _workExpRepo.SaveWork(wrkVm);
            return Ok("Inserare cu succes");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("api/getwork")]
        public IHttpActionResult GetWork()
        {
            return Ok(_workExpRepo.GetCVInfo());
        }
        [HttpGet]
        [Route("api/getcomp")]
        public IHttpActionResult GetComp()
        {
            return Ok(_compRepo.GetCompanies());
        }
        [HttpGet]
        [Route("api/getpos")]
        public IHttpActionResult GetPos()
        {
            return Ok(_posRepo.GetPosition());
        }
        [HttpDelete]
        [Route("api/delete")]
        public IHttpActionResult DeleteWorkExp(int id)
        {
            try { _workExpRepo.DeleteWork(id);
                return Ok(" Delete succesful ");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
     
        }
    }
}
