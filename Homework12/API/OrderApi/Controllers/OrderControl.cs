using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using OrderApi;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        public static OrderService service=new OrderService();
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrder()
        {
            return service.orders.ToList<Order>();
        }
        [HttpGet]
        public ActionResult<List<Order>> GetOrder(string info)
        {
            return service.searchOrder(info);
        }
        [HttpPost]
        public ActionResult<Order> PostOrder(string json)
        {
            try{
            Order s=JsonSerializer.Deserialize<Order>(json);
            service.orders.Add(s);
            return s;
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
        }
        [HttpPut("{ID}")]
        public ActionResult<Order> PutOrder(int id,string json){
            try{
            Order s=JsonSerializer.Deserialize<Order>(json);
            service.modifyOrder(s.ID);
            return s;
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
        }
        [HttpDelete("{ID}")]
        public ActionResult<List<Order>> DeleteOrder(int id){
            try{
            service.deleteOrder(id);
            return service.orders;
            }catch(Exception e){
                return BadRequest(e.InnerException.Message);
            }
        }
    }
}