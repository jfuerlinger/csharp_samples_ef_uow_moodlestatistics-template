using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoodleStatistics.Core.Contracts;
using MoodleStatistics.Core.Entities;

namespace MoodleStatistics.Persistence
{
  public class ActivityRepository : IActivityRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public ActivityRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public void AddRange(Activity[] activities)
    {
      _dbContext.Activities.AddRange(activities);
    }

  }
}