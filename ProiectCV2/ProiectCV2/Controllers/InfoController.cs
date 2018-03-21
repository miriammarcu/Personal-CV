using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProiectCV2.Repository;

namespace ProiectCV2.Controllers
{
    public class InfoController : ApiController
    {

        private InfoRepo _infoRepo = new InfoRepo();
        private SkillsRepo _skillsRepo = new SkillsRepo();
        private LangRepo _langRepo = new LangRepo();
        private EduRepo _eduRepo = new EduRepo();
        private WorkRepo _workRepo = new WorkRepo();
        [HttpGet]
        [Route("api/info")]
        public IHttpActionResult GetInfo()
        {
            try
            {
                return Ok(_infoRepo.GetCVInfo());
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/skills")]
        public IHttpActionResult GetSkills()
        {
            try
            {
                return Ok(_skillsRepo.GetCVInfo());
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/lang")]
        public IHttpActionResult GetLang()
        {
            try
            {
                return Ok(_langRepo.GetCVInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/edu")]
        public IHttpActionResult GetEdu()
        {
            try
            {
                return Ok(_eduRepo.GetCVInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/work")]
        public IHttpActionResult GetWork()
        {
            try
            {
                return Ok(_workRepo.GetCVInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
