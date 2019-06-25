using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsa_Selection
{
    static class Program
    {
        public static class MyGlobal
        {
            static string _connectionString;

            public static string ConnectionString
            {
                get
                {
                    return _connectionString;
                }
                set
                {
                    _connectionString = value;
                }
            }
        }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
