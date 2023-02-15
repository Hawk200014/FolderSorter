namespace FolderSorter
{
    internal static class Program
    {
        public static ErrorLogging ErrorLogging= new ErrorLogging();
        public static FolderManager folderManager = new FolderManager();
        public static SortArgumentsStorage sortArgumentsStorage = new SortArgumentsStorage();
        public static SourceArgumentStorage sourceArgumentStorage = new SourceArgumentStorage();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}