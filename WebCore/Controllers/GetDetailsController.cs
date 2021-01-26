using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities.Core;
using WebApp.Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDetailsController : ControllerBase
    {
        private IGetDetailsService _getDetailsService;

        public GetDetailsController(IGetDetailsService getDetailsService)
        {
            _getDetailsService = getDetailsService;
        }

        /// <summary>
        /// Get Last updated Artikal
        /// </summary>
        /// <returns></returns>
        [HttpGet("getIdentifiedObjects")]
        public List<IdentifiedObject> GetIdentifiedObjects()
        {
            return _getDetailsService.GetIdentifiedObjects();
        }
    }
}
