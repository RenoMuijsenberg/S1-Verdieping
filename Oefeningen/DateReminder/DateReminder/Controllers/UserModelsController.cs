//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using DateReminder;
//using DateReminder.Models;
//using Microsoft.AspNetCore.JsonPatch;

//namespace DateReminder.Controllers
//{
//    [Route("api/users")]
//    [ApiController]
//    public class UserModelsController : ControllerBase
//    {
//        private readonly DatabaseContext _context;

//        public UserModelsController(DatabaseContext context)
//        {
//            _context = context;
//        }

//        // GET: api/users
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
//        {
//            return await _context.Users.ToListAsync();
//        }

//        // GET: api/users/id
//        [HttpGet("id/{id}")]
//        public async Task<ActionResult<UserModel>> GetUserModel(int id)
//        {
//            var userModel = await _context.Users.FindAsync(id);

//            if (userModel == null)
//            {
//                return NotFound();
//            }

//            return userModel;
//        }

//        // GET: api/users/username
//        [HttpGet("{slug}")]
//        public async Task<ActionResult<UserModel>> GetUserModel(string slug)
//        {
//            var userModel = await _context.Users.FirstAsync(user => user.UserName == slug);

//            if (userModel == null)
//            {
//                return NotFound();
//            }

//            return userModel;
//        }

//        // POST: api/users
//        [HttpPost]
//        [ActionName(nameof(GetUserModel))]
//        public async Task<ActionResult<UserModel>> PostUserModel(UserModel userModel)
//        {
//            var checkUsername = await _context.Users.FirstOrDefaultAsync(user => user.UserName == userModel.UserName);

//            if (checkUsername != null)
//            {
//                return StatusCode(409);
//            }

//            _context.Users.Add(userModel);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(GetUserModel), new { id = userModel.Id }, userModel);
//        }

//        // DELETE: api/users/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteUserModel(int id)
//        {
//            var userModel = await _context.Users.FindAsync(id);
//            if (userModel == null)
//            {
//                return NotFound();
//            }

//            _context.Users.Remove(userModel);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        //PATCH: api/users/
//        [HttpPatch("{id}")]
//        public async Task<ActionResult> UpdatePassword(int id, [FromBody] JsonPatchDocument patch)
//        {
//            var userModel = await _context.Users.FindAsync(id);

//            if (userModel == null)
//            {
//                return NotFound();
//            }

//            patch.ApplyTo(userModel);
//            await _context.SaveChangesAsync();

//            return Ok();
//        }

//        private bool UserModelExists(int id)
//        {
//            return _context.Users.Any(e => e.Id == id);
//        }
//    }
//}
