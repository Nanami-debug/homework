using Microsoft.AspNetCore.Mvc;
using ORDER_SERVICE;
using System.Collections.Generic;
using ORDER;
using Myd;
    

namespace SCF_Homework_9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly Order_Service service;

        public OrderController(Order_Service o)
        {
            service = o;
        }

        // GET: api/order/{name}
        [HttpGet("{name}")]
        public ActionResult<List<Order>> GetOrder(string name)
        {
            var orders = service.Get_Order(name);
            if (orders == null)
            {
                return NotFound();
            }
            return orders;
        }

        // POST: api/todo
        [HttpPost]
        public ActionResult<Order> PostTodoItem(Order order)
        {
            try
            {
                service.Add_Order(order);
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                    : e.InnerException.Message;
                return BadRequest(error);
            }
            return order;
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(int id)
        {
            try
            {
                service.Remove_Order(id);
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                   : e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }


    }
}
