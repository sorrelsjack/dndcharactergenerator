﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_character_gen {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new charactersheet());
            //TODO talk to SQL DB
            //TODO change connection string for friends automatically
            //TODO run SQL scripts upon getting the software
            //TODO source character name from API?
            //TODO ask user if they want to save upon quit
            //TODO pronouns?
        }
    }
}
