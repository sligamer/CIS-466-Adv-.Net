using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_MultiFormProject_Freres
{

    /// <summary>
    /// Author: Justin Freres
    /// create a multiple form project, an initial form that allows the user to select a button that will open the following:  
    /// one form that uses two math queries, then the second button will open another form that does parameterized query.  
    /// You may either use the Grid or Details View. Also, to permanently store the updates to the DB.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startupfrm());
        }
    }
}
