using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoodleStatistics.Core.Contracts;
using MoodleStatistics.Core.Entities;

namespace MoodleStatistics.Persistence
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ExerciseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}