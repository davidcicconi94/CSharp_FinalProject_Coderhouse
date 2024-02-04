using Coder.DataAccess.Context;
using Coder.DataAccess.Persistance;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Coder.Api
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configuration of Service
            var serviceProvider = new ServiceCollection()
                .AddPersistance(new ConfigurationBuilder().Build())
                .BuildServiceProvider();

            // Get DbContext instance
            var dbContext = serviceProvider.GetService<ApplicationDbContext>();


            Application.Run(new Form1());
        }
    }
}