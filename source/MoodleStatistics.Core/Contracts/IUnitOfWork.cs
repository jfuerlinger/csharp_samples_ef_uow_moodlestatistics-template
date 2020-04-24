using System;
using System.Threading.Tasks;

namespace MoodleStatistics.Core.Contracts
{
  public interface IUnitOfWork : IDisposable
  {
    IExerciseRepository Exercises { get; }
    IActivityRepository Activities { get; }
    IPupilRepository Pupils { get; }

    int SaveChanges();
    void DeleteDatabase();
    void MigrateDatabase();
    void CreateDatabase();
  }
}
