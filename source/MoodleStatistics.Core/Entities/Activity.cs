using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodleStatistics.Core.Entities
{
    public class Activity : EntityObject
    {
        public int PupilId { get; set; }
        [ForeignKey(nameof(PupilId))]
        public Pupil Pupil { get; set; }

        public int ExerciseId { get; set; }
        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; }

        public DateTime Time { get; set; }

        public string Description { get; set; }
    }
}
