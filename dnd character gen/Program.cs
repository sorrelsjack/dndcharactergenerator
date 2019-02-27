using System;
using System.Windows.Forms;

namespace dnd_character_gen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterSheet());
            //TODO talk to SQL DB
            //TODO change connection string for friends automatically
            //TODO run SQL scripts upon getting the software
            //TODO ask user if they want to save upon quit
        }
    }
}