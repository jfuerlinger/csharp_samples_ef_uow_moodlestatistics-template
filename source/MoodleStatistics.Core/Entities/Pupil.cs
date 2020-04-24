using System.Collections.Generic;

namespace MoodleStatistics.Core.Entities
{
    public class Pupil : EntityObject
    {
        public string Name { get; set; }

        public ICollection<Activity> Activities { get; set; }

        public Pupil()
        {
            Activities = new List<Activity>();
        }
    }
}
