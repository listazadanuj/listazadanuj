using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           
        // //   Class1.addUser("SPODEassddewdRMAN", "SPOasdDERMAN");
          Class1.getPriorities();
          Class1.getTasksCount();
          Class1.returnUniqueId();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

         
        }
    }
}
