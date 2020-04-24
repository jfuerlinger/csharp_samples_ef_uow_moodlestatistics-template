using System;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using MoodleStatistics.Core;
using MoodleStatistics.Core.Contracts;
using MoodleStatistics.Core.DataTransferObjects;
using MoodleStatistics.Persistence;

namespace MoodleStatistics.ImportConsole
{
    class Program
    {
        static  void Main()
        {
            Console.WriteLine("Import der Schüler und Abgaben in die Datenbank");
            Console.WriteLine("===============================================");

            InitializeDatabase();
            ImportData();
            AnalyseMoodleStatistics();

            Console.WriteLine();
            Console.Write("Beenden mit Eingabetaste ...");
            Console.ReadLine();
        }

        static  void InitializeDatabase()
        {
            using IUnitOfWork unitOfWork = new UnitOfWork();

            Console.WriteLine("Datenbank löschen");
            unitOfWork.DeleteDatabase();

            Console.WriteLine("Datenbank migrieren");
            unitOfWork.MigrateDatabase();

        }

        static  void ImportData()
        {
            Console.WriteLine("Import der Actiivities, Pupils und Exercises in die Datenbank");
            Console.WriteLine("Activities werden von moodlestatistics.csv eingelesen");
        }

        private static  void AnalyseMoodleStatistics()
        {
            using IUnitOfWork unitOfWork = new UnitOfWork();

            //var activityDescriptions = unitOfWork.Activities.GetUniqueActivityDescriptions();
            //PrintResult(
            //    $"Aktivitätstexte sortiert",
            //    string.Join(", ", activityDescriptions));

            //var dayWithMostSubmissions = unitOfWork.Activities.GetDateWithMostSubmissions();
            //PrintResult(
            //    $"Tag mit den meisten Abgaben",
            //    $"Datum: {dayWithMostSubmissions.Date.ToShortDateString()}, Anzahl: {dayWithMostSubmissions.Count}");

            //var pupilWithMostAcitivities = unitOfWork.Pupils.GetWithMostActivitiesCount();
            //PrintResult(
            //    $"Pupil mit den meisten Aktivitäten",
            //    $"Pupil: {pupilWithMostAcitivities.Pupil.Name}, Count: {pupilWithMostAcitivities.Count}");

            //var exerciseWithMostDutyStateShown = unitOfWork.Exercises.GetExerciseWithMostDutyStateShown();
            //PrintResult(
            //    $"Exercise mit den meisten Aktivitäten 'Abgabestatus angezeigt'",
            //    $"Exercise: {exerciseWithMostDutyStateShown.Exercise.Title}, Count: {exerciseWithMostDutyStateShown.Count}");

            //var overviewPupilExercises = unitOfWork.Pupils.GetPupilOverviews();
            //PrintResult(
            //    $"Schüler mit gelesenen und abgebenen Aufgaben",
            //    ConsoleTable
            //        .From(overviewPupilExercises)
            //        .Configure(o => o.NumberAlignment = Alignment.Right)
            //        .ToStringAlternative());

            //ExerciseDetailDto[] fastestSolvedExercises = unitOfWork.Pupils.GetTenFastestSolvedExercises();
            //PrintResult(
            //    $"Zehn am schnellsten gelöste Aufgaben",
            //    ConsoleTable
            //        .From(fastestSolvedExercises)
            //        .Configure(o => o.NumberAlignment = Alignment.Right)
            //        .ToStringAlternative());
        }

        /// <summary>
        /// Erstellt eine Konsolenausgabe
        /// </summary>
        /// <param name="caption">Enthält die Überschrift</param>
        /// <param name="result">Enthält das ermittelte Ergebnisse</param>
        private static void PrintResult(string caption, string result)
        {
            Console.WriteLine();

            if (!string.IsNullOrEmpty(caption))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(new String('=', caption.Length));
                Console.WriteLine(caption);
                Console.WriteLine(new String('=', caption.Length));
                Console.ResetColor();
                //Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(result);
            Console.ResetColor();
            Console.WriteLine();
        }

    }
}
