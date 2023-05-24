using Microsoft.AspNetCore.Mvc;

namespace instagram.Extension;

public static class ProfileCreator
{
    public static void AddProfile(this MvcOptions options)
    {
        options.CacheProfiles.Add("Caching", new CacheProfile()
        {
            Duration = 300,
            Location = ResponseCacheLocation.Any
        });
        
        options.CacheProfiles.Add("NoCaching", new CacheProfile()
        {
            Location = ResponseCacheLocation.None,
            NoStore = true
        });
    }
}