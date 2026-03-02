using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Core.DTOs.Tenant;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace API.Services.Tenant;

public class TenantLoginService : ITenantLoginService
{
    private readonly SignInManager<Core.Models.Tenant> _signInManager;
    private readonly IConfiguration _config;

    public TenantLoginService(SignInManager<Core.Models.Tenant> signInManager, IConfiguration config)
    {
        _signInManager = signInManager;
        _config = config;
    }

    public async Task<TenantLoginResponse> Login(TenantLoginRequest request)
    {
        var result = await _signInManager.PasswordSignInAsync(
            request.UserName,
            request.Password,
            false,
            false
        );

        if (!result.Succeeded)
        {
            return new TenantLoginResponse(false, "Email eller lösenord är fel");
        }

        var claims = new []
        {
            new Claim(ClaimTypes.Name, request.UserName)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["JwtsecurityKey"]!)
        );

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiryDate = DateTime.UtcNow.AddDays(Convert.ToInt16(_config["JwtExpiryDate"]));
        var token = new JwtSecurityToken(
            issuer: _config["JwtIssuer"],
            audience: _config["JwtAudience"],
            claims: claims,
            expires: expiryDate,
            signingCredentials: credentials
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return new TenantLoginResponse(true, null, jwt);
    }
}