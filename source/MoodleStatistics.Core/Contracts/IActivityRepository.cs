using System;
using System.Threading.Tasks;
using MoodleStatistics.Core.Entities;

namespace MoodleStatistics.Core.Contracts
{
    public interface IActivityRepository
    {
        void AddRange(Activity[] activities);
    }
}