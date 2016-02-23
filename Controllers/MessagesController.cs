using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MBSApp.Models;
using System.Web.Http.Cors;

namespace MBSApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class MessagesController : ApiController
    {
        Message[] messages = new Message[]
         {
            new Message { rMessageID = 1, Subject = "Sport", Body = "Odbojka, vtornik 18 casot"}
         };
        
        public IEnumerable<Message> GetAllMessages()
        {
            return messages;
        }

        public IHttpActionResult GetMessage(int id)
        {
            var message = messages.FirstOrDefault((p) => p.rMessageID == id);
            if (message == null)
            {
                return NotFound();
            }
            return Ok(message);
        }
    }
}