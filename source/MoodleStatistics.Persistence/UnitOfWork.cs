using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoodleStatistics.Core.Contracts;

namespace MoodleStatistics.Persistence
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly ApplicationDbContext _dbContext;
    private bool _disposed;

    /// <summary>
    /// ConnectionString kommt aus den appsettings.json
    /// </summary>
    public UnitOfWork()
    {
      _dbContext = new ApplicationDbContext();
      Pupils = new PupilRepository(_dbContext);
      Exercises = new ExerciseRepository(_dbContext);
      Activities = new ActivityRepository(_dbContext);
    }

    public IPupilRepository Pupils { get; }
    public IExerciseRepository Exercises { get; }
    public IActivityRepository Activities { get; }


    public int SaveChanges() => _dbContext.SaveChanges();
    public void DeleteDatabase() => _dbContext.Database.EnsureDeleted();
    public void MigrateDatabase() => _dbContext.Database.Migrate();
    public void CreateDatabase() => _dbContext.Database.EnsureCreated();

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
      if (!_disposed)
      {
        if (disposing)
        {
          _dbContext.Dispose();
        }
      }
      _disposed = true;
    }
  }
}
