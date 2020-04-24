using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MoodleStatistics.Core.Entities;

namespace MoodleStatistics.Persistence
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Core.Entities.Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();
            Debug.Write(configuration.ToString());
            string connectionString = configuration["ConnectionStrings:DefaultConnection"];
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLoggerFactory(GetLoggerFactory());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        /// <summary>
        /// NuGet: Microsoft.Extensions.Logging.Console
        /// </summary>
        /// <returns></returns>
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                builder.AddConsole()
                    .AddFilter(DbLoggerCategory.Database.Command.Name,
                        LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                .GetService<ILoggerFactory>();
        }

    }
}
