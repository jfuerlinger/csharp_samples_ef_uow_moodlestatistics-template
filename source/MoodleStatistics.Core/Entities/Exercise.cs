using System.Collections.Generic;

namespace MoodleStatistics.Core.Entities
{
    public class Exercise : EntityObject
    {
        public string Title { get; set; }

        public ICollection<Activity> Activities { get; set; }

        public Exercise()
        {
            Activities=new List<Activity>();
        }
    }
}
