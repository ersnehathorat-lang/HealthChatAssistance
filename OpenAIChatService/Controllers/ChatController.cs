using Microsoft.AspNetCore.Mvc;
using OpenAIChatService.Services;

namespace OpenAIChatService.Controllers
{
   [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ChatService _chatService;

        public ChatController(ChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost]
        public async Task<IActionResult> Ask([FromBody] ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Prompt))
                return BadRequest("Prompt is required.");

            var answer = await _chatService.GetChatResponse(request.Prompt);
            return Ok(new { answer });
        }
    }

    public class ChatRequest
    {
        public string Prompt { get; set; }
    }

}
