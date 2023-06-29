using Microsoft.AspNetCore.Mvc;
// using directives

[ApiController]
[Route("/api")]
public class StartController : ControllerBase
{
    [HttpGet]
    [Route("listUsers")]
    public IActionResult ListUsers(int itemCount, int page)
    {
        itemCount = Math.Clamp(itemCount, 1, 50);
        page = Math.Clamp(page, 1, int.MaxValue);

        return Ok($"itemCount: {itemCount}, page: {page}");
    }

    [HttpGet]
    [Route("openFile")]
    public IActionResult OpenFile()
    {
        // IDisposable
        try
        {
            // using statement
            using var file = new System.IO.StreamReader("archivo.txt");
            var line = file.ReadLine();
            return Ok(line);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
}
