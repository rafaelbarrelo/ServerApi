namespace Server.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
	using Microsoft.AspNetCore.Mvc;

	[Route("api/[controller]")]
    public class StatusController : Controller
    {
        [HttpGet]
        public async Task<string> Get()
        {
            return await Task.Factory.StartNew(() => $"[{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}] Server Up: {System.Environment.MachineName}");
        }
    }
}
