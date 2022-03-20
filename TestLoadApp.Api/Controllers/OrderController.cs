using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestLoadApp.Api.Dal;
using TestLoadApp.Api.Models;

namespace TestLoadApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public OrderController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetOrders()
        {
            var userId = User.Claims.First(x => x.Type == "id").Value;

            return Ok(await _appDbContext.Orders.Where(x => x.UserId == userId).Select(x => new OrderModelResponse
            {
                State = x.State,
                Id = x.Id,
                Created = x.Created,
                Items = x.Items
            }).ToListAsync());
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateOrder(OrderModelRequest model)
        {
            var userId = User.Claims.First(x => x.Type == "id").Value;

            _appDbContext.Orders.Add(new Order
            {
                UserId = userId,
                State = "New",
                Created = DateTime.Now,
                Items = model.Items
            });
            await _appDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
