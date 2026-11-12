using APIanalfabeta.Models;
using APIanalfabeta.Models; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AnalfabetaContext _context; 
    private readonly string _secretKey = "UnaClaveSecretaMuyLargaParaFirmarElToken2024!"; 

    public AuthController(AnalfabetaContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {

        var usuario = _context.Usuarios
            .FirstOrDefault(u => u.NombreUsuario == request.Usuario && u.Activo == true);


        if (usuario == null || usuario.Contrasena != request.Contrasena)
        {
            return Unauthorized("Usuario o contraseña incorrectos");
        }


        var claims = new[]
        {
            new Claim(ClaimTypes.Name, usuario.NombreUsuario),
            new Claim(ClaimTypes.Role, usuario.Rol), 
            new Claim("UsuarioId", usuario.UsuarioId.ToString())
        };


        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: "TuApiAzure",
            audience: "TuAppEscritorio",
            claims: claims,
            expires: DateTime.Now.AddHours(8),
            signingCredentials: creds
        );


        return Ok(new
        {
            token = new JwtSecurityTokenHandler().WriteToken(token),
            rol = usuario.Rol
        });
    }
}

public class LoginRequest
{
    public string Usuario { get; set; }
    public string Contrasena { get; set; }
}