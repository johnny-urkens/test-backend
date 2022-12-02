using backend.Dal.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace test_backend.Services
{
    public static class DatabaseManagement
    {
        public static void DbInitialisation(IApplicationBuilder app, UtContext context)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<UtContext>().Initialize(context);
            }
        }
    }
}
