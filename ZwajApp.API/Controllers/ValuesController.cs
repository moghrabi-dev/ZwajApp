//الكونترولرز الفكرة منها انه اي عنصر بالمشروع نقدر نرسله  عن طريق الراوت لأنه المشروع تبع اا اي بي اي كله روابط فقط 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZwajApp.API.Data;

namespace ZwajApp.API.Controllers
{
    [Route("api/[controller]")] // the additinal link we add to local host is api/value "value cames from ValuesController class but we use only value"
    [ApiController]
    public class ValuesController : ControllerBase   // هنا في شي متعارف عليه نعرف ب كلمة فاليو كونترول بس يوم نطلب بالرابط نستخدم بس فاليو 
    {
        //when we use only http://localhost:5000 "thats means we need GET API only"
        // GET api/values
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values =await _context.Values.ToListAsync();
                 return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.id == id);
             return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
