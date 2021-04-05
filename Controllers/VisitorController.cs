using System;
using barista.api.Models;
using barista.api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace barista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private VisitorContext _visitorContext;

        public VisitorController(VisitorContext visitorContext)
        {
            _visitorContext = visitorContext;
        }


        // GET api/visitor
        [HttpGet("")]
        public ActionResult<List<Visitor>> Getstrings()
        {
            return _visitorContext.Visitors.ToList();
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public ActionResult<Visitor> GetstringById(int id)
        {
            return _visitorContext.Visitors.FirstOrDefault(user => user.Id == id);
        }

        // POST api/user
        [HttpPost("")]
        public ActionResult<Visitor> Poststring(Visitor visitor)
        {
            _visitorContext.Visitors.Add(visitor);
            _visitorContext.SaveChanges();
            return visitor;
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public ActionResult<Visitor> Putstring(int id, Visitor visitor)
        {
            Visitor newVisitor = _visitorContext.Visitors.FirstOrDefault(visitor => visitor.Id == id);
            newVisitor.Firstname = visitor.Firstname;
            newVisitor.Lastname = visitor.Lastname;
            newVisitor.Email = visitor.Email;
            _visitorContext.SaveChanges();
            return newVisitor;

        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
            Visitor oldVisitor = _visitorContext.Visitors.FirstOrDefault(user => user.Id == id);
            _visitorContext.Visitors.Remove(oldVisitor);
            _visitorContext.SaveChanges();
        }
    }
}
