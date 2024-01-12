using Microsoft.AspNetCore.Mvc;
using TestRestAPI.Service;
using TestShared.Model;

namespace TestRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(TutorialService tutorialService) : ControllerBase
    {
        // すべてのユーザーを取得
        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            try
            {
                var users = await tutorialService.GetAllUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                // エラーハンドリング
                return StatusCode(500, ex.Message);
            }
        }

        // すべてのユーザーを取得（関連情報付き）
        [HttpGet("relation")]
        public async Task<ActionResult<List<Users>>> GetAllUsersRelation()
        {
            try
            {
                var users = await tutorialService.GetAllUsersRelationAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                // エラーハンドリング
                return StatusCode(500, ex.Message);
            }
        }

        // 新しいユーザーを追加
        [HttpPost]
        public async Task<ActionResult> AddUser(Users user)
        {
            try
            {
                await tutorialService.AddUserAsync(user);
                return Ok();
            }
            catch (Exception ex)
            {
                // エラーハンドリング
                return StatusCode(500, ex.Message);
            }
        }
    }

}
