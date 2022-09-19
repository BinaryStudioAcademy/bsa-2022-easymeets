using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; 
using System.Text;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {

        [HttpGet("accept/{teamData}", Name = "AcceptInvitation")]
        public async Task<ActionResult<bool>> AcceptInvitation(string teamData)
        {
            byte[] byteArray = Convert.FromBase64String(teamData);
            string jsonBack = Encoding.UTF8.GetString(byteArray);
            var accountBack = JsonConvert.DeserializeObject(jsonBack);
            return Ok();
        } 
    }
}
