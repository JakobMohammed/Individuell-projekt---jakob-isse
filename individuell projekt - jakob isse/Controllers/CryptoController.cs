using System.Linq;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CryptoController : ControllerBase
{
    public record CryptoRequest(string Text, int Shift);
    public record CryptoResponse(string Result);

    [HttpPost("encrypt")]
    public ActionResult<CryptoResponse> Encrypt([FromBody] CryptoRequest req)
        => Ok(new CryptoResponse(Caesar(req.Text, req.Shift)));

    [HttpPost("decrypt")]
    public ActionResult<CryptoResponse> Decrypt([FromBody] CryptoRequest req)
        => Ok(new CryptoResponse(Caesar(req.Text, -req.Shift)));

    private static string Caesar(string input, int shift)
    {
        if (string.IsNullOrWhiteSpace(input)) return input;
        shift %= 26;

        return new string(input.Select(c =>
        {
            if (c >= 'a' && c <= 'z') return (char)('a' + (c - 'a' + shift + 26) % 26);
            if (c >= 'A' && c <= 'Z') return (char)('A' + (c - 'A' + shift + 26) % 26);
            return c;
        }).ToArray());
    }
}

