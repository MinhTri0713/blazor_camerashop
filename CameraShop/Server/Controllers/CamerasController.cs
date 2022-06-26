using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CameraShop.Server;
using CameraShop.Shared;
using System.Linq;

namespace CameraShop.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CamerasController : ControllerBase {
        private readonly CameraShopDbContext db;
        public CamerasController(CameraShopDbContext db) {
            this.db = db;
        }

        [HttpGet("/cameras")]
        public IQueryable<Camera> GetCameras()
        => this.db.Cameras;

        [HttpPost("/cameras")]
        public IActionResult InsertCamera([FromBody] Camera camera) {
            db.Cameras.Add(camera);
            db.SaveChanges();
            return Created($"cameras/{camera.Id}", camera);
        }
    }
}

