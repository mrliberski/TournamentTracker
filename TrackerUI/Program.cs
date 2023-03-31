using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            //TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            //Application.Run(new TournamentDashboardForm());
            //Application.Run(new CreatePrizeForm());
            //Application.Run(new CreateTeamForm());
            System.Windows.Forms.Application.Run(new CreateTournamentForm());

        }
    }
}

//Resume on 15:30:00

// (00:00:00) 01 - Initial Planning
// (00:16:45) 02 - Overview Planning
// (00:46:09) 03 - Data Design
// (01:15:06) 04 - User Interface Design
// (01:34:26) 05 - Logic Planning
// (01:50:02) 06 - Class Library Creation
// (02:06:10) 07 - Form Building
// (03:08:24) 08 - SQL Database Design
// (04:12:49) 09 - Prize Form Wire Up
// (05:36:04) 10 - SQL Connection
// (06:46:37) 11 - Text Connection
// (07:44:24) 12 - Create Team Form Part 1
// (08:29:18) 13 - Create Team Form Part 2
// (09:12:34) 14 - Create Team Form Part 3
// (10:01:06) 15 - Create Tournament Form Part 1
// (10:33:21) 16 - Create Tournament Form Part 2
// (11:15:17) 17 - Create Tournament Form Part 3
// (12:34:12) 18 - Create Tournament Form Part 4
// (13:45:48) 19 - Create Tournament Form Part 5
// (16:12:12) 20 - Debugging
// (17:09:09) 21 - Dashboard Form
// (17:58:42) 22 - Tournament Viewer Part 1
// (19:07:33) 23 - Tournament Viewer Part 2
// (20:23:30) 24 - Refactoring
// (21:30:51) 25 - Error Handling
// (21:52:55) 26 - Emailing Users
// (23:01:27) 27 - Wrapping Up