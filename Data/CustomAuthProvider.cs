using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Threading.Tasks;
using System.Security.Claims;
using Blazored.SessionStorage;

public class CustomAuthProvider : AuthenticationStateProvider
{
    private ISessionStorageService storage;
    public CustomAuthProvider(ISessionStorageService ss)
    {
        storage = ss;
    }
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var emailAddy = await storage.GetItemAsync<string>("email");
        ClaimsIdentity identity;
        if(emailAddy != null)
        {
            identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, emailAddy),
            }, "apiauth_type");
        }
        else
        {
            identity = new ClaimsIdentity();
        }

        var user = new ClaimsPrincipal(identity);

        return await Task.FromResult(new AuthenticationState(user));
    }

    public void MakeUserAuth(string email)
    {
        var identity = new ClaimsIdentity(new[] {
            new Claim(ClaimTypes.Name, email),
        }, "apiauth_type");

        var user = new ClaimsPrincipal(identity);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }

    public void removeAuth()
    {
        var identity = new ClaimsIdentity();

        var user = new ClaimsPrincipal(identity);
        storage.RemoveItemAsync("email");
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }

    
}