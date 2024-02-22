using Microsoft.AspNetCore.Mvc;
using PuntoCharliePruebaTecnica.Apis.Business;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PuntoCharliePruebaTecnica.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController : ControllerBase
    {
        private readonly RepositoryBusiness repositoryBusiness;

        public RepositoryController()
        {
            this.repositoryBusiness = new RepositoryBusiness();
        }

        // GET: api/<RepositoryController>
        [HttpGet]
        public dynamic Get()
        {
            try
            {
                var response = repositoryBusiness.GetRepository();
                if (response.Item1.State)
                    return response.Item2;
                else
                    return response.Item1;
            }
            catch (Exception ex)
            {
                return new { success = false, messsage = ex.Message.ToString() };
            }
        }
    }
}
