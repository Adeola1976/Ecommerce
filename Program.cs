using System;
using Microsoft.Extensions.DependencyInjection;
using Week6Task.Database;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Week6Task
{
    class Program : IDesignTimeDbContextFactory<FWContext>
    {
        private const string Connection = @"Data Source=LAPTOP-0VSJ0RU3; Initial Catalog=EcoDB; Integrated Security=true;MultipleActiveResultSets=True;";
        private static IServiceProvider ServiceProvider;
        static void Main(string[] args)
        {
            ConfigureServices();
            FWContext context = ServiceProvider.GetRequiredService<FWContext>();
            Seeder.SeedData(context).Wait();
        }


        public static void ConfigureServices()
        {
            var Service = new ServiceCollection();
            Service.AddDbContext<FWContext>(Options => Options.UseSqlServer(Connection));
            ServiceProvider = Service.BuildServiceProvider();
        }
      public FWContext CreateDbContext(String[] args)
       {
            var optionBuilder = new DbContextOptionsBuilder<FWContext>();
            optionBuilder.UseSqlServer(Connection);
            return new FWContext(optionBuilder.Options);
       }
    }
}
