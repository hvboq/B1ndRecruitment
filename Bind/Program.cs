using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bind
{
    static class Program
    {
        public static ApplicationContext ac = new ApplicationContext();
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(true);

            LogIn startForm = new LogIn();
            ac.MainForm = startForm;

            Application.Run(ac);

            Application.EnableVisualStyles();
            
            Application.Run(new LogIn());
        }
    }
}
