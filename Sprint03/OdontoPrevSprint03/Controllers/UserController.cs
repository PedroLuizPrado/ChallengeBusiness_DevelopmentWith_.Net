using Microsoft.AspNetCore.Mvc;
using OdontoPrevSprint03.Models;
using OdontoPrevSprint03.Services;

namespace OdontoPrevSprint03.Controllers
{

    [ApiController]
    [Route("[controller]")]
    
    /// <summary>
    /// Controller para gerenciar usuários (pacientes).
    /// </summary>
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Obtém todos os usuários.
        /// </summary>
        /// <returns>Uma lista de usuários.</returns>

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        /// <summary>
        /// Obtém um usuário pelo ID.
        /// </summary>
        /// <param name="id">O ID do usuário.</param>
        /// <returns>O usuário encontrado.</returns>

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


        /// <summary>
        /// Adiciona um novo usuário.
        /// </summary>
        /// <param name="user">O usuário a ser adicionado.</param>
        /// <returns>O usuário criado.</returns>

        [HttpPost]
        public async Task<ActionResult> AddUser(User user)
        {
            await _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }


        /// <summary>
        /// Atualiza um usuário existente.
        /// </summary>
        /// <param name="id">O ID do usuário a ser atualizado.</param>
        /// <param name="user">O usuário com as informações atualizadas.</param>
        /// <returns>NoContent se a atualização for bem-sucedida.</returns>

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            await _userService.UpdateUser(user);
            return NoContent();
        }

        /// <summary>
        /// Exclui um usuário pelo ID.
        /// </summary>
        /// <param name="id">O ID do usuário a ser excluído.</param>
        /// <returns>NoContent se a exclusão for bem-sucedida.</returns>

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
