using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoodleStatistics.Core.Contracts;
using MoodleStatistics.Core.DataTransferObjects;
using MoodleStatistics.Core.Entities;

namespace MoodleStatistics.Persistence
{
    public class PupilRepository : IPupilRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PupilRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}