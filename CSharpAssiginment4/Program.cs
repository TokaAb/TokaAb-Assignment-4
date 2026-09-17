using BenchmarkDotNet.Attributes;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

class Program
{
    static string[] sessionNames =
    {
        "C# Basics",
        "Arrays",
        "Functions",
        "Date and Time",
        "Exception Handling"
    };

    static DateTime[] sessionDates =
    {
        new DateTime(2026, 9, 10, 18, 0, 0),
        new DateTime(2026, 9, 13, 18, 0, 0),
        new DateTime(2026, 9, 17, 18, 0, 0),
        new DateTime(2026, 9, 20, 18, 0, 0),
        new DateTime(2026, 9, 24, 18, 0, 0)
    };

    static DateTime[] sessionStartTimes =
{
        new DateTime(2026, 9, 10, 18, 0, 0),
        new DateTime(2026, 9, 13, 18, 0, 0),
        new DateTime(2026, 9, 17, 18, 0, 0),
        new DateTime(2026, 9, 20, 18, 0, 0),
        new DateTime(2026, 9, 24, 18, 0, 0)
    };

    static int[] sessionDurations =
    {
        180,
        240,
        180,
        240,
        180
    };



    ////////part 2////////////////////

    static void Main()
    {
        DisplayallSessions(sessionNames, sessionDates, sessionStartTimes, sessionDurations);
        SearchSessionByName(sessionNames);
        SortSessionsnames(sessionNames, sessionDates, sessionStartTimes, sessionDurations);
        ReverseSessionsnames(sessionNames, sessionDates, sessionStartTimes, sessionDurations);
        FindSessionIndex(sessionNames);
        SessionExists(sessionNames);
        Findsession(sessionNames);
        Findsessionbyindex(sessionNames);
        CopySessions(sessionNames, sessionDates, sessionStartTimes, sessionDurations);
        totalDuration(sessionDurations);
        averageDuration(sessionDurations);
        shortestDuration(sessionDurations);
        longestDuration(sessionDurations);
        DisplayDurationStatistics(sessionDurations);
        ReadSessionDate();
        int x = 10;


        ChangeValue(x);
        Console.WriteLine($"Without ref: {x}");


        ValueWithRef(ref x);
        Console.WriteLine($"With ref: {x}");


        GetSessionInfo(out string sessionName, out int sessionDuration);
        Console.WriteLine($"Out: {sessionName} - {sessionDuration} minutes");

        string[] names = { "C# Basics", "Arrays" };

        ChangeArray(names);
        Console.WriteLine($"Reference type: {names[0]}");

        CalculateTotalDuration(120, 180);
        CalculateTotalDuration(120, 180, 240);
        CalculateTotalDuration(60, 90, 120, 180, 240);



        //11
        PastandUpcomingSessions(sessionNames, sessionDates);


        ReadMenuOption();

        ArrayIndex(sessionNames);


        //19
        string report = BuildReport(
                                    sessionNames,
                                    sessionDates,
                                    sessionStartTimes,
                                    sessionDurations);

        Console.WriteLine(report);


        //20
        string reportSB = BuildReportSB(
        sessionNames,
        sessionDates,
        sessionStartTimes,
        sessionDurations
    );

        Console.WriteLine(reportSB);



        //23
        BenchmarkRunner.Run<StringBenchmark>();
    }

    static void DisplayallSessions(
    string[] names,
    DateTime[] dates,
    DateTime[] startTimes,
    int[] durations)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {names[i]}");
            Console.WriteLine($"Date: {dates[i]:dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {startTimes[i]:hh:mm tt}");
            Console.WriteLine($"Duration: {durations[i]} minutes");
            Console.WriteLine();
        }
    }

    ////////part 3////////////////////

    public static void SearchSessionByName(string[] sessionNames)
    {

        Console.WriteLine("Enter Search Session Name:");
        string searchSessionName = Console.ReadLine();


        int index = Array.IndexOf(sessionNames, searchSessionName);

        if (index == 1)
        {
            Console.WriteLine($"Session Name: {sessionNames[index]}");
            Console.WriteLine($"Date: {sessionDates[index]:dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {sessionStartTimes[index]:hh:mm tt}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
        }
        else
        {
            Console.WriteLine("Session not found.");
        }

    }

    ////////part 4////////////////////

    public static void SortSessionsnames(string[] sessionNames, DateTime[] sessionDates, DateTime[] sessionStartTimes, int[] sessionDurations)
    {
        string[] copy = new string[sessionNames.Length];

        Array.Copy(sessionNames, copy, sessionNames.Length);
        Array.Sort(copy);

        foreach (string name in copy)
        {
            int index = Array.IndexOf(sessionNames, name);
            Console.WriteLine($"Session Name: {sessionNames[index]}");

        }
    }


    public static void ReverseSessionsnames(string[] sessionNames, DateTime[] sessionDates, DateTime[] sessionStartTimes, int[] sessionDurations)
    {
        string[] copy = new string[sessionNames.Length];

        Array.Copy(sessionNames, copy, sessionNames.Length);
        Array.Reverse(copy);

        foreach (string name in copy)
        {
            int index = Array.IndexOf(sessionNames, name);
            Console.WriteLine($"Session Name: {sessionNames[index]}");

        }
    }


    public static void FindSessionIndex(string[] sessionNames)
    {

        Console.WriteLine("Enter Session Name to Find Index:");
        string searchSessionName = Console.ReadLine();

        int Index = Array.IndexOf(sessionNames, searchSessionName);
        if (Index != -1)
        {
            Console.WriteLine($"Session Name: {sessionNames[Index]}");
            Console.WriteLine($"Index: {Index}");
        }
        else
        {
            Console.WriteLine("Session not found.");
        }

    }

    public static void SessionExists(string[] sessionNames)
    {
        Console.WriteLine("Enter Session Name :");
        string SessionExists = Console.ReadLine();

        bool exists = Array.Exists(sessionNames, name => name.Equals(SessionExists, StringComparison.OrdinalIgnoreCase));
        if (exists)
        {
            Console.WriteLine($"Session Name: {SessionExists} exists in the array.");
        }
        else
        {
            Console.WriteLine($"Session Name: {SessionExists} does not exist in the array.");
        }
    }


    public static void Findsession(string[] sessionNames)
    {
        Console.WriteLine("Enter Session Name for search:");
        string FindSessionName = Console.ReadLine();

        int index = Array.FindIndex(
            sessionNames,
            n => n == FindSessionName
        );

        if (index == -1)
        {
            Console.WriteLine("Session not found.");
        }
        else
        {
            Console.WriteLine($"Session Name: {sessionNames[index]}");
            Console.WriteLine($"Index: {index}");
        }
    }


    public static void Findsessionbyindex(string[] sessionNames)
    {
        Console.WriteLine("Enter Session Name for search:");
        string FindSessionName = Console.ReadLine();

        int index = Array.FindIndex(sessionNames, n => n == FindSessionName);

        if (index == -1)
        {
            Console.WriteLine("Session not found.");
        }
        else
        {
            Console.WriteLine($"Session Name: {sessionNames[index]}");
            Console.WriteLine($"Index: {index}");
        }
    }

    public static void CopySessions(string[] sessionNames, DateTime[] sessionDates, DateTime[] sessionStartTimes, int[] sessionDurations)
    {

        string[] copiedNames = new string[sessionNames.Length];
        Array.Copy(sessionNames, copiedNames, sessionNames.Length);

        copiedNames[0] = "Modified Session";

        Console.WriteLine("Original array:");

        for (int i = 0; i < sessionNames.Length; i++)
        {
            Console.WriteLine(sessionNames[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Copied array:");

        for (int i = 0; i < copiedNames.Length; i++)
        {
            Console.WriteLine(copiedNames[i]);
        }

    }

    ////////part 5////////////////////

    public static int totalDuration(int[] sessionDurations)
    {
        int totalDuration = 0;
        foreach (int duration in sessionDurations)
        {
            totalDuration += duration;
        }
        return totalDuration;
    }


    public static int averageDuration(int[] sessionDurations)
    {
        int totalDuration = 0;
        foreach (int duration in sessionDurations)
        {
            totalDuration += duration;
        }
        double averageDuration = (double)totalDuration / sessionDurations.Length;
        return (int)averageDuration;
    }

    public static int shortestDuration(int[] sessionDurations)
    {
        int shortestDuration = int.MaxValue;
        foreach (int duration in sessionDurations)
        {
            if (duration < shortestDuration)
            {
                shortestDuration = duration;
            }
        }
        return shortestDuration;
    }

    public static int longestDuration(int[] sessionDurations)
    {
        int longestDuration = int.MinValue;
        foreach (int duration in sessionDurations)
        {
            if (duration > longestDuration)
            {
                longestDuration = duration;
            }
        }
        return longestDuration;
    }

    static void DisplayDurationStatistics(int[] sessionDurations)
    {
        int[] Duration = new int[sessionDurations.Length];
        Array.Copy(sessionDurations, Duration, sessionDurations.Length);

        Array.Sort(Duration);
        Console.WriteLine($"Total Duration: {Duration.Sum()} minutes");
        Console.WriteLine($"Average Duration: {Duration.Average():F2} minutes");
        Console.WriteLine($"Shortest Duration: {Duration[0]} minutes");
        Console.WriteLine($"Longest Duration: {Duration[Duration.Length - 1]} minutes");

        foreach (int duration in Duration)
        {
            Console.WriteLine($"Duration: {duration} minutes");
        }

    }


    ////////part 6////////////////////

    public static DateTime GetSessionEndTime(
    DateTime startTime,
    int duration)
    {
        return startTime.AddMinutes(duration);
    }

    ////////part7 ////////////////////


    static void ChangeValue(int number)
    {
        number = 100;
    }

    //  Value type with ref
    static void ValueWithRef(ref int number)
    {
        number = 100;
    }


    //out parameter
    static void GetSessionInfo(out string name, out int duration)
    {
        name = "C# Basics";
        duration = 180;
    }

    //  Reference type
    static void ChangeArray(string[] names)
    {
        names[0] = "Changed Session";
    }



    ////////part8 ////////////////////

    static int CalculateTotalDuration(params int[] durations)
    {
        int totalDuration = 0;
        foreach (int duration in durations)
        {
            totalDuration += duration;
        }
        return totalDuration;


    }

    ////////part9////////////////////

    public static void searchforSession(
     string[] sessionNames,
     DateTime[] sessionDates,
     DateTime[] sessionStartTimes,
     int[] sessionDurations)

    {
        Console.WriteLine("entre session name");
        string searchName = Console.ReadLine();


        int index = Array.IndexOf(sessionNames, searchName);

        DateTime date = sessionDates[index];
        DateTime startTime = sessionStartTimes[index];
        int duration = sessionDurations[index];
        DateTime endTime = startTime.AddMinutes(duration);

        if (index != -1)
        {
            Console.WriteLine($"Session Name: {sessionNames[index]}");
            Console.WriteLine($"Date: {sessionDates[index]:dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {sessionStartTimes[index]:hh:mm tt}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
            Console.WriteLine($"Date: {date:dd MMMM yyyy}");
            Console.WriteLine($"Day: {date.DayOfWeek}");
            Console.WriteLine($"Year: {date.Year}");
            Console.WriteLine($"Month: {date.Month}");
            Console.WriteLine($"Day Number: {date.Day}");
            Console.WriteLine($"Start Time: {startTime:hh:mm tt}");
            Console.WriteLine($"Duration: {duration} minutes");
            Console.WriteLine($"End Time: {endTime:hh:mm tt}");
        }
        else
        {
            Console.WriteLine("Session not found.");
        }
    }


    ////////part10////////////////////


    public static void twoSessions(
    string[] sessionNames,
    DateTime[] sessionDates,
    DateTime[] sessionStartTimes,
    int[] sessionDurations)

    {
        Console.WriteLine("enter seesion1");
        string session1 = Console.ReadLine();

        Console.WriteLine("enter seesion2");
        string session2 = Console.ReadLine();

        int index1 = Array.IndexOf(sessionNames, session1);
        int index2 = Array.IndexOf(sessionNames, session2);

        if (index1 != -1 && index2 != -1)
        {
            TimeSpan difference =
                sessionStartTimes[index2] - sessionStartTimes[index1];

            Console.WriteLine(
                $"Difference between {session1} and {session2} is {difference.TotalMinutes} minutes");
        }
        else
        {
            Console.WriteLine("Session not found.");
        }

    }



    ////////part11////////////////////

    public static void PastandUpcomingSessions(
   string[] sessionNames,
   DateTime[] sessionDates
  )
    {

        for (int i = 0; i < sessionNames.Length; i++)
        {
            if (sessionDates[i] < DateTime.Now)
            {
                Console.WriteLine($"Past Session: {sessionNames[i]} - Past");
            }
            else
            {
                Console.WriteLine($"Upcoming Session: {sessionNames[i]} - Upcoming");
            }


        }


    }
    ////////part12////////////////////

    public static void nearestSession(
        string[] sessionNames,
   DateTime[] sessionDates
  )

    {
        int nearestIndex = 0;


        for (int i = 0; i < sessionNames.Length; i++)
        {

            TimeSpan currentdifference = sessionDates[i] - DateTime.Now;
            TimeSpan nearestdifference = sessionDates[nearestIndex] - DateTime.Now;

            if (currentdifference.TotalMinutes > 0 && currentdifference < nearestdifference)
            {
                nearestIndex = i;
            }


        }
        string nearestSessionName = sessionNames[nearestIndex];
        Console.WriteLine($"Nearest Session: {nearestSessionName}");

    }



    ////////part13////////////////////

    public static void DisplayFormattedSession(
    string[] sessionNames,
    DateTime[] sessionDates,
    DateTime[] sessionStartTimes)
    {
        Console.Write("Enter session name: ");
        string sessionName = Console.ReadLine();

        int index = Array.IndexOf(sessionNames, sessionName);

        if (index != -1)
        {
            DateTime date = sessionDates[index];
            DateTime startTime = sessionStartTimes[index];

            Console.WriteLine($"yyyy-MM-dd: {date.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"dd/MM/yyyy: {date.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"dd MMMM yyyy: {date.ToString("dd MMMM yyyy")}");
            Console.WriteLine($"dddd, dd MMMM yyyy: {date.ToString("dddd, dd MMMM yyyy")}");
            Console.WriteLine($"hh:mm tt: {startTime.ToString("hh:mm tt")}");
        }
        else
        {
            Console.WriteLine("Session not found.");
        }
    }



    ////////part14////////////////////

    static DateTime ReadSessionDate()
    {
        while (true)
        {
            Console.WriteLine("Enter session date (yyyy-MM-dd HH:mm):");
            string dateInput = Console.ReadLine();

            DateTime sessionDate;

            if (DateTime.TryParseExact(
                dateInput,
                "yyyy-MM-dd HH:mm",
                null,
                System.Globalization.DateTimeStyles.None,
                out sessionDate))
            {
                return sessionDate;
            }

            Console.WriteLine("Invalid date. Try again.");
        }
    }




    ////////part15////////////////////


    static int ReadMenuOption()
    {
        while (true)
        {
            Console.WriteLine("Choose an option: ");

            try
            {

                int option = int.Parse(Console.ReadLine());
                return option;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid menu option. Enter a number.");
            }


        }
    }


      ////////part16////////////////////


    static int ArrayIndex(string[] sessionNames)
    {
       
        try
        {
            Console.WriteLine("enter session index");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(sessionNames[index]);
            return index;
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("The selected session index is out of range.");
            return -1;

        }


    }


    ////////part17////////////////////



    static void TestDuration(int duraion)
    {


        if (duraion <= 0)
        {
            throw new ArgumentException("A valid duration must be greater than zero.");
        }

        Console.WriteLine("Duration accepted.");


        try
        {
            Console.WriteLine("enter duration:");

            int duration = int.Parse(Console.ReadLine());

            TestDuration(duration);

        } catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);

        }
        finally
        {
            //Input operation finished.
            Console.WriteLine("Input operation finished.");
        }
    }

    ////////part19////////////////////

    static string BuildReport(string[] sessionNames,
    DateTime[] sessionDates,
    DateTime[] sessionStartTimes,
    int[] sessionDurations)
    {

        string result = "";

        for (int i = 0; i < sessionNames.Length; i++)
        {
            result += $"{sessionNames[i]} - " +
                      $"{sessionDates[i]:dd/MM/yyyy} " +
                      $"{sessionStartTimes[i]:hh:mm tt} - " +
                      $"{sessionDurations[i]} minutes\n";
        }

        return result;
    }

    ////////part20////////////////////

    static string BuildReportSB(
    string[] sessionNames,
    DateTime[] sessionDates,
    DateTime[] sessionStartTimes,
    int[] sessionDurations)

    {         
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < sessionNames.Length; i++)
        {
            result.AppendLine($"{sessionNames[i]} - " +
                              $"{sessionDates[i]:dd/MM/yyyy} " +
                              $"{sessionStartTimes[i]:hh:mm tt} - " +
                              $"{sessionDurations[i]} minutes");
        }
        return result.ToString();
    }



}

////////part21////////////////////



[MemoryDiagnoser]
public class StringBenchmark
{
    [Benchmark]
    public string StringConcatenation()
    {
        string result = "";

        for (int i = 0; i < 1000; i++)
        {
            result += "Academy Schedule";
        }

        return result;
    }

    [Params(100, 1000, 10000, 100000)]
    public int Iterations;


    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < 1000; i++)
        {
            result.Append("Academy Schedule");
        }

        return result.ToString();
    }


}