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
            //TODO talk to SQLite DB (library references provided)
        }
    }
}