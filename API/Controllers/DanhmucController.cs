using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhmucController : ControllerBase
    {
        private readonly IdanhmucBuss _Buss;
        public DanhmucController(IdanhmucBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_all_danh_muc")]
        [HttpGet]
        public List<danhmuc> get_all_danh_muc()
        {
            return _Buss.get_all_danh_muc();
        }
        [Route("create_danh_muc")]
        [HttpPost]
        public bool create_danh_muc([FromBody]danhmuc dm)
        {
            return _Buss.create_danh_muc(dm);
        }
    }
}
