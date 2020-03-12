using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectAPI.Data;
using FinalProjectAPI.Data.Entities;
using FinalProjectAPI.Models.Convertion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly ProductDBContext _productDBContext;
        public AboutController(ProductDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }
        [HttpGet]
        public async Task<IEnumerable<About>> GetAbouts()
        
        {
            return await _productDBContext.Abouts.ToListAsync();
        }
        [HttpPut("{id}")]
        public async Task EditAbout(string id,[FromBody]About about)
        {
            var data =await _productDBContext.Abouts.FindAsync(int.Parse(id));
            //MyMapper<About>.Map(about,data);
            data.PhoneNumber = about.PhoneNumber;
            data.Title = about.Title;
            data.Description = about.Description;
            data.Address = about.Address;
            data.Email = about.Email;
            _productDBContext.Entry(data).State = EntityState.Modified;
            _productDBContext.SaveChanges();

        }
    }
}