using Time.Planning.Forms;
using Time.Planning.Objects;
using Time.Planning.Services;

namespace Time.Planning
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeFm( new ChickRepository( new MyDb() )));
        }
    }
}